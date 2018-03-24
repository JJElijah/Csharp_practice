namespace 字串搜尋及取代
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.btreplace = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜尋字串：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "取代字串：";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsearch.Location = new System.Drawing.Point(96, 17);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 23);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.Text = "永生";
            // 
            // txtreplace
            // 
            this.txtreplace.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtreplace.Location = new System.Drawing.Point(96, 52);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(100, 23);
            this.txtreplace.TabIndex = 3;
            this.txtreplace.Text = "復活";
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(202, 16);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(86, 23);
            this.btsearch.TabIndex = 4;
            this.btsearch.Text = "搜尋";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btreplace
            // 
            this.btreplace.Location = new System.Drawing.Point(202, 52);
            this.btreplace.Name = "btreplace";
            this.btreplace.Size = new System.Drawing.Size(86, 22);
            this.btreplace.TabIndex = 5;
            this.btreplace.Text = "取代";
            this.btreplace.UseVisualStyleBackColor = true;
            this.btreplace.Click += new System.EventHandler(this.btreplace_Click);
            // 
            // txtinput
            // 
            this.txtinput.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtinput.Location = new System.Drawing.Point(13, 90);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(275, 133);
            this.txtinput.TabIndex = 6;
            this.txtinput.Text = "神愛世人，甚至將他的獨生子賜給他們，叫一切信他的，不致滅亡，反得永生。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 235);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btreplace);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btreplace;
        private System.Windows.Forms.TextBox txtinput;
    }
}

