namespace 票選系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdiphone = new System.Windows.Forms.RadioButton();
            this.rdhtc = new System.Windows.Forms.RadioButton();
            this.rdsamsung = new System.Windows.Forms.RadioButton();
            this.rdsony = new System.Windows.Forms.RadioButton();
            this.txtiphone = new System.Windows.Forms.TextBox();
            this.txthtc = new System.Windows.Forms.TextBox();
            this.txtsamsung = new System.Windows.Forms.TextBox();
            this.txtsony = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "投票系統";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "總票數：";
            // 
            // txtamount
            // 
            this.txtamount.Enabled = false;
            this.txtamount.Location = new System.Drawing.Point(73, 26);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(126, 27);
            this.txtamount.TabIndex = 1;
            this.txtamount.Text = "0";
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "投票";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdsony);
            this.groupBox2.Controls.Add(this.rdsamsung);
            this.groupBox2.Controls.Add(this.rdhtc);
            this.groupBox2.Controls.Add(this.rdiphone);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(13, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "品牌票選";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsony);
            this.groupBox3.Controls.Add(this.txtsamsung);
            this.groupBox3.Controls.Add(this.txthtc);
            this.groupBox3.Controls.Add(this.txtiphone);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(219, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "目前票數";
            // 
            // rdiphone
            // 
            this.rdiphone.AutoSize = true;
            this.rdiphone.Location = new System.Drawing.Point(9, 42);
            this.rdiphone.Name = "rdiphone";
            this.rdiphone.Size = new System.Drawing.Size(70, 20);
            this.rdiphone.TabIndex = 0;
            this.rdiphone.TabStop = true;
            this.rdiphone.Text = "Iphone";
            this.rdiphone.UseVisualStyleBackColor = true;
            // 
            // rdhtc
            // 
            this.rdhtc.AutoSize = true;
            this.rdhtc.Location = new System.Drawing.Point(9, 81);
            this.rdhtc.Name = "rdhtc";
            this.rdhtc.Size = new System.Drawing.Size(56, 20);
            this.rdhtc.TabIndex = 1;
            this.rdhtc.TabStop = true;
            this.rdhtc.Text = "HTC";
            this.rdhtc.UseVisualStyleBackColor = true;
            // 
            // rdsamsung
            // 
            this.rdsamsung.AutoSize = true;
            this.rdsamsung.Location = new System.Drawing.Point(9, 121);
            this.rdsamsung.Name = "rdsamsung";
            this.rdsamsung.Size = new System.Drawing.Size(83, 20);
            this.rdsamsung.TabIndex = 2;
            this.rdsamsung.TabStop = true;
            this.rdsamsung.Text = "Samsung";
            this.rdsamsung.UseVisualStyleBackColor = true;
            // 
            // rdsony
            // 
            this.rdsony.AutoSize = true;
            this.rdsony.Location = new System.Drawing.Point(9, 160);
            this.rdsony.Name = "rdsony";
            this.rdsony.Size = new System.Drawing.Size(58, 20);
            this.rdsony.TabIndex = 3;
            this.rdsony.TabStop = true;
            this.rdsony.Text = "Sony";
            this.rdsony.UseVisualStyleBackColor = true;
            // 
            // txtiphone
            // 
            this.txtiphone.Enabled = false;
            this.txtiphone.Location = new System.Drawing.Point(6, 35);
            this.txtiphone.Name = "txtiphone";
            this.txtiphone.Size = new System.Drawing.Size(82, 27);
            this.txtiphone.TabIndex = 0;
            this.txtiphone.Text = "0";
            this.txtiphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthtc
            // 
            this.txthtc.Enabled = false;
            this.txthtc.Location = new System.Drawing.Point(6, 78);
            this.txthtc.Name = "txthtc";
            this.txthtc.Size = new System.Drawing.Size(82, 27);
            this.txthtc.TabIndex = 1;
            this.txthtc.Text = "0";
            this.txthtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsamsung
            // 
            this.txtsamsung.Enabled = false;
            this.txtsamsung.Location = new System.Drawing.Point(6, 118);
            this.txtsamsung.Name = "txtsamsung";
            this.txtsamsung.Size = new System.Drawing.Size(82, 27);
            this.txtsamsung.TabIndex = 2;
            this.txtsamsung.Text = "0";
            this.txtsamsung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsony
            // 
            this.txtsony.Enabled = false;
            this.txtsony.Location = new System.Drawing.Point(6, 160);
            this.txtsony.Name = "txtsony";
            this.txtsony.Size = new System.Drawing.Size(82, 27);
            this.txtsony.TabIndex = 3;
            this.txtsony.Text = "0";
            this.txtsony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 296);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "票選系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdsony;
        private System.Windows.Forms.RadioButton rdsamsung;
        private System.Windows.Forms.RadioButton rdhtc;
        private System.Windows.Forms.RadioButton rdiphone;
        private System.Windows.Forms.TextBox txtsony;
        private System.Windows.Forms.TextBox txtsamsung;
        private System.Windows.Forms.TextBox txthtc;
        private System.Windows.Forms.TextBox txtiphone;
    }
}

