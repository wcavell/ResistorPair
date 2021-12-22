/*
 *代码瞎几把乱写，能用就行！
 *
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPTools
{
    public partial class Form1 : Form
    {
        private List<Control> controls = new List<Control>();
        private readonly double[] E24 =
        {
            1.0, 1.1, 1.2, 1.3, 1.5, 1.6, 1.8, 2.0, 2.2, 2.4, 2.7, 3.0, 3.3, 3.6, 3.9, 4.3, 4.7, 5.1, 5.6, 6.2, 6.8,
            7.5, 8.2, 9.1
        };

        private readonly double[] E48 =
        {
            1.00, 1.05, 1.10, 1.15, 1.21, 1.27, 1.33, 1.40, 1.47, 1.54, 1.62, 1.69, 1.78, 1.87, 1.96, 2.05, 2.15, 2.26,
            2.37, 2.49, 2.61, 2.74, 2.87, 3.01, 3.16, 3.32, 3.48, 3.65, 3.83, 4.02, 4.22, 4.42, 4.64, 4.87, 5.11, 5.36,
            5.62, 5.90, 6.19, 6.49, 6.81, 7.15, 7.50, 7.87, 8.25, 8.66, 9.09, 9.53
        };
        private readonly double[] E96 =
        {
            1.00, 1.02, 1.05, 1.07, 1.10, 1.13, 1.15, 1.18, 1.21, 1.24, 1.27, 1.30, 1.33, 1.37, 1.40, 1.43, 1.47, 1.50,
            1.54, 1.58, 1.62, 1.65, 1.69, 1.74, 1.78, 1.82, 1.87, 1.91, 1.96, 2.00, 2.05, 2.10, 2.15, 2.21, 2.26, 2.32,
            2.37, 2.43, 2.49, 2.55, 2.61, 2.67, 2.74, 2.80, 2.87, 2.94, 3.01, 3.09, 3.16, 3.24, 3.32, 3.40, 3.48, 3.57,
            3.65, 3.74, 3.83, 3.92, 4.02, 4.12, 4.22, 4.32, 4.42, 4.53, 4.64, 4.75, 4.87, 4.99, 5.11, 5.23, 5.36, 5.49,
            5.62, 5.76, 5.90, 6.04, 6.19, 6.34, 6.49, 6.65, 6.81, 6.98, 7.15, 7.32, 7.50, 7.68, 7.87, 8.06, 8.25, 8.45,
            8.66, 8.87, 9.09, 9.31, 9.53, 9.76
        };

        private readonly double[] E192 =
        {
            1.00, 1.01, 1.02, 1.04, 1.05, 1.06, 1.07, 1.09, 1.10, 1.11, 1.13, 1.14, 1.15, 1.17, 1.18, 1.20, 1.21, 1.23,
            1.24, 1.26, 1.27, 1.29, 1.30, 1.32, 1.33, 1.35, 1.37, 1.38, 1.40, 1.42, 1.43, 1.45, 1.47, 1.49, 1.50, 1.52,
            1.54, 1.56, 1.58, 1.60, 1.62, 1.64, 1.65, 1.67, 1.69, 1.72, 1.74, 1.76, 1.78, 1.80, 1.82, 1.84, 1.87, 1.89,
            1.91, 1.93, 1.96, 1.98, 2.00, 2.03, 2.05, 2.08, 2.10, 2.13, 2.15, 2.18, 2.21, 2.23, 2.26, 2.29, 2.32, 2.34,
            2.37, 2.40, 2.43, 2.46, 2.49, 2.52, 2.55, 2.58, 2.61, 2.64, 2.67, 2.71, 2.74, 2.77, 2.80, 2.84, 2.87, 2.91,
            2.94, 2.98, 3.01, 3.05, 3.09, 3.12, 3.16, 3.20, 3.24, 3.28, 3.32, 3.36, 3.40, 3.44, 3.48, 3.52, 3.57, 3.61,
            3.65, 3.70, 3.74, 3.79, 3.83, 3.88, 3.92, 3.97, 4.02, 4.07, 4.12, 4.17, 4.22, 4.27, 4.32, 4.37, 4.42, 4.48,
            4.53, 4.59, 4.64, 4.70, 4.75, 4.81, 4.87, 4.93, 4.99, 5.05, 5.11, 5.17, 5.23, 5.30, 5.36, 5.42, 5.49, 5.56,
            5.62, 5.69, 5.76, 5.83, 5.90, 5.97, 6.04, 6.12, 6.19, 6.26, 6.34, 6.42, 6.49, 6.57, 6.65, 6.73, 6.81, 6.90,
            6.98, 7.06, 7.15, 7.23, 7.32, 7.41, 7.50, 7.59, 7.68, 7.77, 7.87, 7.96, 8.06, 8.16, 8.25, 8.35, 8.45, 8.56,
            8.66, 8.76, 8.87, 8.98, 9.09, 9.20, 9.31, 9.42, 9.53, 9.65, 9.76, 9.88

        };

        private List<ResistorData> resistorDatas = new List<ResistorData>();
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbType.DataSource = Enum.GetValues(typeof(RType));
            cbType.SelectedIndex = 2;
            cbMode.DataSource = Enum.GetValues(typeof(ModeType));
            cbMode.SelectedIndex = 0;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')   //允许输入回退键
            {
                TextBox tb = sender as TextBox;

                if (tb.Text == "")
                {
                    tb.Text = "0.";
                    tb.Select(tb.Text.Length, 0);
                    e.Handled = true;
                }
                else if (tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }

            if (e.KeyChar == 13)//回车
            {
               OnSearch();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OnSearch();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSearch();
        }

        private void checkOver_CheckedChanged(object sender, EventArgs e)
        {
            OnSearch();
        }

        private void OnSearch()
        {
            if (string.IsNullOrWhiteSpace(tbVin.Text) || string.IsNullOrWhiteSpace(tbVout.Text))
                return;
            RType rt = (RType)cbType.SelectedItem;
            ModeType mode = (ModeType)cbMode.SelectedItem;
            double vin = double.Parse(tbVin.Text);
            double vout = double.Parse(tbVout.Text);

            for (int i = controls.Count - 1; i >= 0; i--)
            {
                if (controls[i] != null)
                {
                    controls[i].Dispose();
                }
                controls.Remove(controls[i]);
            }

            Label lber = new Label();
            lber.AutoSize = true;
            lber.Location = new Point(80, 108);
            lber.ForeColor = Color.Red;
            if (vin <= 0 || vout <= 0)
            {
                lber.Text = "输入或输出要大于0！！！";
                controls.Add(lber);
                lber.Parent = this;
                return;
            }
            if (vout >= vin)
            {
                lber.Text = "输出不能大于输入";
                controls.Add(lber);
                lber.Parent = this;
                return;
            }

            if (Math.Abs(vin / 2 - vout) <= 0.005)
            {
                lber.Text = "R1=====R2";
                controls.Add(lber);
                lber.Parent = this;
                return;
            }

            bool smallVoltage = (vin / 2 - vout) > 0;
            List<double> rds = new List<double>();
            switch (rt)
            {
                case RType.E24:
                    rds.AddRange(E24);
                    break;
                case RType.E48:
                    rds.AddRange(E48);
                    break;
                case RType.E96:
                    rds.AddRange(E96);
                    break;
                case RType.E192:
                    rds.AddRange(E192);
                    break;
                default:
                    rds.AddRange(E24);
                    break;
            } 

            var cout = rds.Count;
            for (int i = 0; i < cout; i++)
            {
                rds.Add(rds[i] * 10);
            }
            resistorDatas.Clear();
            for (int i = 0; i < rds.Count; i++)
            {
                for (int j = 0; j < rds.Count; j++)
                {
                    var R1 = rds[i];
                    var R2 = rds[j];
                    if (mode == ModeType.Parallel)
                    {
                        for (int k = 0; k < rds.Count; k++)
                        {
                            R2 = 1 / (1 / rds[j] + 1 / rds[k]);
                            var resultlVin = R2 / (R1 + R2) * vin;
                            if (Math.Abs(resultlVin - vout) < 0.03)
                            {

                                var rData = new ResistorData();
                                rData.R1 = R1;
                                rData.R2 = R2;
                                rData.R3 = rds[j];
                                rData.R4 = rds[k];
                                rData.Vout = resultlVin;
                                rData.Vin = vout / (R2 / (R1 + R2));
                                resistorDatas.Add(rData);
                            }
                        }
                    }
                    else
                    {
                        var resultVout = R2 / (R1 + R2) * vin;
                        if (Math.Abs(resultVout - vout) < 0.03)
                        {
                            var rData = new ResistorData();
                            rData.R1 = R1;
                            rData.R2 = R2;
                            rData.Vout = resultVout;
                            rData.Vin = vout / (R2 / (R1 + R2));
                            resistorDatas.Add(rData);
                        }
                    }

                }
            }
#if DEBUG
            var temp = resistorDatas.OrderBy(x => x.Vout);
#endif
            if (mode == ModeType.Parallel)//数据去重
            {
                resistorDatas = resistorDatas.Distinct().ToList();
            } 
            var result = resistorDatas.OrderBy(x => Math.Abs(vout - x.Vout)).Take(15).ToList();
            bool hasOverVol = false;
            hasOverVol = smallVoltage ? result.Any(x => x.Vout - vout > 0) : result.Any(x => vout - x.Vout > 0);
            if (checkOver.Checked && !hasOverVol)
            {
                if (smallVoltage)
                {
                    var overdata = resistorDatas.OrderBy(x => x.Vout)
                        .First(x => x.Vout - vout > 0); 
                    result.Add(overdata);
                }
                else
                {
                    var overdata = resistorDatas.OrderByDescending(x => x.Vout)
                        .First(x => x.Vout - vout < 0);
                    result.Add(overdata);
                }

            }
            Label title = new Label();
            title.Parent = this;
            title.AutoSize = true;
            if (cbMode.SelectedIndex == 0)
            {
                title.Text = "   R1       R2     接近输出电压    目标输入电源(" + vout + "V)";
            }
            else
            {
                title.Text = @"    R1   R2(R3并R4)      R3       R4     接近输出电压    目标输入电源(" + vout + "V)";
            }
            title.Location = new Point(12, 108);
            title.ForeColor = Color.Black;
            controls.Add(title);
            for (int i = 0; i < result.Count; i++)
            {
                Label lb = new Label();
                lb.Parent = this;
                lb.AutoSize = true;
                lb.Location = new Point(12, 128 + i * 20);
                if (mode == ModeType.Default)
                {
                    lb.Text = string.Format("{0,5}", result[i].R1) + "R   " + string.Format("{0,5}", result[i].R2) +
                              "R     " + result[i].Vout.ToString("N6") + "V      " +
                              result[i].Vin.ToString("N5") + "V";
                }
                else if (mode == ModeType.Parallel)
                {
                    lb.Text = string.Format("{0,5}", result[i].R1) + "R   " +
                              string.Format("{0,5}", result[i].R2.ToString("N6")) + "R   " +
                              string.Format("{0,5}", result[i].R3) + "R   " +
                              String.Format("{0,5}", result[i].R4) + "R     " +
                              result[i].Vout.ToString("N6") + "V       " +
                              result[i].Vin.ToString("N5") + "V";

                }

                if (i == 0 || (i == result.Count - 1 && checkOver.Checked && !hasOverVol))
                {
                    if (i == result.Count - 1 && checkOver.Checked && !hasOverVol)
                    {
                        lb.Text += "(超电压)";
                    }
                    lb.ForeColor = Color.Red;
                }
                else
                {
                    lb.ForeColor = Color.Black;
                }

                controls.Add(lb);
            }
        }
    }
    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum RType
    {
        [Description("E24(±5%)")]
        E24,
        [Description("E48(±2%)")]
        E48,
        [Description("E96(±1%)")]
        E96,
        [Description("E192(±0.5%)")]
        E192
    }
    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum ModeType
    {
        [Description("默认(单电阻)")]
        Default,
        [Description("并联(双电阻)")]
        Parallel
    }
    public class EnumToStringUsingDescription : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType.Equals(typeof(Enum)));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType.Equals(typeof(String)));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!destinationType.Equals(typeof(String)))
            {
                throw new ArgumentException("Can only convert to string.", "destinationType");
            }

            if (!value.GetType().BaseType.Equals(typeof(Enum)))
            {
                throw new ArgumentException("Can only convert an instance of enum.", "value");
            }

            string name = value.ToString();
            object[] attrs =
                value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attrs.Length > 0) ? ((DescriptionAttribute)attrs[0]).Description : name;
        }
    }

    public class ResistorData:IEquatable<ResistorData>
    {
        /// <summary>
        /// 电阻R1
        /// </summary>
        public double R1 { get; set; } = 0;

        /// <summary>
        /// 电阻R2，如果选择并联则R2=1/(1/R3+1/R4);
        /// </summary>
        public double R2 { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        public double R3 { get; set; } = 0;

        public double R4 { get; set; } = 0;
        public double Vout { get; set; }
        public double Vin { get; set; }

        public bool Equals(ResistorData other)
        {
            //return R2 == other.R2;
            return (Math.Abs(R3 - other.R4) <= 0.001 && Math.Abs(R4 - other.R3) <= 0.001);
        }

        public override int GetHashCode()
        {
            return R2.GetHashCode();
        }

#if DEBUG
        public override string ToString()
        {
            return Vout.ToString("N8");
        }
#endif
        
    }
}
