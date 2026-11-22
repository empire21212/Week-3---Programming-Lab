using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class frmForm1 : Form
    {
        public frmForm1()
        {
            InitializeComponent();
        }

        //********************************************************************************************** 
        // General Changes: Sorted the code from the button click events to the respective methods below
        //**********************************************************************************************

        //**********************************************************************************************
        // btnRed Changes:
        //          1- Font color added
        //              "lblMessage.ForeColor = Color.Red"
        //**********************************************************************************************

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnRed.BackColor;
            lblMessage.ForeColor = Color.Red;
        }

        //**********************************************************************************************
        // btnBlue Changes:
        //          1- Font color added
        //              "lblMessage.ForeColor = Color.Blue"
        //**********************************************************************************************

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnBlue.BackColor;
            lblMessage.ForeColor = Color.Blue;
        }

        //**********************************************************************************************
        // btnL Changes: 
        //          1- Background color added
        //              "lblMessage.BackColor = btnL.BackColor"
        //          2- Font family and font size specified
        //              "lblMessage.Font = new System.Drawing.Font("Times New Roman", 64F)"
        //          3- Font color added
        //              "lblMessage.ForeColor = Color.Black"
        //          4- lblMessage.Text value fixed
        //              "lblMessage.Text = "L""
        //**********************************************************************************************

        private void btnL_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnL.BackColor;
            lblMessage.Font = new System.Drawing.Font("Times New Roman", 64F);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = "L";
        }

        //**********************************************************************************************
        // btnR Changes: 
        //          1- Background color added
        //              "lblMessage.BackColor = btnR.BackColor"
        //          2- Font family and font size specified
        //              "lblMessage.Font = new System.Drawing.Font("Times New Roman", 64F)"
        //          3- Font color added
        //              "lblMessage.ForeColor = Color.Black"
        //          4- lblMessage.Text value fixed
        //              "lblMessage.Text = "R""
        //**********************************************************************************************

        private void btnR_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnR.BackColor;
            lblMessage.Font = new System.Drawing.Font("Times New Roman", 64F);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = "R";
        }

        //**********************************************************************************************
        // btnExit Changes: 
        //          1- Method fixed
        //              "private void btnExit_Click(object sender, EventArgs e)"
        //**********************************************************************************************

        private void btnExit_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnExit.BackColor;
            this.Close();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
