using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cube_Timer
{
    public partial class TimeTile : UserControl
    {
        private Form1 Mainfrm;
        private CTime cTime;
        private int Id = 0;
        public TimeTile(Form1 mainfrm, CTime time, int id)
        {
            InitializeComponent();
            Mainfrm = mainfrm;
            cTime = time;
            Id = id;

            labelTime.Text = cTime.ToString();
            labelId.Text = Id.ToString();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Program.DeletePng;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainfrm.RemoveTime(cTime);
            Mainfrm.UpdateListDisplay();
        }

        private void TimeTile_Load(object sender, EventArgs e)
        {
            labelTime.Text = cTime.ToString();
            labelId.Text = Id.ToString();
        }

        public CTime GetCTime() { return cTime; }
    }
}
