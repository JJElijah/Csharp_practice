namespace 字串處理
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.btlength = new System.Windows.Forms.Button();
            this.btlower = new System.Windows.Forms.Button();
            this.btupper = new System.Windows.Forms.Button();
            this.btfirstword = new System.Windows.Forms.Button();
            this.chktrim = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.rb_pen = new System.Windows.Forms.RadioButton();
            this.rb_hello = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入字串：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "輸出字串：";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(110, 17);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(144, 22);
            this.txtinput.TabIndex = 2;
            this.txtinput.TextChanged += new System.EventHandler(this.txtinput_TextChanged);
            // 
            // txtoutput
            // 
            this.txtoutput.Enabled = false;
            this.txtoutput.Location = new System.Drawing.Point(110, 51);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(144, 22);
            this.txtoutput.TabIndex = 3;
            // 
            // btlength
            // 
            this.btlength.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btlength.Location = new System.Drawing.Point(260, 16);
            this.btlength.Name = "btlength";
            this.btlength.Size = new System.Drawing.Size(83, 57);
            this.btlength.TabIndex = 4;
            this.btlength.Text = "長度";
            this.btlength.UseVisualStyleBackColor = true;
            this.btlength.Click += new System.EventHandler(this.btlength_Click);
            // 
            // btlower
            // 
            this.btlower.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btlower.Location = new System.Drawing.Point(260, 81);
            this.btlower.Name = "btlower";
            this.btlower.Size = new System.Drawing.Size(83, 56);
            this.btlower.TabIndex = 5;
            this.btlower.Text = "小寫";
            this.btlower.UseVisualStyleBackColor = true;
            this.btlower.Click += new System.EventHandler(this.btlower_Click);
            // 
            // btupper
            // 
            this.btupper.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btupper.Location = new System.Drawing.Point(260, 145);
            this.btupper.Name = "btupper";
            this.btupper.Size = new System.Drawing.Size(83, 56);
            this.btupper.TabIndex = 6;
            this.btupper.Text = "大寫";
            this.btupper.UseVisualStyleBackColor = true;
            this.btupper.Click += new System.EventHandler(this.btupper_Click);
            // 
            // btfirstword
            // 
            this.btfirstword.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btfirstword.Location = new System.Drawing.Point(260, 210);
            this.btfirstword.Name = "btfirstword";
            this.btfirstword.Size = new System.Drawing.Size(83, 56);
            this.btfirstword.TabIndex = 7;
            this.btfirstword.Text = "字首";
            this.btfirstword.UseVisualStyleBackColor = true;
            this.btfirstword.Click += new System.EventHandler(this.btfirstword_Click);
            // 
            // chktrim
            // 
            this.chktrim.AutoSize = true;
            this.chktrim.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chktrim.Location = new System.Drawing.Point(13, 96);
            this.chktrim.Name = "chktrim";
            this.chktrim.Size = new System.Drawing.Size(123, 20);
            this.chktrim.TabIndex = 8;
            this.chktrim.Text = "刪除空白字元";
            this.chktrim.UseVisualStyleBackColor = true;
            this.chktrim.CheckedChanged += new System.EventHandler(this.chktrim_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_name);
            this.groupBox1.Controls.Add(this.rb_pen);
            this.groupBox1.Controls.Add(this.rb_hello);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "罐頭訊息";
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Location = new System.Drawing.Point(7, 97);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(115, 20);
            this.rb_name.TabIndex = 2;
            this.rb_name.TabStop = true;
            this.rb_name.Text = "My name is JJ";
            this.rb_name.UseVisualStyleBackColor = true;
            this.rb_name.CheckedChanged += new System.EventHandler(this.rb_name_CheckedChanged);
            // 
            // rb_pen
            // 
            this.rb_pen.AutoSize = true;
            this.rb_pen.Location = new System.Drawing.Point(7, 59);
            this.rb_pen.Name = "rb_pen";
            this.rb_pen.Size = new System.Drawing.Size(100, 20);
            this.rb_pen.TabIndex = 1;
            this.rb_pen.TabStop = true;
            this.rb_pen.Text = "this is a pen";
            this.rb_pen.UseVisualStyleBackColor = true;
            this.rb_pen.CheckedChanged += new System.EventHandler(this.rb_pen_CheckedChanged);
            // 
            // rb_hello
            // 
            this.rb_hello.AutoSize = true;
            this.rb_hello.Location = new System.Drawing.Point(7, 23);
            this.rb_hello.Name = "rb_hello";
            this.rb_hello.Size = new System.Drawing.Size(134, 20);
            this.rb_hello.TabIndex = 0;
            this.rb_hello.TabStop = true;
            this.rb_hello.Text = "HELLO WORLD";
            this.rb_hello.UseVisualStyleBackColor = true;
            this.rb_hello.CheckedChanged += new System.EventHandler(this.rb_hello_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chktrim);
            this.Controls.Add(this.btfirstword);
            this.Controls.Add(this.btupper);
            this.Controls.Add(this.btlower);
            this.Controls.Add(this.btlength);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "字串處理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button btlength;
        private System.Windows.Forms.Button btlower;
        private System.Windows.Forms.Button btupper;
        private System.Windows.Forms.Button btfirstword;
        private System.Windows.Forms.CheckBox chktrim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.RadioButton rb_pen;
        private System.Windows.Forms.RadioButton rb_hello;
    }
}

