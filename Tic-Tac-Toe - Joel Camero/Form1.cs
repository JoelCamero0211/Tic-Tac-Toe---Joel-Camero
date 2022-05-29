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
        
        

        private void btnA1_Click(object sender, EventArgs e)
        {
            textBoxA1.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxA1.Text = "o";
          
            }
            btnA1.Enabled = false;
            textBoxA1.Enabled = false;

        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            textBoxA2.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxA2.Text = "o";

            }
            btnA2.Enabled = false;
            textBoxA2.Enabled = false;

        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            textBoxA3.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxA3.Text = "o";

            }
            btnA3.Enabled = false;
            textBoxA3.Enabled = false;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            textBoxB1.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxB1.Text = "o";

            }
            btnB1.Enabled = false;
            textBoxB1.Enabled = false;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            textBoxB2.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxB2.Text = "o";

            }
            btnB2.Enabled = false;
            textBoxB2.Enabled = false;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            textBoxB3.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxB3.Text = "o";

            }
            btnB3.Enabled = false;
            textBoxB3.Enabled = false;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            textBoxC2.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxC2.Text = "o";

            }
            btnC2.Enabled = false;
            textBoxC2.Enabled = false;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            textBoxC3.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxC3.Text = "o";

            }
            btnC3.Enabled = false;
            textBoxC3.Enabled = false;
        }
    }
}
