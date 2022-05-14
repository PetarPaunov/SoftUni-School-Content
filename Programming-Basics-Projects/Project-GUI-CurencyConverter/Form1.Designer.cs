namespace CurencyConverter
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.DecimalPlaces = 2;
            this.amount.Location = new System.Drawing.Point(124, 20);
            this.amount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(94, 22);
            this.amount.TabIndex = 0;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // curency
            // 
            this.curency.AutoSize = true;
            this.curency.Location = new System.Drawing.Point(224, 22);
            this.curency.Name = "curency";
            this.curency.Size = new System.Drawing.Size(87, 17);
            this.curency.TabIndex = 1;
            this.curency.Text = "BGN to EUR";
            this.curency.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(65, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 17);
            this.name.TabIndex = 3;
            this.name.Text = "Convert";
            // 
            // resultLable
            // 
            this.resultLable.BackColor = System.Drawing.Color.PaleGreen;
            this.resultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.ForeColor = System.Drawing.Color.Black;
            this.resultLable.Location = new System.Drawing.Point(27, 58);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(326, 36);
            this.resultLable.TabIndex = 4;
            this.resultLable.Click += new System.EventHandler(this.resultLable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 123);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.name);
            this.Controls.Add(this.curency);
            this.Controls.Add(this.amount);
            this.Name = "Form1";
            this.Text = "CurencyConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Label curency;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label resultLable;
    }
}

