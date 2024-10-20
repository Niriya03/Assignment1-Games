namespace Assignment1_Games
{
    public partial class Form1 : Form
    {

        private bool isXTurn = true;
        private int roundNumber = 1;

        public Form1()
        {
            InitializeComponent();
            roundLabel();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // If the button is blank (meaning no one has played on it yet), we allow the move
            if (button.Text == "")
            {
                if (isXTurn)
                {
                    button.Text = "X";             // Player X's turn
                    button.ForeColor = Color.Red;  // Choosing red color for X
                }
                else
                {
                    button.Text = "O";              // Player O's turn
                    button.ForeColor = Color.Blue;  // Choosing blue color for O
                }

                isXTurn = !isXTurn;  // Switch turns

                CheckForWinner();
            }
        }

        // This checks if someone has won after every move
        private void CheckForWinner()
        {
            // Check all rows, columns, and diagonals for a winner
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||
                (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
            {
                string winner = isXTurn ? "O" : "X";  // Determine the winner
                MessageBox.Show($"Player {winner} wins in Round {roundNumber}!", "Game Over");
                NextRound();  // Start a fresh round after a win
            }
            else if (AllButtonsFilled())  // Check for a draw
            {
                MessageBox.Show($"It's a draw in Round {roundNumber}!", "Game Over");
                ResetBoard();  // Reset the board for a new game
            }
        }

        // Method to check if all buttons are filled (so we know if it's a draw)
        private bool AllButtonsFilled()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Text == "")
                {
                    return false;  // If any button is empty, it's not a draw
                }
            }
            return true;  // All buttons are filled
        }

        // Method to reset the board and move to the next round
        private void NextRound()
        {
            ResetBoard();
            roundNumber++;  // Increment the round number
            roundLabel();   // Update the displayed round number
        }

        // Method to reset the board
        private void ResetBoard()
        {
            foreach (Control c in this.Controls)
            {
                // Loop through all the controls and clear the text on the Tic-Tac-Toe buttons only
                if (c is Button && (c.Name == "button1" || c.Name == "button2" || c.Name == "button3" ||
                                    c.Name == "button4" || c.Name == "button5" || c.Name == "button6" ||
                                    c.Name == "button7" || c.Name == "button8" || c.Name == "button9"))
                {
                    c.Text = "";  // Clear text for these buttons only
                }
            }
            isXTurn = true;  // Reset the turn to Player X
        }

        private void roundLabel()
        {
            RoundLabel.Text = $"Round: {roundNumber}";  // Display the round number on the form
        }

        private void resetButton(object sender, EventArgs e)
        {
            ResetBoard(); // Reset the current round without changing the round number
        }

        private void newGameButton(object sender, EventArgs e)
        {
            roundNumber = 1;  // Reset the round number to 1
            roundLabel();     // Update the round label to show "Round: 1"
            ResetBoard();     // Clear the board
        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close(); // Close the current game form (this exits the game)
        }
    }
}
       
