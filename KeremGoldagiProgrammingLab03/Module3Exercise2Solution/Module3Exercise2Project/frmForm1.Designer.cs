namespace Module3Exercise2Project
{
    partial class frmForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        //********************************************************************************************** 
        //
        // InitializeComponent() Changes:  
        //          1- this.button2 changed to this.btnBlue
        //          2- this.button3 changed to this.btnL
        //          3- this.button4 changed to this.btnR
        //          4- this.button5 changed to this.btnExit        
        //          5- this.label1 changed to this.lblMessage
        //
        //          6- Added Hotkey Labels for btnRed, btnBlue, btnL, btnR
        //              "this.lblHotkeyRed = new System.Windows.Forms.Button()"
        //              "this.lblHotkeyBlue = new System.Windows.Forms.Button()"
        //              "this.lblHotkeyL = new System.Windows.Forms.Button()"
        //              "this.lblHotkeyR = new System.Windows.Forms.Button()"
        //**********************************************************************************************

        private void InitializeComponent()
        {
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblHotkeyRed = new System.Windows.Forms.Label();
            this.lblHotkeyBlue = new System.Windows.Forms.Label();
            this.lblHotkeyL = new System.Windows.Forms.Label();
            this.lblHotkeyR = new System.Windows.Forms.Label();
            this.SuspendLayout();

            //******************************************************************************************* 
            // btnRed Changes:
            //          1- Font color set to Red
            //              "this.btnRed.ForeColor = System.Drawing.Color.Red"
            //          2- Button location adjusted
            //              "this.btnRed.Location = new System.Drawing.Point(34, 16)"
            //          3- Button name changed to btnRed
            //              "this.btnRed.Name = "btnRed"  
            //          4- Button text changed to D 
            //              "this.btnRed.Text = "&D" (Hotkey assigned to D)
            //          5- Hotkey assigned to D (&D)                    
            //*******************************************************************************************

            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(34, 16);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(93, 45);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "&D";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);

            //******************************************************************************************* 
            // btnBlue Changes:
            //          1- Font color set to Blue
            //              "this.btnBlue.ForeColor = System.Drawing.Color.Blue"
            //          2- Button location adjusted
            //              "this.btnBlue.Location = new System.Drawing.Point(358, 16)"
            //          3- Button name changed to btnBlue
            //              "this.btnBlue.Name = "btnBlue""
            //          4- Hotkey assigned to B (&BLUE)
            //*******************************************************************************************

            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(358, 16);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(93, 45);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "&BLUE";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);

            //******************************************************************************************* 
            // btnL Changes:
            //          1- Background set to Yellow
            //              "this.btnL.BackColor = System.Drawing.Color.Yellow"
            //          2- Button location adjusted
            //              "this.btnL.Location = new System.Drawing.Point(34, 227)"
            //          3- Button name changed to btnL
            //              "this.btnL.Name = "btnL""
            //          3- Hotkey assigned to L (&L)
            //******************************************************************************************* 

            this.btnL.BackColor = System.Drawing.Color.Yellow;
            this.btnL.Location = new System.Drawing.Point(34, 227);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(93, 45);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "&L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);

            //******************************************************************************************* 
            // btnR Changes:
            //          1- Set background to Yellow
            //              "this.btnR.BackColor = System.Drawing.Color.Yellow"
            //          2- Button location adjusted
            //              "this.btnR.Location = new System.Drawing.Point(358, 227)"
            //          3- Button name changed to btnR
            //          4- Hotkey assigned to R (&R)
            //*******************************************************************************************
            
            this.btnR.BackColor = System.Drawing.Color.Yellow;
            this.btnR.Location = new System.Drawing.Point(358, 227);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(93, 45);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "&R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);

            //******************************************************************************************* 
            // btnExit Changes:
            //          1- Exit button setto cancel the program
            //              "this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel"
            //          2- Button location adjusted
            //              "this.btnExit.Location = new System.Drawing.Point(133, 275)"
            //          3- Button name changed to btnExit
            //              "this.btnExit.Name = "btnExit""          
            //******************************************************************************************* 

            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(133, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            //******************************************************************************************* 
            // Label Changes:
            //          1- Font family changed and font size changed
            //              "this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 64F)"
            //          2- Label location adjusted
            //              "this.lblMessage.Location = new System.Drawing.Point(133, 16)"
            //          3- Label name changed to lblMessage
            //              "this.lblMessage.Name = "lblMessage""
            //          4- Label size adjusted
            //              "this.lblMessage.Size = new System.Drawing.Size(219, 256)"
            //          5- Label text changed to lblMessage
            //              "this.lblMessage.Text = "lblMessage""
            //          6- Label text position aligned centered in the middle
            //              "this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter"
            //          7- Label click event linked to the label click method
            //              "this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click)"
            //*******************************************************************************************

            this.lblMessage.BackColor = System.Drawing.Color.Yellow;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 64F);
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(133, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(219, 256);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "lblMessage";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);

            //******************************************************************************************* 
            // Added Hotkey Label for btnRed
            //          1- Label size set to Auto
            //              "this.lblHotkeyRed.AutoSize = true"
            //          2- Label location aligned with the btnRed button
            //              "this.lblHotkeyRed.Location = new System.Drawing.Point(61, 64)"
            //          3- Label name set to lblHotkeyRed
            //              "this.lblHotkeyRed.Name = "lblHotkeyRed""
            //          4- Label size adjusted
            //              "this.lblHotkeyRed.Size = new System.Drawing.Size(39, 13)"
            //          5- Label tab index assigned
            //              "this.lblHotkeyRed.TabIndex = 6"
            //          6- Label text specified 
            //              "this.lblHotkeyRed.Text = "Alt + D""
            //*******************************************************************************************

            this.lblHotkeyRed.AutoSize = true;
            this.lblHotkeyRed.Location = new System.Drawing.Point(61, 64);
            this.lblHotkeyRed.Name = "lblHotkeyRed";
            this.lblHotkeyRed.Size = new System.Drawing.Size(39, 13);
            this.lblHotkeyRed.TabIndex = 6;
            this.lblHotkeyRed.Text = "Alt + D";

            //******************************************************************************************* 
            // Added Hotkey Label for btnBlue
            //          1- Label size set to Auto
            //              "this.lblHotkeyBlue.AutoSize = true"
            //          2- Label location aligned with the btnBlue button
            //              "this.lblHotkeyBlue.Location = new System.Drawing.Point(387, 64)"
            //          3- Label name set to lblHotkeyBlue
            //              "this.lblHotkeyBlue.Name = "lblHotkeyBlue""
            //          4- Label size adjusted
            //              "this.lblHotkeyBlue.Size = new System.Drawing.Size(38, 13)"
            //          5- Label tab index assigned
            //              "this.lblHotkeyBlue.TabIndex = 7"
            //          6- Label text specified
            //              "this.lblHotkeyBlue.Text = "Alt + B""
            //*******************************************************************************************

            this.lblHotkeyBlue.AutoSize = true;
            this.lblHotkeyBlue.Location = new System.Drawing.Point(387, 64);
            this.lblHotkeyBlue.Name = "lblHotkeyBlue";
            this.lblHotkeyBlue.Size = new System.Drawing.Size(38, 13);
            this.lblHotkeyBlue.TabIndex = 7;
            this.lblHotkeyBlue.Text = "Alt + B";
             
            //******************************************************************************************* 
            // Added Hotkey Label for btnL
            //          1- Label size set to Auto
            //              "this.lblHotkeyL.AutoSize = true"
            //          2- Label location aligned with the btnL button
            //              "this.lblHotkeyL.Location = new System.Drawing.Point(62, 275)"
            //          3- Label name set to lblHotkeyL
            //              "this.lblHotkeyL.Name = "lblHotkeyL""
            //          4- Label size adjusted
            //              "this.lblHotkeyL.Size = new System.Drawing.Size(37, 13)"
            //          5- Label tab index assigned
            //              "this.lblHotkeyL.TabIndex = 8"
            //          6- Label text specified
            //              "this.lblHotkeyL.Text = "Alt + L""
            //*******************************************************************************************
            
            this.lblHotkeyL.AutoSize = true;
            this.lblHotkeyL.Location = new System.Drawing.Point(62, 275);
            this.lblHotkeyL.Name = "lblHotkeyL";
            this.lblHotkeyL.Size = new System.Drawing.Size(37, 13);
            this.lblHotkeyL.TabIndex = 8;
            this.lblHotkeyL.Text = "Alt + L";
             
            //******************************************************************************************* 
            // Added Hotkey Label for btnR
            //          1- Label size set to Auto
            //              "this.lblHotkeyR.AutoSize = true"
            //          2- Label location aligned with the btnR button
            //              "this.lblHotkeyR.Location = new System.Drawing.Point(387, 275)"
            //          3- Label name set to lblHotkeyR
            //              "this.lblHotkeyR.Name = "lblHotkeyR""
            //          4- Label size adjusted
            //              "this.lblHotkeyR.Size = new System.Drawing.Size(39, 13)"
            //          5- Label tab index assigned
            //              "this.lblHotkeyR.TabIndex = 9"
            //          6- Label text specified
            //              "this.lblHotkeyR.Text = "Alt + R""
            //*******************************************************************************************
            
            this.lblHotkeyR.AutoSize = true;
            this.lblHotkeyR.Location = new System.Drawing.Point(387, 275);
            this.lblHotkeyR.Name = "lblHotkeyR";
            this.lblHotkeyR.Size = new System.Drawing.Size(39, 13);
            this.lblHotkeyR.TabIndex = 9;
            this.lblHotkeyR.Text = "Alt + R";

            //******************************************************************************************* 
            // Form1 Changes:
            //          1- Cancel property set to btnExit
            //              "this.CancelButton = this.btnExit"
            //          2- btnRed added
            //              "this.Controls.Add(this.btnRed)"
            //          3- btnBlue added
            //              "this.Controls.Add(this.btnBlue)"
            //          4- btnL added
            //              "this.Controls.Add(this.btnL)"
            //          5- btnR added
            //              "this.Controls.Add(this.btnR)"
            //          6- btnExit added
            //              "this.Controls.Add(this.btnExit)"
            //          7- lblMessage added
            //              "this.Controls.Add(this.lblMessage)"
            //          8- Hotkey Label for btnRed added
            //              "this.Controls.Add(this.lblHotkeyRed)"
            //          9- Hotkey Label for btnBlue added
            //              "this.Controls.Add(this.lblHotkeyBlue)"
            //          10- Hotkey Label for btnL added
            //              "this.Controls.Add(this.lblHotkeyL)"
            //          11- Hotkey Label for btnR added
            //              "this.Controls.Add(this.lblHotkeyR)"
            //*******************************************************************************************

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;            
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHotkeyRed);
            this.Controls.Add(this.lblHotkeyBlue);
            this.Controls.Add(this.lblHotkeyL);
            this.Controls.Add(this.lblHotkeyR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //*********************************************************************************************
        // Property Changes:
        //      1- Button names changed to btnRed, btnBlue, btnL, btnR, btnExit 
        //          "private System.Windows.Forms.Button btnRed"
        //          "private System.Windows.Forms.Button btnBlue"
        //          "private System.Windows.Forms.Button btnL"
        //          "private System.Windows.Forms.Button btnR"
        //          "private System.Windows.Forms.Button btnExit"          
        //      2- Label name changed to lblMessage
        //          "private System.Windows.Forms.Label lblMessage"
        //      3- Added Hotkey Labels for btnRed, btnBlue, btnL, btnR
        //          "private System.Windows.Forms.Label lblHotkeyRed"
        //          "private System.Windows.Forms.Label lblHotkeyBlue"
        //          "private System.Windows.Forms.Label lblHotkeyL"
        //          "private System.Windows.Forms.Label lblHotkeyR"
        //*********************************************************************************************

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;        
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblHotkeyRed;
        private System.Windows.Forms.Label lblHotkeyBlue;
        private System.Windows.Forms.Label lblHotkeyL;
        private System.Windows.Forms.Label lblHotkeyR;
    }
}

