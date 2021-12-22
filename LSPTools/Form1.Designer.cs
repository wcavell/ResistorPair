
namespace LSPTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVout = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.checkOver = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(55, 18);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(101, 20);
            this.cbType.TabIndex = 0;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(2, 22);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(35, 12);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "标准:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入电压:";
            // 
            // tbVin
            // 
            this.tbVin.Location = new System.Drawing.Point(241, 18);
            this.tbVin.Name = "tbVin";
            this.tbVin.Size = new System.Drawing.Size(74, 21);
            this.tbVin.TabIndex = 3;
            this.tbVin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "输出电压:";
            // 
            // tbVout
            // 
            this.tbVout.Location = new System.Drawing.Point(241, 48);
            this.tbVout.Name = "tbVout";
            this.tbVout.Size = new System.Drawing.Size(74, 21);
            this.tbVout.TabIndex = 5;
            this.tbVout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbVout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "电阻匹配";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "电阻配对结果:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(566, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 174);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "R2模式:";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(55, 48);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(101, 20);
            this.cbMode.TabIndex = 10;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // checkOver
            // 
            this.checkOver.AutoSize = true;
            this.checkOver.Location = new System.Drawing.Point(346, 18);
            this.checkOver.Name = "checkOver";
            this.checkOver.Size = new System.Drawing.Size(120, 16);
            this.checkOver.TabIndex = 11;
            this.checkOver.Text = "确保有超输出电压";
            this.checkOver.UseVisualStyleBackColor = true;
            this.checkOver.CheckedChanged += new System.EventHandler(this.checkOver_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(613, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "输入回车即可匹配";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkOver);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbVout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbType);
            this.Name = "Form1";
            this.Text = "分压电阻匹配工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.CheckBox checkOver;
        private System.Windows.Forms.Label label5;
    }
}

