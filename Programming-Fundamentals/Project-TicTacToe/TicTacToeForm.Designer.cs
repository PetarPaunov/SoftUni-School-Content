namespace TicTacToe
{
    partial class ticTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticTacToeForm));
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            resources.ApplyResources(this.buttonsPanel, "buttonsPanel");
            this.buttonsPanel.Name = "buttonsPanel";
            // 
            // playerLabel
            // 
            resources.ApplyResources(this.playerLabel, "playerLabel");
            this.playerLabel.Name = "playerLabel";
            // 
            // playerButton
            // 
            resources.ApplyResources(this.playerButton, "playerButton");
            this.playerButton.Name = "playerButton";
            this.playerButton.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            resources.ApplyResources(this.restartButton, "restartButton");
            this.restartButton.Name = "restartButton";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // ticTacToeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.buttonsPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ticTacToeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel buttonsPanel;
        private Label playerLabel;
        private Button playerButton;
        private Button restartButton;
    }
}