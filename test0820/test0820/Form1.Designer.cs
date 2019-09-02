namespace test0820
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
            this.components = new System.ComponentModel.Container();
            this.Capture_But = new System.Windows.Forms.Button();
            this.Capture_ImageBox = new Emgu.CV.UI.ImageBox();
            this.Gray_ImageBox = new Emgu.CV.UI.ImageBox();
            this.Binary_ImageBox = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Capture_ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gray_ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binary_ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Capture_But
            // 
            this.Capture_But.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Capture_But.Location = new System.Drawing.Point(31, 64);
            this.Capture_But.Name = "Capture_But";
            this.Capture_But.Size = new System.Drawing.Size(200, 48);
            this.Capture_But.TabIndex = 0;
            this.Capture_But.Text = "開啟鏡頭";
            this.Capture_But.UseVisualStyleBackColor = true;
            this.Capture_But.Click += new System.EventHandler(this.Capture_But_Click);
            // 
            // Capture_ImageBox
            // 
            this.Capture_ImageBox.Location = new System.Drawing.Point(12, 214);
            this.Capture_ImageBox.Name = "Capture_ImageBox";
            this.Capture_ImageBox.Size = new System.Drawing.Size(239, 208);
            this.Capture_ImageBox.TabIndex = 2;
            this.Capture_ImageBox.TabStop = false;
            // 
            // Gray_ImageBox
            // 
            this.Gray_ImageBox.Location = new System.Drawing.Point(287, 214);
            this.Gray_ImageBox.Name = "Gray_ImageBox";
            this.Gray_ImageBox.Size = new System.Drawing.Size(242, 208);
            this.Gray_ImageBox.TabIndex = 3;
            this.Gray_ImageBox.TabStop = false;
            // 
            // Binary_ImageBox
            // 
            this.Binary_ImageBox.Location = new System.Drawing.Point(563, 214);
            this.Binary_ImageBox.Name = "Binary_ImageBox";
            this.Binary_ImageBox.Size = new System.Drawing.Size(232, 208);
            this.Binary_ImageBox.TabIndex = 4;
            this.Binary_ImageBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(329, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "開啟路徑上的照片並且做一些功能";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Binary_ImageBox);
            this.Controls.Add(this.Gray_ImageBox);
            this.Controls.Add(this.Capture_ImageBox);
            this.Controls.Add(this.Capture_But);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Capture_ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gray_ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Binary_ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capture_But;
        private Emgu.CV.UI.ImageBox Capture_ImageBox;
        private Emgu.CV.UI.ImageBox Gray_ImageBox;
        private Emgu.CV.UI.ImageBox Binary_ImageBox;
        private System.Windows.Forms.Button button1;
    }
}

