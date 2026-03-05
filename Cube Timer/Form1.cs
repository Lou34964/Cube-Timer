using System.Diagnostics;
using System.Linq;

namespace Cube_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = button1;
            button1.Select();
        }

        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 33 };

        private CTime _time = new CTime();

        private bool TimerRunning = false;

        private List<CTime> Times = new List<CTime>();

        private CTime min, max, average, t_average;

        private void labelMinutes_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("./Assets/Times.txt"))
            {
                using (StreamReader sr = new StreamReader("./Assets/Times.txt"))
                {
                    string? line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Times.Add(CTime.FromMilliseconds(int.Parse(line)));
                    }
                }

                UpdateListDisplay();
                CalcOps();
                UpdateOpsDisplay();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var t = stopwatch.Elapsed;
            labelTime.Text = Format(t);
        }

        private string Format(TimeSpan t)
            => $"{(int)t.TotalMinutes}:{t.Seconds:D2}  {t.Milliseconds:D3}";

        private void ResetTimer()
        {
            //set minutes, seconds and milliseconds to 0
            _time = new CTime();

            //print timers
            labelTime.Text = _time.ToString();
        }

        private void CalcOps()
        {
            if (Times == null || Times.Count == 0)
                return;

            min = Times.OrderBy(t => t.GetValue()).First();
            max = Times.OrderByDescending(t => t.GetValue()).First();


            int avgVal = (int)Times.Average(t => t.GetValue());
            average = CTime.FromMilliseconds(avgVal);

            if (Times.Count > 2)
            {
                var trimmed = Times.OrderBy(t => t.GetValue()).ToList();
                trimmed.RemoveAt(0);
                trimmed.RemoveAt(trimmed.Count - 1);

                int tAvgVal = (int)trimmed.Average(t => t.GetValue());
                t_average = CTime.FromMilliseconds(tAvgVal);
            }
            else
            {
                t_average = average;
            }
        }

        public void UpdateListDisplay()
        {
            flowLayoutPanelTimes.Controls.Clear();

            for (int i = 0; i < Times.Count; i++)
            {
                flowLayoutPanelTimes.Controls.Add(new TimeTile(this, Times[i], i + 1));
            }

            try
            {
                min = Times.OrderBy(t => t.GetValue()).First();
                max = Times.OrderByDescending(t => t.GetValue()).First();

                if (flowLayoutPanelTimes.Controls.Count > 2)
                {
                    TimeTile tmin = flowLayoutPanelTimes.Controls.OfType<TimeTile>().FirstOrDefault(t => t.GetCTime() == min);
                    if (tmin != null)
                        tmin.BackColor = Color.DarkSeaGreen;

                    TimeTile tmax = flowLayoutPanelTimes.Controls.OfType<TimeTile>().FirstOrDefault(t => t.GetCTime() == max);
                    if (tmax != null)
                        tmax.BackColor = Color.RosyBrown;
                }
            }
            catch
            {

            }
        }

        public void RemoveTime(CTime time)
        {
            Times.Remove(time);
            CalcOps();
            UpdateOpsDisplay();
        }

        public void UpdateOpsDisplay()
        {
            if (Times.Count == 0) return;
            //update ops display
            labelAvg.Text = $"Average Time: {average.ToString()}";
            labelBest.Text = $"Best Time: {min.ToString()}";
            labelWorst.Text = $"Worst Time: {max.ToString()}";
            labelTrimmed.Text = $"Trimmed Average Time: {t_average.ToString()}";
        }

        private void labelClearTimes_Click(object sender, EventArgs e)
        {
            Times.Clear();
            CalcOps();
            UpdateOpsDisplay();
            UpdateListDisplay();
            if (File.Exists("./Assets/Times.txt"))
            {
                File.Delete("./Assets/Times.txt");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if timer is running (stop)
            if (TimerRunning)
            {
                //stop the timer
                stopwatch.Stop();
                timer1.Stop();

                TimerRunning = false;

                //read the time data and save to list
                var t = stopwatch.Elapsed;
                int m = (int)t.TotalMinutes;
                int s = int.Parse(t.Seconds.ToString());
                int ms = int.Parse(t.Milliseconds.ToString());
                Times.Add(new CTime(m, s, ms));

                //update time
                labelTime.Text = Format(t);

                //update list display
                UpdateListDisplay();

                //recalculate min, max, average and trimmed average.
                CalcOps();

                //update ops display
                UpdateOpsDisplay();

                button1.Text = "Start";
                button1.BackColor = Color.DarkSeaGreen;

                //save times.
                SaveTimes();
            }
            else  // (start)
            {
                //reset timer
                ResetTimer();

                //start timer
                stopwatch.Restart();
                timer1.Start();

                TimerRunning = true;

                button1.Text = "Stop";
                button1.BackColor = Color.RosyBrown;
            }


        }

        public void SaveTimes()
        {
            List<string> _times = new List<string>();
            foreach (CTime t in Times)
            {
                _times.Add(t.GetValue().ToString());
            }


            File.WriteAllLines("./Assets/Times.txt", _times.ToArray());
        }

        private void labelExportTimes_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Export Times";
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;

                string timestamp = DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
                sfd.FileName = $"Cube Times - {timestamp}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, Times.Select(t => t.GetValue().ToString()));

                    string argument = $"/select,\"{sfd.FileName}\"";
                    System.Diagnostics.Process.Start("explorer.exe", argument);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelImportTimes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Importing will overwrite your current times. Export first if you want to keep them.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Import Times";
                    ofd.Filter = "Text Files (*.txt)|*.txt";
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var lines = File.ReadAllLines(ofd.FileName);

                            Times.Clear();

                            foreach (var line in lines)
                            {
                                if (int.TryParse(line, out int ms))
                                {
                                    Times.Add(CTime.FromMilliseconds(ms));
                                }
                                else
                                {
                                    Console.WriteLine($"Skipped invalid line: {line}");
                                }
                            }

                            UpdateListDisplay();
                            CalcOps();
                            UpdateOpsDisplay();

                            MessageBox.Show("Times imported successfully.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to import times:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
