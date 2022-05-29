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

        //Winner Variable
        String playerWinnerX = "Player X Wins!!";
        String playerWinnerO = "Player O Wins!!";
        

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


        //Buttons for row A
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

        //Button row B
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

        //Button row C
        private void btnC1_Click(object sender, EventArgs e)
        {
            textBoxC1.Text = "x";

            if (playerTurn = !playerTurn)
            {
                textBoxC1.Text = "o";

            }
            btnC1.Enabled = false;
            textBoxC1.Enabled = false;
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


        //Winner conditions
        private void winnerCheckButton_Click(object sender, EventArgs e)
        {

            //Player X wins in a Horizontal way
            if (textBoxA1.Text == "x")
            {
                if (textBoxA2.Text == "x")
                {
                    if (textBoxA3.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }
            if (textBoxB1.Text == "x")
            {
                if (textBoxB2.Text == "x")
                {
                    if (textBoxB3.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }
            if (textBoxC1.Text == "x")
            {
                if (textBoxC2.Text == "x")
                {
                    if (textBoxC3.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }

            //Player O wins in a Horizontal way
            if (textBoxA1.Text == "o")
            {
                if (textBoxA2.Text == "o")
                {
                    if (textBoxA3.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }

            if (textBoxB1.Text == "o")
            {
                if (textBoxB2.Text == "o")
                {
                    if (textBoxB3.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }

            if (textBoxC1.Text == "o")
            {
                if (textBoxC2.Text == "o")
                {
                    if (textBoxC3.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }

            //Player X wins in a Vertical way
            if (textBoxA1.Text == "x")
            {
                if (textBoxB1.Text == "x")
                {
                    if (textBoxC1.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }
            if (textBoxA2.Text == "x")
            {
                if (textBoxB2.Text == "x")
                {
                    if (textBoxC2.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }
            if (textBoxA3.Text == "x")
            {
                if (textBoxB3.Text == "x")
                {
                    if (textBoxC3.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }

            //Player O wins in a Vertical way
            if (textBoxA1.Text == "o")
            {
                if (textBoxB1.Text == "o")
                {
                    if (textBoxC1.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }
            if (textBoxA2.Text == "o")
            {
                if (textBoxB2.Text == "o")
                {
                    if (textBoxC2.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }
            if (textBoxA3.Text == "o")
            {
                if (textBoxB3.Text == "o")
                {
                    if (textBoxC3.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }

            //Player X wins in a Diagonal way
            if (textBoxA1.Text == "x")
            {
                if (textBoxB2.Text == "x")
                {
                    if (textBoxC3.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }
            if (textBoxA3.Text == "x")
            {
                if (textBoxB2.Text == "x")
                {
                    if (textBoxC1.Text == "x")
                    {
                        MessageBox.Show(playerWinnerX);
                    }

                }

            }

            //Player O wins in a Diagonal way
            if (textBoxA1.Text == "o")
            {
                if (textBoxB2.Text == "o")
                {
                    if (textBoxC3.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }
            if (textBoxA3.Text == "o")
            {
                if (textBoxB2.Text == "o")
                {
                    if (textBoxC1.Text == "o")
                    {
                        MessageBox.Show(playerWinnerO);
                    }

                }

            }
            }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //A row
            textBoxA1.Enabled = true;
            btnA1.Enabled = true;
            textBoxA1.Clear();
            textBoxA2.Enabled = true;
            btnA2.Enabled = true;
            textBoxA2.Clear();
            textBoxA3.Enabled = true;
            btnA3.Enabled = true;
            textBoxA3.Clear();

            //B row
            textBoxB1.Enabled = true;
            btnB1.Enabled = true;
            textBoxB1.Clear();
            textBoxB2.Enabled = true;
            btnB2.Enabled = true;
            textBoxB2.Clear();
            textBoxB3.Enabled = true;
            btnB3.Enabled = true;
            textBoxB3.Clear();

            //C row
            textBoxC1.Enabled = true;
            btnC1.Enabled = true;
            textBoxC1.Clear();
            textBoxC2.Enabled = true;
            btnC2.Enabled = true;
            textBoxC2.Clear();
            textBoxC3.Enabled = true;
            btnC3.Enabled = true;
            textBoxC3.Clear();

            playerTurn = !playerTurn;
        }

    }
    
       
    }


