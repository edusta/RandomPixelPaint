using System.Diagnostics;
using System.Windows.Forms;

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
            this.topMidPictureBox = new System.Windows.Forms.PictureBox();
            this.midLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.midMidPictureBox = new System.Windows.Forms.PictureBox();
            this.topRightPictureBox = new System.Windows.Forms.PictureBox();
            this.midRightPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRightPictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomMidPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMidPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midMidPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMidPictureBox)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            
            int margin = 1;
            Padding pictureBoxMargin = new Padding(margin);
            int width = PixelPaintBox.bitmapWidth;
            int height = PixelPaintBox.bitmapHeight;
            // 
            // topLeftPictureBox
            // 
            this.topLeftPictureBox.Location = new System.Drawing.Point(margin, margin);
            this.topLeftPictureBox.Name = "topLeftPictureBox";
            this.topLeftPictureBox.Size = new System.Drawing.Size(width, height);
            this.topLeftPictureBox.TabIndex = 1;
            this.topLeftPictureBox.TabStop = false;
            this.topLeftPictureBox.Margin = pictureBoxMargin;
            // 
            // topMidPictureBox
            // 
            this.topMidPictureBox.Location = new System.Drawing.Point(width + margin, margin);
            this.topMidPictureBox.Name = "topMidPictureBox";
            this.topMidPictureBox.Size = new System.Drawing.Size(width, height);
            this.topMidPictureBox.TabIndex = 2;
            this.topMidPictureBox.TabStop = false;
            this.topMidPictureBox.Margin = pictureBoxMargin;
            // 
            // topRightPictureBox
            // 
            this.topRightPictureBox.Location = new System.Drawing.Point((width + margin) * 2, margin);
            this.topRightPictureBox.Name = "topRightPictureBox";
            this.topRightPictureBox.Size = new System.Drawing.Size(width, height);
            this.topRightPictureBox.TabIndex = 7;
            this.topRightPictureBox.TabStop = false;
            this.topRightPictureBox.Margin = pictureBoxMargin;
            // 
            // midLeftPictureBox
            // 
            this.midLeftPictureBox.Location = new System.Drawing.Point(margin, height + margin);
            this.midLeftPictureBox.Name = "midLeftPictureBox";
            this.midLeftPictureBox.Size = new System.Drawing.Size(width, height);
            this.midLeftPictureBox.TabIndex = 4;
            this.midLeftPictureBox.TabStop = false;
            this.midLeftPictureBox.Margin = pictureBoxMargin;
            // 
            // midMidPictureBox
            // 
            this.midMidPictureBox.Location = new System.Drawing.Point(width + margin, height + margin);
            this.midMidPictureBox.Name = "midMidPictureBox";
            this.midMidPictureBox.Size = new System.Drawing.Size(width, height);
            this.midMidPictureBox.TabIndex = 6;
            this.midMidPictureBox.TabStop = false;
            this.midMidPictureBox.Margin = pictureBoxMargin;
            // 
            // midRightPictureBox
            // 
            this.midRightPictureBox.Location = new System.Drawing.Point((width + margin) * 2, height + margin);
            this.midRightPictureBox.Name = "midRightPictureBox";
            this.midRightPictureBox.Size = new System.Drawing.Size(width, height);
            this.midRightPictureBox.TabIndex = 8;
            this.midRightPictureBox.TabStop = false;
            this.midRightPictureBox.Margin = pictureBoxMargin;
            // 
            // bottomLeftPictureBox
            // 
            this.bottomLeftPictureBox.Location = new System.Drawing.Point(margin, (height + margin) * 2);
            this.bottomLeftPictureBox.Name = "bottomLeftPictureBox";
            this.bottomLeftPictureBox.Size = new System.Drawing.Size(width, height);
            this.bottomLeftPictureBox.TabIndex = 10;
            this.bottomLeftPictureBox.TabStop = false;
            this.bottomLeftPictureBox.Margin = pictureBoxMargin;
            // 
            // bottomMidPictureBox
            // 
            this.bottomMidPictureBox.Location = new System.Drawing.Point(width + margin, (height + margin) * 2);
            this.bottomMidPictureBox.Name = "bottomMidPictureBox";
            this.bottomMidPictureBox.Size = new System.Drawing.Size(width, height);
            this.bottomMidPictureBox.TabIndex = 11;
            this.bottomMidPictureBox.TabStop = false;
            this.bottomMidPictureBox.Margin = pictureBoxMargin;
            // 
            // bottomRightPictureBox
            // 
            this.bottomRightPictureBox.Location = new System.Drawing.Point((width + margin) * 2, (height + margin) * 2);
            this.bottomRightPictureBox.Name = "bottomRightPictureBox";
            this.bottomRightPictureBox.Size = new System.Drawing.Size(width, height);
            this.bottomRightPictureBox.TabIndex = 9;
            this.bottomRightPictureBox.TabStop = false;
            this.bottomRightPictureBox.Margin = pictureBoxMargin;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.topLeftPictureBox);
            this.flowLayoutPanel.Controls.Add(this.topMidPictureBox);
            this.flowLayoutPanel.Controls.Add(this.topRightPictureBox);
            this.flowLayoutPanel.Controls.Add(this.midLeftPictureBox);
            this.flowLayoutPanel.Controls.Add(this.midMidPictureBox);
            this.flowLayoutPanel.Controls.Add(this.midRightPictureBox);
            this.flowLayoutPanel.Controls.Add(this.bottomLeftPictureBox);
            this.flowLayoutPanel.Controls.Add(this.bottomMidPictureBox);
            this.flowLayoutPanel.Controls.Add(this.bottomRightPictureBox);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(width * 3 + margin * 6, height * 3 + margin * 6);
            this.flowLayoutPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(width * 3 + margin * 6, height * 3 + margin * 6);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMidPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midMidPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMidPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox topLeftPictureBox;
        private System.Windows.Forms.PictureBox topMidPictureBox;
        private System.Windows.Forms.PictureBox midLeftPictureBox;
        private System.Windows.Forms.PictureBox midMidPictureBox;
        private System.Windows.Forms.PictureBox topRightPictureBox;
        private System.Windows.Forms.PictureBox midRightPictureBox;
        private System.Windows.Forms.PictureBox bottomRightPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox bottomLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomMidPictureBox;
    }
}

