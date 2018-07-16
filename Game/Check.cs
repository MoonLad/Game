using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Check
    {
       public void CheckTerra(Form1 fr)
        {
            foreach (var item in fr.listTerra)
            {
                switch (Convert.ToInt32(item.Tag))
                {
                    case 0:
                        if (fr.player.BoxMob[0].Location.X >= item.Location.X && fr.player.BoxMob[0].Location.X <= item.Location.X + 48 &&
                            fr.player.BoxMob[0].Location.Y >= item.Location.Y && fr.player.BoxMob[0].Location.Y <= item.Location.Y + 48)
                        {
                            fr.player.Speed = fr.spd;
                        }
                        break;
                    case 1:
                        if (fr.player.BoxMob[0].Location.X >= item.Location.X && fr.player.BoxMob[0].Location.X <= item.Location.X + 48 &&
                            fr.player.BoxMob[0].Location.Y >= item.Location.Y && fr.player.BoxMob[0].Location.Y <= item.Location.Y + 48)
                        {
                            if (fr.player.Speed >= 2)
                            { fr.player.Speed /= 2; }
                        }
                        break;
                    case 2:
                        if (fr.player.BoxMob[0].Location.X + 24 >= item.Location.X && fr.player.BoxMob[0].Location.X <= item.Location.X + 48 &&
                            fr.player.BoxMob[0].Location.Y + 24 >= item.Location.Y && fr.player.BoxMob[0].Location.Y <= item.Location.Y + 48)
                        {
                            switch (fr.RLUD)
                            {
                                case 1:
                                    fr.player.y += fr.player.Speed + 16;
                                    break;
                                case 2:
                                    fr.player.y -= fr.player.Speed + 16;
                                    break;
                                case 3:
                                    fr.player.x += fr.player.Speed + 16;
                                    break;
                                case 4:
                                    fr.player.x -= fr.player.Speed + 16;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        if (fr.player.BoxMob[0].Location.X + 24 >= item.Location.X && fr.player.BoxMob[0].Location.X <= item.Location.X + 48 &&
                             fr.player.BoxMob[0].Location.Y + 24 >= item.Location.Y && fr.player.BoxMob[0].Location.Y <= item.Location.Y + 48)
                        {
                            fr.player.Speed = fr.spd;
                            fr.player.HP -= 0.5;
                            fr.player.LabelMob[0].Text = fr.player.HP.ToString();
                            if (fr.player.HP <= 0)
                            {
                                fr.player.BoxMob[0].Dispose();
                                fr.player.LabelMob[0].Text = "END";
                            }
                        }
                        break;
                }
            }
        }
    }
}
