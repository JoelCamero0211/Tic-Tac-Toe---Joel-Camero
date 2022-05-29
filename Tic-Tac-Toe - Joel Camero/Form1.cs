using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe___Joel_Camero
{
    public partial class TicTacToe : Form
    {
        Boolean playerTurn = false;
        
        public TicTacToe()
        {
            InitializeComponent();
            playerTurn = !playerTurn;
        }


        private void buttonA1_Click(object sender, EventArgs e)
        {
            textBoxA1.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxA1.Text = "o";
          
            }
            buttonA1.Enabled = false;
            textBoxA1.Enabled = false;

        }
       

    }
}
