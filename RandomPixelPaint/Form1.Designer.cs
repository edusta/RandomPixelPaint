using System.Diagnostics;

namespace RandomPixelPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.topRightPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRightPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).BeginInit();
            this.SuspendLayout();

            int width = PixelPaintBox.bitmapWidth;
            int height = PixelPaintBox.bitmapHeight;

            // 
            // topLeftPictureBox
            // 
            this.topLeftPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topLeftPictureBox.Name = "topLeftPictureBox";
            this.topLeftPictureBox.Size = new System.Drawing.Size(width, height);
            this.topLeftPictureBox.TabIndex = 1;
            this.topLeftPictureBox.TabStop = false;
            // 
            // topRightPictureBox
            // 
            this.topRightPictureBox.Location = new System.Drawing.Point(width, 0);
            this.topRightPictureBox.Name = "topRightPictureBox";
            this.topRightPictureBox.Size = new System.Drawing.Size(width, height);
            this.topRightPictureBox.TabIndex = 2;
            this.topRightPictureBox.TabStop = false;
            // 
            // bottomLeftPictureBox
            // 
            this.bottomLeftPictureBox.Location = new System.Drawing.Point(0, height);
            this.bottomLeftPictureBox.Name = "bottomLeftPictureBox";
            this.bottomLeftPictureBox.Size = new System.Drawing.Size(width, height);
            this.bottomLeftPictureBox.TabIndex = 4;
            this.bottomLeftPictureBox.TabStop = false;
            // 
            // bottomRightPictureBox
            // 
            this.bottomRightPictureBox.Location = new System.Drawing.Point(width, height);
            this.bottomRightPictureBox.Name = "bottomRightPictureBox";
            this.bottomRightPictureBox.Size = new System.Drawing.Size(width, height);
            this.bottomRightPictureBox.TabIndex = 6;
            this.bottomRightPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(width * 2, height * 2);
            this.Controls.Add(this.bottomRightPictureBox);
            this.Controls.Add(this.bottomLeftPictureBox);
            this.Controls.Add(this.topRightPictureBox);
            this.Controls.Add(this.topLeftPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topLeftPictureBox;
        private System.Windows.Forms.PictureBox topRightPictureBox;
        private System.Windows.Forms.PictureBox bottomLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomRightPictureBox;
    }
}

