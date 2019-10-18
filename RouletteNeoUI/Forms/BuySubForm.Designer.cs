namespace RouletteNeoUI.Forms
{
    partial class BuySubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuySubForm));
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearButton = new System.Windows.Forms.Button();
            this.sixMonthsLabel = new System.Windows.Forms.Label();
            this.sixMonthButton = new System.Windows.Forms.Button();
            this.oneMonthButton = new System.Windows.Forms.Button();
            this.purchaseSubscriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearLabel.Location = new System.Drawing.Point(40, 311);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(225, 17);
            this.yearLabel.TabIndex = 17;
            this.yearLabel.Text = "(12 months at $4.2/month, Save 30%)";
            // 
            // yearButton
            // 
            this.yearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearButton.Location = new System.Drawing.Point(73, 269);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(158, 39);
            this.yearButton.TabIndex = 16;
            this.yearButton.Text = "$50.32 / 12 months";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // sixMonthsLabel
            // 
            this.sixMonthsLabel.AutoSize = true;
            this.sixMonthsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixMonthsLabel.Location = new System.Drawing.Point(40, 229);
            this.sixMonthsLabel.Name = "sixMonthsLabel";
            this.sixMonthsLabel.Size = new System.Drawing.Size(218, 17);
            this.sixMonthsLabel.TabIndex = 15;
            this.sixMonthsLabel.Text = "(6 months at $5.1/month, Save 15%)";
            // 
            // sixMonthButton
            // 
            this.sixMonthButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixMonthButton.Location = new System.Drawing.Point(73, 187);
            this.sixMonthButton.Name = "sixMonthButton";
            this.sixMonthButton.Size = new System.Drawing.Size(158, 39);
            this.sixMonthButton.TabIndex = 14;
            this.sixMonthButton.Text = "$30.55 / 6 months";
            this.sixMonthButton.UseVisualStyleBackColor = true;
            // 
            // oneMonthButton
            // 
            this.oneMonthButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneMonthButton.Location = new System.Drawing.Point(73, 105);
            this.oneMonthButton.Name = "oneMonthButton";
            this.oneMonthButton.Size = new System.Drawing.Size(158, 39);
            this.oneMonthButton.TabIndex = 13;
            this.oneMonthButton.Text = "$5.99 / 1 month";
            this.oneMonthButton.UseVisualStyleBackColor = true;
            // 
            // purchaseSubscriptionLabel
            // 
            this.purchaseSubscriptionLabel.AutoSize = true;
            this.purchaseSubscriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.purchaseSubscriptionLabel.Location = new System.Drawing.Point(11, 24);
            this.purchaseSubscriptionLabel.Name = "purchaseSubscriptionLabel";
            this.purchaseSubscriptionLabel.Size = new System.Drawing.Size(283, 37);
            this.purchaseSubscriptionLabel.TabIndex = 12;
            this.purchaseSubscriptionLabel.Text = "Purchase Subscription";
            // 
            // BuySubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(304, 365);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.sixMonthsLabel);
            this.Controls.Add(this.sixMonthButton);
            this.Controls.Add(this.oneMonthButton);
            this.Controls.Add(this.purchaseSubscriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuySubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Label sixMonthsLabel;
        private System.Windows.Forms.Button sixMonthButton;
        private System.Windows.Forms.Button oneMonthButton;
        private System.Windows.Forms.Label purchaseSubscriptionLabel;
    }
}