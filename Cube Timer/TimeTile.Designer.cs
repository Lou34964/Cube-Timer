namespace Cube_Timer
{
    partial class TimeTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTime = new Label();
            pictureBox1 = new PictureBox();
            labelId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(116, 7);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(46, 15);
            labelTime.TabIndex = 0;
            labelTime.Text = "0:00  00";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(256, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(5, 7);
            labelId.Name = "labelId";
            labelId.Size = new Size(13, 15);
            labelId.TabIndex = 2;
            labelId.Text = "1";
            // 
            // TimeTile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(labelId);
            Controls.Add(pictureBox1);
            Controls.Add(labelTime);
            Name = "TimeTile";
            Size = new Size(285, 29);
            Load += TimeTile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private PictureBox pictureBox1;
        private Label labelId;
    }
}
