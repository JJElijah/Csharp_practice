namespace 數學及亂數功能展示
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
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.btramdom1 = new System.Windows.Forms.Button();
            this.btramdom2 = new System.Windows.Forms.Button();
            this.btramdom3 = new System.Windows.Forms.Button();
            this.btsin = new System.Windows.Forms.Button();
            this.btcos = new System.Windows.Forms.Button();
            this.bttan = new System.Windows.Forms.Button();
            this.btclean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoutput
            // 
            this.txtoutput.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtoutput.Location = new System.Drawing.Point(13, 13);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtoutput.Size = new System.Drawing.Size(253, 108);
            this.txtoutput.TabIndex = 0;
            this.txtoutput.WordWrap = false;
            // 
            // btramdom1
            // 
            this.btramdom1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btramdom1.Location = new System.Drawing.Point(13, 132);
            this.btramdom1.Name = "btramdom1";
            this.btramdom1.Size = new System.Drawing.Size(75, 37);
            this.btramdom1.TabIndex = 1;
            this.btramdom1.Text = "亂數1~50";
            this.btramdom1.UseVisualStyleBackColor = true;
            this.btramdom1.Click += new System.EventHandler(this.btramdom1_Click);
            // 
            // btramdom2
            // 
            this.btramdom2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btramdom2.Location = new System.Drawing.Point(101, 132);
            this.btramdom2.Name = "btramdom2";
            this.btramdom2.Size = new System.Drawing.Size(75, 37);
            this.btramdom2.TabIndex = 2;
            this.btramdom2.Text = "亂數50~100";
            this.btramdom2.UseVisualStyleBackColor = true;
            this.btramdom2.Click += new System.EventHandler(this.btramdom2_Click);
            // 
            // btramdom3
            // 
            this.btramdom3.Location = new System.Drawing.Point(191, 132);
            this.btramdom3.Name = "btramdom3";
            this.btramdom3.Size = new System.Drawing.Size(75, 37);
            this.btramdom3.TabIndex = 3;
            this.btramdom3.Text = "亂數100~150";
            this.btramdom3.UseVisualStyleBackColor = true;
            this.btramdom3.Click += new System.EventHandler(this.btramdom3_Click);
            // 
            // btsin
            // 
            this.btsin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btsin.Location = new System.Drawing.Point(13, 187);
            this.btsin.Name = "btsin";
            this.btsin.Size = new System.Drawing.Size(75, 67);
            this.btsin.TabIndex = 4;
            this.btsin.Text = "正弦(0.5)";
            this.btsin.UseVisualStyleBackColor = true;
            this.btsin.Click += new System.EventHandler(this.btsin_Click);
            // 
            // btcos
            // 
            this.btcos.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btcos.Location = new System.Drawing.Point(101, 187);
            this.btcos.Name = "btcos";
            this.btcos.Size = new System.Drawing.Size(75, 67);
            this.btcos.TabIndex = 5;
            this.btcos.Text = "餘弦(0.5)";
            this.btcos.UseVisualStyleBackColor = true;
            this.btcos.Click += new System.EventHandler(this.btcos_Click);
            // 
            // bttan
            // 
            this.bttan.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bttan.Location = new System.Drawing.Point(191, 187);
            this.bttan.Name = "bttan";
            this.bttan.Size = new System.Drawing.Size(75, 67);
            this.bttan.TabIndex = 6;
            this.bttan.Text = "正割(0.5)";
            this.bttan.UseVisualStyleBackColor = true;
            this.bttan.Click += new System.EventHandler(this.bttan_Click);
            // 
            // btclean
            // 
            this.btclean.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btclean.Location = new System.Drawing.Point(13, 269);
            this.btclean.Name = "btclean";
            this.btclean.Size = new System.Drawing.Size(253, 45);
            this.btclean.TabIndex = 7;
            this.btclean.Text = "Clean";
            this.btclean.UseVisualStyleBackColor = true;
            this.btclean.Click += new System.EventHandler(this.btclean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 331);
            this.Controls.Add(this.btclean);
            this.Controls.Add(this.bttan);
            this.Controls.Add(this.btcos);
            this.Controls.Add(this.btsin);
            this.Controls.Add(this.btramdom3);
            this.Controls.Add(this.btramdom2);
            this.Controls.Add(this.btramdom1);
            this.Controls.Add(this.txtoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button btramdom1;
        private System.Windows.Forms.Button btramdom2;
        private System.Windows.Forms.Button btramdom3;
        private System.Windows.Forms.Button btsin;
        private System.Windows.Forms.Button btcos;
        private System.Windows.Forms.Button bttan;
        private System.Windows.Forms.Button btclean;
    }
}

