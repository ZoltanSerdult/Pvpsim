using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvpsim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int hero_hp = Convert.ToInt32(Hero_hp.Value);
            int hero_mindmg = Convert.ToInt32(Hero_mindmg.Value);
            int hero_maxdmg = Convert.ToInt32(Hero_maxdmg.Value);

            int enemy_hp = Convert.ToInt32(Enemy_hp.Value);
            int enemy_mindmg = Convert.ToInt32(Enemy_mindmg.Value);
            int enemy_maxdmg = Convert.ToInt32(Enemy_maxdmg.Value);

            int []tomb = new int[10];
            int turn = Convert.ToInt32(Turn.Value);

            for (int i = 0; i < 10; i++)
            {
                kiir.Text = Convert.ToString(hero_hp);
            }
        }
    }
}
