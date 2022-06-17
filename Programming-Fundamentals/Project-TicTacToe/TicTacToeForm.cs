namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
            GenerateButtons();
        }

        Button[,] buttons = new Button[3, 3];

        private void GenerateButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(175, 175);
                    buttons[i, j].Location = new Point(i * 175, j * 175);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new Font(DefaultFont.FontFamily, 80, FontStyle.Bold);

                    // Define button click event
                    buttons[i, j].Click += new EventHandler(button_Click);

                    // Add button in to the panel
                    this.buttonsPanel.Controls.Add(buttons[i, j]);
                }
            }
        }

        void button_Click(object sender, EventArgs e)
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
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();

                
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != this.playerButton.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[i, j]);
                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }
            //horizontally
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[j, i].Text != this.playerButton.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[j, i]);
                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }
            //diagonally 1 (top-left to bottom-right)

            winnerButtons = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (buttons[i, j].Text != this.playerButton.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }
            //diagonally 2 (bottom-left to top-right)
            winnerButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i, j].Text != this.playerButton.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
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

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}