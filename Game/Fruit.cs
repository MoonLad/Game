using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
   public class Fruit
    {
        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public List<PictureBox> PFruit = new List<PictureBox>();
        public List<Label> LFruit = new List<Label>();
    }
    public class Apple : Fruit
    {
        public double Heal { get; set; }
        public void Draw()
        {
            PictureBox apl = new PictureBox()
            {
                Tag = 0,
                Location = new Point(x, y),
                Size = new Size(32, 32),
                Image = Properties.Resources.Apple,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            PFruit.Add(apl);
            Label lb = new Label()
            {
                Location = new Point(x - 6, y + 35),
                Size = new Size(45, 18),
                Text = name,
                BackColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe Print", 8, FontStyle.Bold),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };
            LFruit.Add(lb);
        }
    }

    public class Cherry : Fruit
    {
        public int Speed { get; set; }
        public void Draw()
        {
            PictureBox cheer = new PictureBox()
            {
                Tag = 1,
                Location = new Point(x, y),
                Size = new Size(32, 32),
                Image = Properties.Resources.Cherry,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            PFruit.Add(cheer);
            Label lb = new Label()
            {
                Location = new Point(x, y),
                Size = new Size(48, 18),
                Text = name,
                BackColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe Print", 8, FontStyle.Bold),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };
            LFruit.Add(lb);
        }
    }
}
