namespace GUI_Currency_Converter
{
    partial class ConversionForm
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
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resultLable = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(12, 24);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.amountNumericUpDown.Name = "amount";
            this.amountNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.amountNumericUpDown.TabIndex = 0;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resultLable
            // 
            this.resultLable.BackColor = System.Drawing.Color.PaleGreen;
            this.resultLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLable.Location = new System.Drawing.Point(12, 70);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(358, 29);
            this.resultLable.TabIndex = 1;
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(279, 27);
            this.label.Name = "label2";
            this.label.Size = new System.Drawing.Size(94, 18);
            this.label.TabIndex = 2;
            this.label.Text = "BGN to EUR";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(176, 23);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(94, 29);
            this.resultButton.TabIndex = 3;
            this.resultButton.Text = "Convert";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ConvertCurrency);
            // 
            // ConvertionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 117);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.amountNumericUpDown);
            this.Name = "ConvertionForm";
            this.Text = "CurrencyConverterByPeter";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown amountNumericUpDown;
        private Label resultLable;
        private Label label;
        private Button resultButton;
    }
}