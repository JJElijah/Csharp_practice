namespace Bubblesort
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtshow1 = new System.Windows.Forms.TextBox();
            this.txtshow2 = new System.Windows.Forms.TextBox();
            this.txtshow3 = new System.Windows.Forms.TextBox();
            this.txtshow4 = new System.Windows.Forms.TextBox();
            this.txtshow5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(27, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(62, 27);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(27, 70);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(62, 27);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(27, 103);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(62, 27);
            this.txt3.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(27, 136);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(62, 27);
            this.txt4.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(27, 169);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(62, 27);
            this.txt5.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtshow5);
            this.groupBox1.Controls.Add(this.txtshow4);
            this.groupBox1.Controls.Add(this.txtshow3);
            this.groupBox1.Controls.Add(this.txtshow2);
            this.groupBox1.Controls.Add(this.txtshow1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "氣泡排序";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 159);
            this.button1.TabIndex = 5;
            this.button1.Text = "排序";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtshow1
            // 
            this.txtshow1.Location = new System.Drawing.Point(207, 37);
            this.txtshow1.Name = "txtshow1";
            this.txtshow1.Size = new System.Drawing.Size(62, 27);
            this.txtshow1.TabIndex = 6;
            // 
            // txtshow2
            // 
            this.txtshow2.Location = new System.Drawing.Point(207, 71);
            this.txtshow2.Name = "txtshow2";
            this.txtshow2.Size = new System.Drawing.Size(62, 27);
            this.txtshow2.TabIndex = 7;
            // 
            // txtshow3
            // 
            this.txtshow3.Location = new System.Drawing.Point(207, 105);
            this.txtshow3.Name = "txtshow3";
            this.txtshow3.Size = new System.Drawing.Size(62, 27);
            this.txtshow3.TabIndex = 8;
            // 
            // txtshow4
            // 
            this.txtshow4.Location = new System.Drawing.Point(207, 139);
            this.txtshow4.Name = "txtshow4";
            this.txtshow4.Size = new System.Drawing.Size(62, 27);
            this.txtshow4.TabIndex = 9;
            // 
            // txtshow5
            // 
            this.txtshow5.Location = new System.Drawing.Point(207, 173);
            this.txtshow5.Name = "txtshow5";
            this.txtshow5.Size = new System.Drawing.Size(62, 27);
            this.txtshow5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 239);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bubblesort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtshow5;
        private System.Windows.Forms.TextBox txtshow4;
        private System.Windows.Forms.TextBox txtshow3;
        private System.Windows.Forms.TextBox txtshow2;
        private System.Windows.Forms.TextBox txtshow1;
        private System.Windows.Forms.Button button1;
    }
}

