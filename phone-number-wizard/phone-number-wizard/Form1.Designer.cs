namespace phone_number_wizard
{
    partial class frmIncrementalPhoneNumber
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
        private void InitializeComponent()
        {
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnBigger = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblClicks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picChangeArrow = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChangeArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(76, 269);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(72, 25);
            this.btnSmaller.TabIndex = 0;
            this.btnSmaller.Text = "smaller";
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            this.btnSmaller.MouseEnter += new System.EventHandler(this.btnSmaller_MouseEnter);
            this.btnSmaller.MouseLeave += new System.EventHandler(this.btnSmaller_MouseLeave);
            // 
            // btnBigger
            // 
            this.btnBigger.Location = new System.Drawing.Point(154, 269);
            this.btnBigger.Name = "btnBigger";
            this.btnBigger.Size = new System.Drawing.Size(72, 25);
            this.btnBigger.TabIndex = 1;
            this.btnBigger.Text = "bigger";
            this.btnBigger.UseVisualStyleBackColor = true;
            this.btnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            this.btnBigger.MouseEnter += new System.EventHandler(this.btnBigger_MouseEnter);
            this.btnBigger.MouseLeave += new System.EventHandler(this.btnBigger_MouseLeave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(74, 210);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(159, 29);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "555-555-5555";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(310, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 25);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(232, 269);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(72, 25);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblClicks
            // 
            this.lblClicks.AutoSize = true;
            this.lblClicks.Location = new System.Drawing.Point(76, 250);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(98, 13);
            this.lblClicks.TabIndex = 5;
            this.lblClicks.Text = "Number of clicks: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter your phone number:\r\n";
            // 
            // picChangeArrow
            // 
            this.picChangeArrow.Image = global::phone_number_wizard.Properties.Resources.imgDownRedArrow;
            this.picChangeArrow.Location = new System.Drawing.Point(228, 205);
            this.picChangeArrow.Name = "picChangeArrow";
            this.picChangeArrow.Size = new System.Drawing.Size(26, 39);
            this.picChangeArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChangeArrow.TabIndex = 7;
            this.picChangeArrow.TabStop = false;
            this.picChangeArrow.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(388, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmIncrementalPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(994, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picChangeArrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.btnBigger);
            this.Controls.Add(this.btnSmaller);
            this.Name = "frmIncrementalPhoneNumber";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChangeArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picChangeArrow;
        private System.Windows.Forms.Button button2;
    }
}

