namespace Assignment1_Games
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            RoundLabel = new Label();
            ResetButton = new Button();
            NewGamebtn = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(262, 149);
            button1.Name = "button1";
            button1.Size = new Size(64, 56);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(340, 149);
            button2.Name = "button2";
            button2.Size = new Size(64, 56);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(421, 149);
            button3.Name = "button3";
            button3.Size = new Size(64, 56);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(262, 217);
            button4.Name = "button4";
            button4.Size = new Size(64, 56);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(340, 217);
            button5.Name = "button5";
            button5.Size = new Size(64, 56);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(421, 217);
            button6.Name = "button6";
            button6.Size = new Size(64, 56);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(262, 285);
            button7.Name = "button7";
            button7.Size = new Size(64, 55);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(340, 285);
            button8.Name = "button8";
            button8.Size = new Size(64, 55);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(421, 285);
            button9.Name = "button9";
            button9.Size = new Size(64, 55);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(259, 63);
            label1.Name = "label1";
            label1.Size = new Size(235, 50);
            label1.TabIndex = 9;
            label1.Text = "TIC TAC TOE";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.BackColor = Color.Transparent;
            RoundLabel.BorderStyle = BorderStyle.Fixed3D;
            RoundLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoundLabel.ForeColor = Color.Gainsboro;
            RoundLabel.Location = new Point(581, 93);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(136, 40);
            RoundLabel.TabIndex = 11;
            RoundLabel.Text = "Round: 0";
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.PowderBlue;
            ResetButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.DarkCyan;
            ResetButton.Location = new Point(571, 166);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(157, 44);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "Reset Game";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += resetButton;
            // 
            // NewGamebtn
            // 
            NewGamebtn.BackColor = Color.PowderBlue;
            NewGamebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewGamebtn.ForeColor = Color.DarkCyan;
            NewGamebtn.Location = new Point(571, 223);
            NewGamebtn.Name = "NewGamebtn";
            NewGamebtn.Size = new Size(157, 44);
            NewGamebtn.TabIndex = 13;
            NewGamebtn.Text = "New Game";
            NewGamebtn.UseVisualStyleBackColor = false;
            NewGamebtn.Click += newGameButton;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.PowderBlue;
            ExitButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = Color.DarkCyan;
            ExitButton.Location = new Point(571, 282);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(157, 44);
            ExitButton.TabIndex = 14;
            ExitButton.Text = "Exit Game";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += exitButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(NewGamebtn);
            Controls.Add(ResetButton);
            Controls.Add(RoundLabel);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label RoundLabel;
        private Button NewGamebtn;
        private Button ResetButton;
        private Button ExitButton;
    }
}
