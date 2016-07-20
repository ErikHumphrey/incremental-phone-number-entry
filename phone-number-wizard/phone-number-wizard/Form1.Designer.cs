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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.picCounter1 = new System.Windows.Forms.PictureBox();
            this.picCounter2 = new System.Windows.Forms.PictureBox();
            this.picCounter3 = new System.Windows.Forms.PictureBox();
            this.picCounter4 = new System.Windows.Forms.PictureBox();
            this.picCounter5 = new System.Windows.Forms.PictureBox();
            this.picCounter6 = new System.Windows.Forms.PictureBox();
            this.picCounter7 = new System.Windows.Forms.PictureBox();
            this.picCounter8 = new System.Windows.Forms.PictureBox();
            this.picCounter9 = new System.Windows.Forms.PictureBox();
            this.picCounter10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChangeArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(12, 98);
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
            this.btnBigger.Location = new System.Drawing.Point(90, 98);
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
            this.lblPhoneNumber.Location = new System.Drawing.Point(10, 39);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(159, 29);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "555-555-5555";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(246, 98);
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
            this.btnUndo.Location = new System.Drawing.Point(168, 98);
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
            this.lblClicks.Location = new System.Drawing.Point(12, 79);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(98, 13);
            this.lblClicks.TabIndex = 5;
            this.lblClicks.Text = "Number of clicks: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter your phone number:\r\n";
            // 
            // picChangeArrow
            // 
            this.picChangeArrow.Image = global::phone_number_wizard.Properties.Resources.imgDownRedArrow;
            this.picChangeArrow.Location = new System.Drawing.Point(164, 34);
            this.picChangeArrow.Name = "picChangeArrow";
            this.picChangeArrow.Size = new System.Drawing.Size(26, 39);
            this.picChangeArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChangeArrow.TabIndex = 7;
            this.picChangeArrow.TabStop = false;
            this.picChangeArrow.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(324, 98);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 25);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // picCounter1
            // 
            this.picCounter1.Location = new System.Drawing.Point(96, 143);
            this.picCounter1.Name = "picCounter1";
            this.picCounter1.Size = new System.Drawing.Size(45, 100);
            this.picCounter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter1.TabIndex = 11;
            this.picCounter1.TabStop = false;
            // 
            // picCounter2
            // 
            this.picCounter2.Location = new System.Drawing.Point(142, 143);
            this.picCounter2.Name = "picCounter2";
            this.picCounter2.Size = new System.Drawing.Size(45, 100);
            this.picCounter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter2.TabIndex = 12;
            this.picCounter2.TabStop = false;
            // 
            // picCounter3
            // 
            this.picCounter3.Location = new System.Drawing.Point(188, 143);
            this.picCounter3.Name = "picCounter3";
            this.picCounter3.Size = new System.Drawing.Size(45, 100);
            this.picCounter3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter3.TabIndex = 13;
            this.picCounter3.TabStop = false;
            // 
            // picCounter4
            // 
            this.picCounter4.Location = new System.Drawing.Point(289, 143);
            this.picCounter4.Name = "picCounter4";
            this.picCounter4.Size = new System.Drawing.Size(45, 100);
            this.picCounter4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter4.TabIndex = 14;
            this.picCounter4.TabStop = false;
            // 
            // picCounter5
            // 
            this.picCounter5.Location = new System.Drawing.Point(335, 143);
            this.picCounter5.Name = "picCounter5";
            this.picCounter5.Size = new System.Drawing.Size(45, 100);
            this.picCounter5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter5.TabIndex = 15;
            this.picCounter5.TabStop = false;
            // 
            // picCounter6
            // 
            this.picCounter6.Location = new System.Drawing.Point(483, 143);
            this.picCounter6.Name = "picCounter6";
            this.picCounter6.Size = new System.Drawing.Size(45, 100);
            this.picCounter6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter6.TabIndex = 16;
            this.picCounter6.TabStop = false;
            // 
            // picCounter7
            // 
            this.picCounter7.Location = new System.Drawing.Point(381, 143);
            this.picCounter7.Name = "picCounter7";
            this.picCounter7.Size = new System.Drawing.Size(45, 100);
            this.picCounter7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter7.TabIndex = 17;
            this.picCounter7.TabStop = false;
            // 
            // picCounter8
            // 
            this.picCounter8.Location = new System.Drawing.Point(529, 143);
            this.picCounter8.Name = "picCounter8";
            this.picCounter8.Size = new System.Drawing.Size(45, 100);
            this.picCounter8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter8.TabIndex = 18;
            this.picCounter8.TabStop = false;
            // 
            // picCounter9
            // 
            this.picCounter9.Location = new System.Drawing.Point(575, 143);
            this.picCounter9.Name = "picCounter9";
            this.picCounter9.Size = new System.Drawing.Size(45, 100);
            this.picCounter9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter9.TabIndex = 19;
            this.picCounter9.TabStop = false;
            // 
            // picCounter10
            // 
            this.picCounter10.Location = new System.Drawing.Point(621, 143);
            this.picCounter10.Name = "picCounter10";
            this.picCounter10.Size = new System.Drawing.Size(45, 100);
            this.picCounter10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter10.TabIndex = 20;
            this.picCounter10.TabStop = false;
            // 
            // frmIncrementalPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(407, 131);
            this.Controls.Add(this.picCounter10);
            this.Controls.Add(this.picCounter9);
            this.Controls.Add(this.picCounter8);
            this.Controls.Add(this.picCounter7);
            this.Controls.Add(this.picCounter6);
            this.Controls.Add(this.picCounter5);
            this.Controls.Add(this.picCounter4);
            this.Controls.Add(this.picCounter3);
            this.Controls.Add(this.picCounter2);
            this.Controls.Add(this.picCounter1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picChangeArrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.btnBigger);
            this.Controls.Add(this.btnSmaller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncrementalPhoneNumber";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Incremental Phone Number Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChangeArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter10)).EndInit();
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picCounter1;
        private System.Windows.Forms.PictureBox picCounter2;
        private System.Windows.Forms.PictureBox picCounter3;
        private System.Windows.Forms.PictureBox picCounter4;
        private System.Windows.Forms.PictureBox picCounter5;
        private System.Windows.Forms.PictureBox picCounter6;
        private System.Windows.Forms.PictureBox picCounter7;
        private System.Windows.Forms.PictureBox picCounter8;
        private System.Windows.Forms.PictureBox picCounter9;
        private System.Windows.Forms.PictureBox picCounter10;
    }
}

