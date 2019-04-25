using System;
using System.Windows.Forms;

namespace NewTicTacToe

{
    public partial class Form1 : Form
    {

        bool xTurn; // if true, it's X's turn
        TextBox squareClicked; // tells which text box is clicked

        private void Form1_Load(object sender, EventArgs e)
        {
            // make it X's turn
            xTurn = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear board
            txtTopLeft.Text = "";
            txtTopMiddle.Text = "";
            txtTopRight.Text = "";
            txtMiddleLeft.Text = "";
            txtMiddleMiddle.Text = "";
            txtMiddleRight.Text = "";
            txtBottomLeft.Text = "";
            txtBottomMiddle.Text = "";
            txtBottomRight.Text = "";
            // Make it X's turn
            xTurn = true;
            txtMessage.Text = "X's Turn";
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            // Place mark in SquareClicked (if none there already)
            if (squareClicked.Text == "")
            {
                if (xTurn)
                {
                    squareClicked.Text = "X";
                    xTurn = false;
                    txtMessage.Text = "O's Turn";
                }
                else
                {
                    squareClicked.Text = "O";
                    xTurn = true;
                    txtMessage.Text = "X's Turn";
                }
            }
        }

        private void txtTopLeft_Click(object sender, EventArgs e)
        {
            squareClicked = txtTopLeft;
            btnMark.PerformClick();
        }
        private void txtTopMiddle_Click(object sender, EventArgs e)
        {
            squareClicked = txtTopMiddle;
            btnMark.PerformClick();
        }
        private void txtTopRight_Click(object sender, EventArgs e)
        {
            squareClicked = txtTopRight;
            btnMark.PerformClick();
        }
        private void txtMiddleLeft_Click(object sender, EventArgs e)
        {
            squareClicked = txtMiddleLeft;
            btnMark.PerformClick();
        }
        private void txtMiddleMiddle_Click(object sender, EventArgs
        e)
        {
            squareClicked = txtMiddleMiddle;
            btnMark.PerformClick();
        }
        private void txtMiddleRight_Click(object sender, EventArgs e)
        {
            squareClicked = txtMiddleRight;
            btnMark.PerformClick();
        }
        private void txtBottomLeft_Click(object sender, EventArgs e)
        {
            squareClicked = txtBottomLeft;
            btnMark.PerformClick();
        }
        private void txtBottomMiddle_Click(object sender, EventArgs
        e)
        {
            squareClicked = txtBottomMiddle;
            btnMark.PerformClick();
        }
        private void txtBottomRight_Click(object sender, EventArgs e)
        {
            squareClicked = txtBottomRight;
            btnMark.PerformClick();
        }
    }

}
