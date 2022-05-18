namespace CurencyConverter
{
    partial class ConverterForm
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
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.curency = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.DecimalPlaces = 2;
            this.amount.Location = new System.Drawing.Point(27, 25);
            this.amount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amount.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(94, 22);
            this.amount.TabIndex = 0;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // curency
            // 
            this.curency.AutoSize = true;
            this.curency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.curency.Location = new System.Drawing.Point(131, 27);
            this.curency.Name = "curency";
            this.curency.Size = new System.Drawing.Size(94, 18);
            this.curency.TabIndex = 1;
            this.curency.Text = "BGN to EUR";
            // 
            // resultLable
            // 
            this.resultLable.BackColor = System.Drawing.Color.PaleGreen;
            this.resultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.ForeColor = System.Drawing.Color.Black;
            this.resultLable.Location = new System.Drawing.Point(27, 66);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(326, 36);
            this.resultLable.TabIndex = 4;
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.resultButton.Location = new System.Drawing.Point(278, 18);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 35);
            this.resultButton.TabIndex = 5;
            this.resultButton.Text = "Convert";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 123);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.curency);
            this.Controls.Add(this.amount);
            this.MaximumSize = new System.Drawing.Size(400, 170);
            this.MinimumSize = new System.Drawing.Size(400, 170);
            this.Name = "ConverterForm";
            this.Text = "CurencyConverter";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Label curency;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Button resultButton;
    }
}

