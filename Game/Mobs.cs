using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Mobs
    {
        public List<PictureBox> BoxMob = new List<PictureBox>();
        public List<Label> LabelMob = new List<Label>();
        public int x { get; set; }
        public int y { get; set; }
        public double HP { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public void DrawP()
        {
            PictureBox PL = new PictureBox()
            {
                Location = new Point(x, y),
                Size = new Size(32, 32),
                Image = Properties.Resources.Ghost,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            BoxMob.Add(PL);
            Label lb = new Label()
            {
                Location = new Point(700, 10),
                Size = new Size(65, 30),
                Text = "10",
                BackColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe Print", 15, FontStyle.Bold),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };
            Label fs = new Label()
            {
                Location = new Point(700, 50),
                Size = new Size(65, 30),
                Text = "1",
                BackColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe Print", 15, FontStyle.Bold),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };
            LabelMob.Add(lb);
            LabelMob.Add(fs);
        }
        public void DrawB()
        {
            PictureBox PL = new PictureBox()
            {
                Location = new Point(x, y),
                Size = new Size(48, 48),
                Image = Properties.Resources.Bear,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            BoxMob.Add(PL);
        }
        public void DrawBa()
        {
            PictureBox PL = new PictureBox()
            {
                Location = new Point(x, y),
                Size = new Size(60, 60),
                Image = Properties.Resources.Bat,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            BoxMob.Add(PL);
        }
    }
    public class Monster : Mobs
    {
        public bool Fly { get; set; }
    }
}
