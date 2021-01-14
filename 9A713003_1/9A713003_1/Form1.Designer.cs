namespace Final_report_9A713008
{
    partial class FM1
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
            this.buton1 = new System.Windows.Forms.Button();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // buton1
            // 
            this.buton1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buton1.Location = new System.Drawing.Point(12, 162);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(173, 74);
            this.buton1.TabIndex = 0;
            this.buton1.Text = "抽";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(268, 28);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(428, 237);
            this.picture1.TabIndex = 2;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(38, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 50);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "你要吃";
            this.Label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // FM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.buton1);
            this.Name = "FM1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label Label1;
    }
}

