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
        //Player turns using Boolean 
        Boolean playerTurn = false;
        
        public TicTacToe()
        {
            InitializeComponent();
            //Player turn switch
            playerTurn = !playerTurn;

            //Alignment of the textboxes
            textBoxA1.SelectAll();
            textBoxA1.SelectionAlignment = HorizontalAlignment.Center;
            textBoxA2.SelectAll();
            textBoxA2.SelectionAlignment = HorizontalAlignment.Center;
            textBoxA3.SelectAll();
            textBoxA3.SelectionAlignment = HorizontalAlignment.Center;

            textBoxB1.SelectAll();
            textBoxB1.SelectionAlignment = HorizontalAlignment.Center;
            textBoxB2.SelectAll();
            textBoxB2.SelectionAlignment = HorizontalAlignment.Center;
            textBoxB3.SelectAll();
            textBoxB3.SelectionAlignment = HorizontalAlignment.Center;

            textBoxC1.SelectAll();
            textBoxC1.SelectionAlignment = HorizontalAlignment.Center;
            textBoxC2.SelectAll();
            textBoxC2.SelectionAlignment = HorizontalAlignment.Center;
            textBoxC3.SelectAll();
            textBoxC3.SelectionAlignment = HorizontalAlignment.Center;
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

        private void buttonA2_Click(object sender, EventArgs e)
        {
            textBoxA2.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxA2.Text = "o";

            }
            buttonA2.Enabled = false;
            textBoxA2.Enabled = false;

        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            textBoxA3.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxA3.Text = "o";

            }
            buttonA3.Enabled = false;
            textBoxA3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Mechanics_Click(object sender, EventArgs e)
        {

        }
    }
}
