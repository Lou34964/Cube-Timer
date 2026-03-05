namespace Cube_Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanelTimes = new FlowLayoutPanel();
            panel2 = new Panel();
            labelTrimmed = new Label();
            labelWorst = new Label();
            labelBest = new Label();
            labelAvg = new Label();
            labelClearTimes = new Label();
            button1 = new Button();
            labelExportTimes = new Label();
            labelImportTimes = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTime);
            panel1.Location = new Point(63, 78);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 135);
            panel1.TabIndex = 0;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(291, 24);
            labelTime.Margin = new Padding(4, 0, 4, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(297, 86);
            labelTime.TabIndex = 0;
            labelTime.Text = "0:00  000";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            labelTime.Click += labelMinutes_Click;
            // 
            // timer1
            // 
            timer1.Interval = 33;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanelTimes
            // 
            flowLayoutPanelTimes.AutoScroll = true;
            flowLayoutPanelTimes.BackColor = Color.WhiteSmoke;
            flowLayoutPanelTimes.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanelTimes.Location = new Point(66, 223);
            flowLayoutPanelTimes.Name = "flowLayoutPanelTimes";
            flowLayoutPanelTimes.Size = new Size(302, 279);
            flowLayoutPanelTimes.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(labelTrimmed);
            panel2.Controls.Add(labelWorst);
            panel2.Controls.Add(labelBest);
            panel2.Controls.Add(labelAvg);
            panel2.Location = new Point(427, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 214);
            panel2.TabIndex = 2;
            // 
            // labelTrimmed
            // 
            labelTrimmed.AutoSize = true;
            labelTrimmed.Location = new Point(20, 94);
            labelTrimmed.Name = "labelTrimmed";
            labelTrimmed.Size = new Size(174, 21);
            labelTrimmed.TabIndex = 3;
            labelTrimmed.Text = "Trimmed Average Time:";
            // 
            // labelWorst
            // 
            labelWorst.AutoSize = true;
            labelWorst.Location = new Point(102, 68);
            labelWorst.Name = "labelWorst";
            labelWorst.Size = new Size(92, 21);
            labelWorst.TabIndex = 2;
            labelWorst.Text = "Worst Time:";
            // 
            // labelBest
            // 
            labelBest.AutoSize = true;
            labelBest.Location = new Point(114, 42);
            labelBest.Name = "labelBest";
            labelBest.Size = new Size(80, 21);
            labelBest.TabIndex = 1;
            labelBest.Text = "Best Time:";
            // 
            // labelAvg
            // 
            labelAvg.AutoSize = true;
            labelAvg.Location = new Point(86, 16);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(108, 21);
            labelAvg.TabIndex = 0;
            labelAvg.Text = "Average Time:";
            // 
            // labelClearTimes
            // 
            labelClearTimes.AutoSize = true;
            labelClearTimes.BackColor = Color.WhiteSmoke;
            labelClearTimes.BorderStyle = BorderStyle.FixedSingle;
            labelClearTimes.Location = new Point(66, 505);
            labelClearTimes.Name = "labelClearTimes";
            labelClearTimes.Size = new Size(93, 23);
            labelClearTimes.TabIndex = 3;
            labelClearTimes.Text = "Clear Times";
            labelClearTimes.Click += labelClearTimes_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(808, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 46);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelExportTimes
            // 
            labelExportTimes.AutoSize = true;
            labelExportTimes.BackColor = Color.WhiteSmoke;
            labelExportTimes.BorderStyle = BorderStyle.FixedSingle;
            labelExportTimes.Location = new Point(374, 478);
            labelExportTimes.Name = "labelExportTimes";
            labelExportTimes.Size = new Size(56, 23);
            labelExportTimes.TabIndex = 5;
            labelExportTimes.Text = "Export";
            labelExportTimes.Click += labelExportTimes_Click;
            // 
            // labelImportTimes
            // 
            labelImportTimes.AutoSize = true;
            labelImportTimes.BackColor = Color.WhiteSmoke;
            labelImportTimes.BorderStyle = BorderStyle.FixedSingle;
            labelImportTimes.Location = new Point(374, 505);
            labelImportTimes.Name = "labelImportTimes";
            labelImportTimes.Size = new Size(59, 23);
            labelImportTimes.TabIndex = 6;
            labelImportTimes.Text = "Import";
            labelImportTimes.Click += labelImportTimes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1015, 581);
            Controls.Add(labelImportTimes);
            Controls.Add(labelExportTimes);
            Controls.Add(button1);
            Controls.Add(labelClearTimes);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelTimes);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Timer";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label labelTime;
        private FlowLayoutPanel flowLayoutPanelTimes;
        private Panel panel2;
        private Label labelTrimmed;
        private Label labelWorst;
        private Label labelBest;
        private Label labelAvg;
        private Label labelClearTimes;
        private Button button1;
        private Label labelExportTimes;
        private Label labelImportTimes;
    }
}
