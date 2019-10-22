namespace RouletteNeoUI.Forms
{
    partial class SessionStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionStartForm));
            this.startButton = new System.Windows.Forms.Button();
            this.betUnitLabel = new System.Windows.Forms.Label();
            this.betUnitValue = new System.Windows.Forms.TextBox();
            this.startingMoneyValue = new System.Windows.Forms.TextBox();
            this.startingMoneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(60, 100);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(165, 42);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // betUnitLabel
            // 
            this.betUnitLabel.AutoSize = true;
            this.betUnitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betUnitLabel.Location = new System.Drawing.Point(18, 55);
            this.betUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betUnitLabel.Name = "betUnitLabel";
            this.betUnitLabel.Size = new System.Drawing.Size(68, 21);
            this.betUnitLabel.TabIndex = 18;
            this.betUnitLabel.Text = "Bet Unit:";
            // 
            // betUnitValue
            // 
            this.betUnitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betUnitValue.Location = new System.Drawing.Point(145, 52);
            this.betUnitValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.betUnitValue.Name = "betUnitValue";
            this.betUnitValue.Size = new System.Drawing.Size(114, 29);
            this.betUnitValue.TabIndex = 17;
            this.betUnitValue.Text = "1,00";
            this.betUnitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startingMoneyValue
            // 
            this.startingMoneyValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startingMoneyValue.Location = new System.Drawing.Point(145, 15);
            this.startingMoneyValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startingMoneyValue.Name = "startingMoneyValue";
            this.startingMoneyValue.Size = new System.Drawing.Size(114, 29);
            this.startingMoneyValue.TabIndex = 16;
            this.startingMoneyValue.Text = "2000,00";
            this.startingMoneyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startingMoneyLabel
            // 
            this.startingMoneyLabel.AutoSize = true;
            this.startingMoneyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startingMoneyLabel.Location = new System.Drawing.Point(18, 18);
            this.startingMoneyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingMoneyLabel.Name = "startingMoneyLabel";
            this.startingMoneyLabel.Size = new System.Drawing.Size(119, 21);
            this.startingMoneyLabel.TabIndex = 15;
            this.startingMoneyLabel.Text = "Starting money:";
            // 
            // SessionStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(276, 160);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.betUnitLabel);
            this.Controls.Add(this.betUnitValue);
            this.Controls.Add(this.startingMoneyValue);
            this.Controls.Add(this.startingMoneyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SessionStartForm";
            this.Text = "START";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label betUnitLabel;
        private System.Windows.Forms.TextBox betUnitValue;
        private System.Windows.Forms.TextBox startingMoneyValue;
        private System.Windows.Forms.Label startingMoneyLabel;
    }
}