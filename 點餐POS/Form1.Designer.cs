namespace 點餐POS
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
            this.chkbeef = new System.Windows.Forms.CheckBox();
            this.chkchicken = new System.Windows.Forms.CheckBox();
            this.chkspizza = new System.Windows.Forms.CheckBox();
            this.chkbpizza = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkfries = new System.Windows.Forms.CheckBox();
            this.rbsmallfries = new System.Windows.Forms.RadioButton();
            this.rbbigfries = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkdrink = new System.Windows.Forms.CheckBox();
            this.rbcola = new System.Windows.Forms.RadioButton();
            this.rbcoffee = new System.Windows.Forms.RadioButton();
            this.rbblacktea = new System.Windows.Forms.RadioButton();
            this.btcalm = new System.Windows.Forms.Button();
            this.lbprice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbpizza);
            this.groupBox1.Controls.Add(this.chkspizza);
            this.groupBox1.Controls.Add(this.chkchicken);
            this.groupBox1.Controls.Add(this.chkbeef);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "漢堡/披薩";
            // 
            // chkbeef
            // 
            this.chkbeef.AutoSize = true;
            this.chkbeef.Location = new System.Drawing.Point(7, 27);
            this.chkbeef.Name = "chkbeef";
            this.chkbeef.Size = new System.Drawing.Size(119, 20);
            this.chkbeef.TabIndex = 0;
            this.chkbeef.Text = "牛肉漢堡 $75";
            this.chkbeef.UseVisualStyleBackColor = true;
            // 
            // chkchicken
            // 
            this.chkchicken.AutoSize = true;
            this.chkchicken.Location = new System.Drawing.Point(7, 54);
            this.chkchicken.Name = "chkchicken";
            this.chkchicken.Size = new System.Drawing.Size(103, 20);
            this.chkchicken.TabIndex = 1;
            this.chkchicken.Text = "雞腿堡 $70";
            this.chkchicken.UseVisualStyleBackColor = true;
            // 
            // chkspizza
            // 
            this.chkspizza.AutoSize = true;
            this.chkspizza.Location = new System.Drawing.Point(7, 81);
            this.chkspizza.Name = "chkspizza";
            this.chkspizza.Size = new System.Drawing.Size(111, 20);
            this.chkspizza.TabIndex = 2;
            this.chkspizza.Text = "小披薩 $250";
            this.chkspizza.UseVisualStyleBackColor = true;
            // 
            // chkbpizza
            // 
            this.chkbpizza.AutoSize = true;
            this.chkbpizza.Location = new System.Drawing.Point(7, 108);
            this.chkbpizza.Name = "chkbpizza";
            this.chkbpizza.Size = new System.Drawing.Size(111, 20);
            this.chkbpizza.TabIndex = 3;
            this.chkbpizza.Text = "大披薩 $499";
            this.chkbpizza.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbbigfries);
            this.groupBox2.Controls.Add(this.rbsmallfries);
            this.groupBox2.Controls.Add(this.chkfries);
            this.groupBox2.Location = new System.Drawing.Point(176, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chkfries
            // 
            this.chkfries.AutoSize = true;
            this.chkfries.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkfries.Location = new System.Drawing.Point(12, -2);
            this.chkfries.Name = "chkfries";
            this.chkfries.Size = new System.Drawing.Size(59, 20);
            this.chkfries.TabIndex = 0;
            this.chkfries.Text = "薯條";
            this.chkfries.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chkfries.UseVisualStyleBackColor = true;
            this.chkfries.CheckedChanged += new System.EventHandler(this.chkfries_CheckedChanged);
            // 
            // rbsmallfries
            // 
            this.rbsmallfries.AutoSize = true;
            this.rbsmallfries.Enabled = false;
            this.rbsmallfries.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbsmallfries.Location = new System.Drawing.Point(14, 29);
            this.rbsmallfries.Name = "rbsmallfries";
            this.rbsmallfries.Size = new System.Drawing.Size(86, 20);
            this.rbsmallfries.TabIndex = 1;
            this.rbsmallfries.TabStop = true;
            this.rbsmallfries.Text = "小薯 $25";
            this.rbsmallfries.UseVisualStyleBackColor = true;
            // 
            // rbbigfries
            // 
            this.rbbigfries.AutoSize = true;
            this.rbbigfries.Enabled = false;
            this.rbbigfries.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbbigfries.Location = new System.Drawing.Point(14, 56);
            this.rbbigfries.Name = "rbbigfries";
            this.rbbigfries.Size = new System.Drawing.Size(90, 20);
            this.rbbigfries.TabIndex = 2;
            this.rbbigfries.TabStop = true;
            this.rbbigfries.Text = "大薯 $ 35";
            this.rbbigfries.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbblacktea);
            this.groupBox3.Controls.Add(this.rbcoffee);
            this.groupBox3.Controls.Add(this.rbcola);
            this.groupBox3.Controls.Add(this.chkdrink);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(176, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // chkdrink
            // 
            this.chkdrink.AutoSize = true;
            this.chkdrink.Location = new System.Drawing.Point(14, 0);
            this.chkdrink.Name = "chkdrink";
            this.chkdrink.Size = new System.Drawing.Size(87, 20);
            this.chkdrink.TabIndex = 0;
            this.chkdrink.Text = "飲料 $30";
            this.chkdrink.UseVisualStyleBackColor = true;
            this.chkdrink.CheckedChanged += new System.EventHandler(this.chkdrink_CheckedChanged);
            // 
            // rbcola
            // 
            this.rbcola.AutoSize = true;
            this.rbcola.Enabled = false;
            this.rbcola.Location = new System.Drawing.Point(12, 27);
            this.rbcola.Name = "rbcola";
            this.rbcola.Size = new System.Drawing.Size(58, 20);
            this.rbcola.TabIndex = 1;
            this.rbcola.TabStop = true;
            this.rbcola.Text = "可樂";
            this.rbcola.UseVisualStyleBackColor = true;
            // 
            // rbcoffee
            // 
            this.rbcoffee.AutoSize = true;
            this.rbcoffee.Enabled = false;
            this.rbcoffee.Location = new System.Drawing.Point(12, 53);
            this.rbcoffee.Name = "rbcoffee";
            this.rbcoffee.Size = new System.Drawing.Size(78, 20);
            this.rbcoffee.TabIndex = 2;
            this.rbcoffee.TabStop = true;
            this.rbcoffee.Text = "咖啡 +5";
            this.rbcoffee.UseVisualStyleBackColor = true;
            // 
            // rbblacktea
            // 
            this.rbblacktea.AutoSize = true;
            this.rbblacktea.Enabled = false;
            this.rbblacktea.Location = new System.Drawing.Point(12, 80);
            this.rbblacktea.Name = "rbblacktea";
            this.rbblacktea.Size = new System.Drawing.Size(58, 20);
            this.rbblacktea.TabIndex = 3;
            this.rbblacktea.TabStop = true;
            this.rbblacktea.Text = "紅茶";
            this.rbblacktea.UseVisualStyleBackColor = true;
            // 
            // btcalm
            // 
            this.btcalm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btcalm.Location = new System.Drawing.Point(12, 163);
            this.btcalm.Name = "btcalm";
            this.btcalm.Size = new System.Drawing.Size(145, 72);
            this.btcalm.TabIndex = 3;
            this.btcalm.Text = "計算";
            this.btcalm.UseVisualStyleBackColor = true;
            this.btcalm.Click += new System.EventHandler(this.btcalm_Click);
            // 
            // lbprice
            // 
            this.lbprice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbprice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbprice.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbprice.Location = new System.Drawing.Point(12, 245);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(320, 37);
            this.lbprice.TabIndex = 4;
            this.lbprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 318);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.btcalm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "點餐POS機";
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
        private System.Windows.Forms.CheckBox chkbpizza;
        private System.Windows.Forms.CheckBox chkspizza;
        private System.Windows.Forms.CheckBox chkchicken;
        private System.Windows.Forms.CheckBox chkbeef;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbbigfries;
        private System.Windows.Forms.RadioButton rbsmallfries;
        private System.Windows.Forms.CheckBox chkfries;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbblacktea;
        private System.Windows.Forms.RadioButton rbcoffee;
        private System.Windows.Forms.RadioButton rbcola;
        private System.Windows.Forms.CheckBox chkdrink;
        private System.Windows.Forms.Button btcalm;
        private System.Windows.Forms.Label lbprice;
    }
}

