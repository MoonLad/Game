using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class TEat
    {
        public void Eat(Form1 fr)
        {
            for (int C = 0; C < fr.Pfruit.Count; C++)
            {
                if (fr.player.BoxMob[0].Location.X + 32 >= fr.Pfruit[C].Location.X && fr.player.BoxMob[0].Location.X <= fr.Pfruit[C].Location.X + 32 &&
                    fr.player.BoxMob[0].Location.Y + 32 >= fr.Pfruit[C].Location.Y && fr.player.BoxMob[0].Location.Y <= fr.Pfruit[C].Location.Y + 32)
                {
                    if (Convert.ToInt32(fr.Pfruit[C].Tag) == 0)
                    {
                        fr.player.HP += fr.apple.Heal;
                        fr.player.LabelMob[0].Text = fr.player.HP.ToString();
                    }
                    else
                    {
                        fr.player.Speed += fr.cherry.Speed;
                        fr.spd = fr.player.Speed;
                        fr.player.LabelMob[1].Text = fr.player.Speed.ToString();
                    }
                    fr.Pfruit[C].Dispose();
                    fr.Lfruit[C].Dispose();
                    fr.Pfruit.RemoveAt(C);
                    fr.Lfruit.RemoveAt(C);
                }
            }
        }
    }
}
