using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughtsAndCrosses
{
    public partial class GameUI : Form
    {
        private String player1;
        private String player2;
        OxoGame theGame;
        public GameUI(String name1, String name2)
        {
            player1 = name1;
            player2 = name2;
            theGame = new OxoGame(player1, player2);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
