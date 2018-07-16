using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
   public class BrainMobs : Draw
    {
        Random random = new Random();
        public void BrainBeer(Form1 fr)
        {
            for (int i = 0, RLUD = random.Next(1, 5); i < 2; i++, RLUD = random.Next(1, 5))
            {
                switch (RLUD)
                {
                    case 1:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y - fr.monster.Speed, fr.Mobs[i].Location.X);
                        break;
                    case 2:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y + fr.monster.Speed, fr.Mobs[i].Location.X);
                        break;
                    case 3:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y, fr.Mobs[i].Location.X - fr.monster.Speed);
                        break;
                    case 4:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y, fr.Mobs[i].Location.X + fr.monster.Speed);
                        break;
                }
            }
            for (int i = 2, RLUD = random.Next(1, 5); i < 4; i++, RLUD = random.Next(1, 5))
            {
                switch (RLUD)
                {
                    case 1:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y - fr.monsterF.Speed, fr.Mobs[i].Location.X);
                        break;
                    case 2:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y + fr.monsterF.Speed, fr.Mobs[i].Location.X);
                        break;
                    case 3:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y, fr.Mobs[i].Location.X - fr.monsterF.Speed);
                        break;
                    case 4:
                        fr.Mobs[i].Location = new Point(fr.Mobs[i].Location.Y, fr.Mobs[i].Location.X + fr.monsterF.Speed);
                        break;
                }
            }
        }
    }
}
