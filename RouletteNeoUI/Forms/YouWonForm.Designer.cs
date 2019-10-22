namespace RouletteNeoUI.Forms
{
    partial class YouWonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouWonForm));
            this.congratzUserLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.youWonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // congratzUserLabel
            // 
            this.congratzUserLabel.AutoSize = true;
            this.congratzUserLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.congratzUserLabel.ForeColor = System.Drawing.Color.Blue;
            this.congratzUserLabel.Location = new System.Drawing.Point(12, 9);
            this.congratzUserLabel.Name = "congratzUserLabel";
            this.congratzUserLabel.Size = new System.Drawing.Size(213, 20);
            this.congratzUserLabel.TabIndex = 254;
            this.congratzUserLabel.Text = "Congratulations <Username>";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playAgainButton.Location = new System.Drawing.Point(103, 166);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(157, 46);
            this.playAgainButton.TabIndex = 253;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // youWonLabel
            // 
            this.youWonLabel.AutoSize = true;
            this.youWonLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.youWonLabel.ForeColor = System.Drawing.Color.Green;
            this.youWonLabel.Location = new System.Drawing.Point(67, 79);
            this.youWonLabel.Name = "youWonLabel";
            this.youWonLabel.Size = new System.Drawing.Size(140, 37);
            this.youWonLabel.TabIndex = 252;
            this.youWonLabel.Text = "You Won!";
            // 
            // YouWonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(275, 229);
            this.Controls.Add(this.congratzUserLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.youWonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YouWonForm";
            this.Text = "YouWonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label congratzUserLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label youWonLabel;
    }
}