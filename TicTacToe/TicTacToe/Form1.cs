using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public void check_win()
        //{
        //    //handle horizontal cases
        //    if (bx1.Text == bx2.Text && bx2.Text == bx3.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    //2
        //    else if (bx4.Text == bx5.Text && bx5.Text == bx6.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    //3
        //    else if (bx7.Text == bx8.Text && bx8.Text == bx9.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    // handle vertical cases 1
        //    else if (bx1.Text == bx4.Text && bx4.Text == bx7.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    //2
        //    else if (bx2.Text == bx5.Text && bx5.Text == bx8.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    //3
        //    else if (bx3.Text == bx6.Text && bx6.Text == bx9.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    //diagonal 1
        //    else if (bx1.Text == bx5.Text && bx5.Text == bx9.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    //2
        //    else if (bx3.Text == bx5.Text && bx5.Text == bx7.Text)
        //    {
        //        string winner = bx2.Text;
        //        MessageBox.Show(winner + " wins!");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("hello");
        //    }
        //}

        public void check_win()


            // TODO
            // FIX THE WAY THE PROJECT READS THE WINNER


        {
            //handle horizontal cases
            if (bx1.Text != "" && bx1.Text == bx2.Text && bx2.Text == bx3.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            //2
            else if (bx4.Text != "" && bx4.Text == bx5.Text && bx5.Text == bx6.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            //3
            else if (bx7.Text != "" && bx7.Text == bx8.Text && bx8.Text == bx9.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            // handle vertical cases 1
            else if (bx1.Text != "" && bx1.Text == bx4.Text && bx4.Text == bx7.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            //2
            else if (bx2.Text != "" && bx2.Text == bx5.Text && bx5.Text == bx8.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            //3
            else if (bx3.Text != "" && bx3.Text == bx6.Text && bx6.Text == bx9.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            //diagonal 1
            else if (bx4.Text != "" && bx1.Text == bx5.Text && bx5.Text == bx9.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            //2
            else if (bx3.Text != "" && bx3.Text == bx5.Text && bx5.Text == bx7.Text)
            {
                string winner = bx2.Text;
                MessageBox.Show("Game Over");
            }
            else
            {
                Console.WriteLine("hello");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bx1.Text = "";
            bx2.Text = "";
            bx3.Text = "";
            bx4.Text = "";
            bx5.Text = "";
            bx6.Text = "";
            bx7.Text = "";
            bx8.Text = "";
            bx9.Text = "";
        }

        private void bx1_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx1.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx1.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }
        private void bx2_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx2.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx2.Text = "O";
                statelbl.Text = "X";
            }
            check_win();

        }

        private void bx3_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx3.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx3.Text = "O";
                statelbl.Text = "X";
            }
            check_win();

        }

        private void bx4_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx4.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx4.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }

        private void bx5_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx5.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx5.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }

        private void bx6_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx6.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx6.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }

        private void bx7_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx7.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx7.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }

        private void bx8_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx8.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx8.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }

        private void bx9_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "X")
            {
                bx9.Text = "X";
                statelbl.Text = "O";
            }
            else if (statelbl.Text == "O")
            {
                bx9.Text = "O";
                statelbl.Text = "X";
            }
            check_win();
        }
    }
}
