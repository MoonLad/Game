using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
   public class Terra
    {
        public int x { get; set; }
        public int y { get; set; }
        public List<PictureBox> listTerra = new List<PictureBox>();
    }
    class Dirt : Terra
    {
        public void Draw(Form1 fr)
        {
            PictureBox dirt = new PictureBox()
            {
                Tag = 0,
                Location = new Point(x, y),
                Size = new Size(48, 48)
            };
            listTerra.Add(dirt);
            fr.listTerra.Add(dirt);
        }
    }
    class Grass : Terra
    {
        public void Draw(Form1 fr)
        {
            PictureBox grass = new PictureBox()
            {
                Tag = 1,
                Location = new Point(x, y),
                Size = new Size(48, 48)
            };
            listTerra.Add(grass);
            fr.listTerra.Add(grass);
        }
    }
    class Water : Terra
    {
        public void Draw(Form1 fr)
        {
            PictureBox water = new PictureBox()
            {
                Tag = 2,
                Location = new Point(x, y),
                Size = new Size(48, 48)
            };
            listTerra.Add(water);
            fr.listTerra.Add(water);
        }
    }
    class Lava : Terra
    {
        public void Draw(Form1 fr)
        {
            PictureBox lava = new PictureBox()
            {
                Tag = 3,
                Location = new Point(x, y),
                Size = new Size(48, 48)
            };
            listTerra.Add(lava);
            fr.listTerra.Add(lava);
        }
    }
}
