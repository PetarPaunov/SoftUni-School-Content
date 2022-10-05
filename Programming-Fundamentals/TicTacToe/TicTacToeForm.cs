namespace TicTacToe
{
    public partial class ticTacToeForm : Form
    {
        public ticTacToeForm()
        {
            InitializeComponent();
            GenerateButtons();
        }

        Button[,] buttons = new Button[3, 3];

        private void GenerateButtons()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    buttons[row, col] = new Button();
                    buttons[row, col].Size = new Size(175, 175);
                    buttons[row, col].Location = new Point(row * 175, col * 175);
                    buttons[row, col].FlatStyle = FlatStyle.Flat;
                    buttons[row, col].Font = new Font(DefaultFont.FontFamily, 80, FontStyle.Bold);

                    // Define button click event
                    buttons[row, col].Click += new EventHandler(OnButtonClick);

                    // Add button to the panel
                    this.buttonsPanel.Controls.Add(buttons[row, col]);
                }
            }
        }

        void OnButtonClick(object sender, EventArgs e)
        {
            // Load the clicked button into a local variable
            Button button = sender as Button;

            // Don't do anything if the block is already marked
            if (button.Text != "")
            {
                return;
            }

            // Mark the block with current players icon
            button.Text = this.playerButton.Text;

            TogglePlayer();
        }

        private void TogglePlayer()
        {
            CheckIfGameEnds();

            if (this.playerButton.Text == "X")
            {
                this.playerButton.Text = "O";
            }
            else
            {
                this.playerButton.Text = "X";
            }
        }

        private void CheckIfGameEnds()
        {
            List<Button> winnerButtons = new List<Button>();
            // vertically
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttons[row, col].Text != this.playerButton.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[row, col]);
                    if (col == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }

            //horizontally
            winnerButtons.Clear();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttons[col, row].Text != this.playerButton.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[col, row]);
                    if (col == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }

            //diagonally 1 (top-left to bottom-right)
            winnerButtons.Clear();
            for (int row = 0, col = 0; row < 3; row++, col++)
            {
                if (buttons[row, col].Text != this.playerButton.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[row, col]);
                if (col == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }

            //diagonally 2 (bottom-left to top-right)
            winnerButtons.Clear();
            for (int row = 2, col = 0; col < 3; row--, col++)
            {
                if (buttons[row, col].Text != this.playerButton.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[row, col]);
                if (col == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }

            // check if all the blocks are marked
            foreach (var button in buttons)
            {
                if (button.Text == "")
                    return;
            }

            MessageBox.Show("Game Draw");
            Application.Restart();
        }

        private void ShowWinner(List<Button> winnerButtons)
        {
            // color all the winner blocks
            foreach (var button in winnerButtons)
            {
                button.BackColor = Color.LightGreen;
            }

            MessageBox.Show("Player " + this.playerButton.Text + " wins");
            Application.Restart();
        }

        private void GameRestart(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}