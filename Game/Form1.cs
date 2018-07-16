using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Apple apple = new Apple();
        public Cherry cherry = new Cherry();
        public Mobs player = new Mobs();
        public Terra terra = new Terra();
        public List<PictureBox> listTerra = new List<PictureBox>();
        public List<PictureBox> Pfruit = new List<PictureBox>();
        public List<PictureBox> Mobs = new List<PictureBox>();
        public List<Label> Lfruit = new List<Label>();
        public Monster monster = new Monster();
        public Monster monsterF = new Monster();
        BrainMobs brainmobs = new BrainMobs();
        Draw draw = new Draw();
        TEat eat = new TEat();
        Check check = new Check();
        public int spd = 2;
        public int RLUD;

        private void Form1_Load(object sender, EventArgs e)
        {
            monster.Speed = 3;
            monsterF.Speed = 4;
            TimeBonus.Enabled = true;
            apple.Heal = 10;
            cherry.Speed = 1;
            draw.DR(this);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.W || keyData == Keys.Up)
            {
                TimerCheckPos.Enabled = true;
                Timer.Enabled = true;
                player.y -= player.Speed;
                player.BoxMob[0].Location = new Point(player.x, player.y);
                RLUD = 1;
                return true;
            }
            if (keyData == Keys.Down || keyData == Keys.S)
            {
                TimerCheckPos.Enabled = true;
                Timer.Enabled = true;
                player.y += player.Speed;
                player.BoxMob[0].Location = new Point(player.x, player.y);
                RLUD = 2;
                return true;
            }
            if (keyData == Keys.Left || keyData == Keys.A)
            {
                TimerCheckPos.Enabled = true;
                Timer.Enabled = true;
                player.x -= player.Speed;
                player.BoxMob[0].Location = new Point(player.x, player.y);
                RLUD = 3;
                return true;
            }
            if (keyData == Keys.Right || keyData == Keys.D)
            {
                TimerCheckPos.Enabled = true;
                Timer.Enabled = true;
                player.x += player.Speed;
                player.BoxMob[0].Location = new Point(player.x, player.y);
                RLUD = 4;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            eat.Eat(this);
            brainmobs.BrainBeer(this);
            Timer.Enabled = false;
        }

        private void TimeBonus_Tick(object sender, EventArgs e)
        {
            apple.Heal += 2.5;
            cherry.Speed += 1;
        }

        private void TimerCheckPos_Tick(object sender, EventArgs e)
        {
            check.CheckTerra(this);
            TimerCheckPos.Enabled = false;
        }


    }
}
