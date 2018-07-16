using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Draw
    {
        public Apple apple = new Apple();
        public Cherry cherry = new Cherry();
        protected Monster monster = new Monster();
        protected Monster monsterF = new Monster();
        Dirt dirt = new Dirt();
        Grass grass = new Grass();
        Water water = new Water();
        Lava lava = new Lava();
        static Image img = new Bitmap(768, 768);
        Graphics GR = Graphics.FromImage(img);
        Random random = new Random();
        private void CherryApple(Form1 fr)
        {
            monsterF.Fly = false;
            apple.name = "Apple";
            cherry.name = "Cherry";
            for (int i = 0; i < 3; i++)
            {
                apple.Draw();
                cherry.Draw();
            }
            for (int i = 0, Frand = random.Next(0, 50); i < 6; i++, Frand = random.Next(0, 50))
            {
                if (i < 3)
                {
                    apple.PFruit[i].Location = new Point(dirt.listTerra[Frand].Location.X + 8, dirt.listTerra[Frand].Location.Y + 8);
                    apple.LFruit[i].Location = new Point(dirt.listTerra[Frand].Location.X + 2, dirt.listTerra[Frand].Location.Y + 40);
                    fr.Controls.Add(apple.PFruit[i]);
                    fr.Pfruit.Add(apple.PFruit[i]);
                    fr.Controls.Add(apple.LFruit[i]);
                    fr.Lfruit.Add(apple.LFruit[i]);
                }
                else
                {
                    cherry.PFruit[i - 3].Location = new Point(dirt.listTerra[Frand].Location.X + 8, dirt.listTerra[Frand].Location.Y + 8);
                    cherry.LFruit[i - 3].Location = new Point(dirt.listTerra[Frand].Location.X + 2, dirt.listTerra[Frand].Location.Y + 40);
                    fr.Pfruit.Add(cherry.PFruit[i - 3]);
                    fr.Controls.Add(cherry.PFruit[i - 3]);
                    fr.Lfruit.Add(cherry.LFruit[i - 3]);
                    fr.Controls.Add(cherry.LFruit[i - 3]);
                }

            }
        }
        public void DR(Form1 fr)
        {
            fr.player.Speed = 1;
            fr.player.HP = 60;
            fr.player.DrawP();
            fr.player.LabelMob[0].Text = fr.player.HP.ToString();
            fr.Controls.Add(fr.player.BoxMob[0]);
            fr.Controls.Add(fr.player.LabelMob[0]);
            fr.Controls.Add(fr.player.LabelMob[1]);

            #region Terra
            int[,] mass = new int[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    mass[i, j] = random.Next(4);
                }
            }
            for (int i = 0, x = 0; i < 16; i++, x += 48)
            {
                for (int j = 0, y = 0; j < 16; j++, y += 48)
                {
                    switch (mass[i, j])
                    {
                        case 0:
                            dirt.x = x;
                            dirt.y = y;
                            dirt.Draw(fr);
                            GR.DrawImage(Image.FromFile("Dirt.png"), new Point(x, y));
                            break;
                        case 1:
                            grass.x = x;
                            grass.y = y;
                            grass.Draw(fr);
                            GR.DrawImage(Image.FromFile("Grass.png"), new Point(x, y));
                            break;
                        case 2:
                            water.x = x;
                            water.y = y;
                            water.Draw(fr);
                            GR.DrawImage(Image.FromFile("Water.png"), new Point(x, y));
                            break;
                        case 3:
                            lava.x = x;
                            lava.y = y;
                            lava.Draw(fr);
                            GR.DrawImage(Image.FromFile("Lava.png"), new Point(x, y));
                            break;
                    }
                }
            }
            fr.BackgroundImage = img;
            #endregion

            CherryApple(fr);  //Draw Fruit

            #region Mobs

            monster.Speed = 3;
            monsterF.Speed = 4;

            for (int i = 0, ra = random.Next(0, 256); i < 2; i++, ra = random.Next(0, 256))
            {
                monster.DrawB();
                monsterF.DrawBa();
            }
            for (int j = 0, BatRand = random.Next(0, 256); j < 2; j++, BatRand = random.Next(0, 256))
            {
                if (j < 2)
                {
                    monsterF.BoxMob[j].Location = new Point(fr.listTerra[BatRand].Location.X - 6, fr.listTerra[BatRand].Location.Y - 10);
                    fr.Mobs.Add(monsterF.BoxMob[j]);
                    fr.Controls.Add(monsterF.BoxMob[j]);
                }
                if (j == 2)
                {
                    break;
                }
            }
            for (int i = 0, BearRand = random.Next(0, 256); ; BearRand = random.Next(0, 256))
            {
                if (Convert.ToInt32(fr.listTerra[BearRand].Tag) == 0 | Convert.ToInt32(fr.listTerra[BearRand].Tag) == 1 & i < 2)
                {
                    monster.BoxMob[i].Location = new Point(fr.listTerra[BearRand].Location.X, fr.listTerra[BearRand].Location.Y);
                    fr.Mobs.Add(monster.BoxMob[i]);
                    fr.Controls.Add(monster.BoxMob[i]);
                    i++;
                }
                if (i == 2)
                {
                    break;
                }
            }
            #endregion
        }
    }
}
