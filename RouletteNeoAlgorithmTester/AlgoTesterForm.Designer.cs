namespace RouletteNeoAlgorithmTester
{
    partial class AlgoTesterForm
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
            this.resetButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.tb_A2_NH_Distance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.tb_OneBetUnit = new System.Windows.Forms.TextBox();
            this.tb_ExcludeLast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.tb_SessionStart = new System.Windows.Forms.TextBox();
            this.tb_numberOfSessions = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.tb_A3_HappToAVG = new System.Windows.Forms.TextBox();
            this.tb_WinLoseTreshold = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.tb_StartingMoney = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.tb_A1_NH_Distance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_A3_AvgHappAlgo = new System.Windows.Forms.CheckBox();
            this.checkBox_A2_AvgGapAlgo = new System.Windows.Forms.CheckBox();
            this.checkBox_A1_NumGapAlgo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetButton.Location = new System.Drawing.Point(261, 23);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 56);
            this.resetButton.TabIndex = 220;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 102);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(369, 25);
            this.progressBar.TabIndex = 219;
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.outcomeLabel.Location = new System.Drawing.Point(8, 498);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(174, 23);
            this.outcomeLabel.TabIndex = 218;
            this.outcomeLabel.Text = "won (%) ? - ? (%) lost";
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testButton.Location = new System.Drawing.Point(12, 428);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(369, 56);
            this.testButton.TabIndex = 217;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // tb_A2_NH_Distance
            // 
            this.tb_A2_NH_Distance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_A2_NH_Distance.Location = new System.Drawing.Point(288, 172);
            this.tb_A2_NH_Distance.Name = "tb_A2_NH_Distance";
            this.tb_A2_NH_Distance.Size = new System.Drawing.Size(92, 26);
            this.tb_A2_NH_Distance.TabIndex = 216;
            this.tb_A2_NH_Distance.Text = "7";
            this.tb_A2_NH_Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 215;
            this.label1.Text = "A2 Not-Happ to App AVG distance:";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label129.Location = new System.Drawing.Point(9, 335);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(146, 18);
            this.label129.TabIndex = 214;
            this.label129.Text = "One bet unit (money):";
            // 
            // tb_OneBetUnit
            // 
            this.tb_OneBetUnit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_OneBetUnit.Location = new System.Drawing.Point(289, 332);
            this.tb_OneBetUnit.Name = "tb_OneBetUnit";
            this.tb_OneBetUnit.Size = new System.Drawing.Size(92, 26);
            this.tb_OneBetUnit.TabIndex = 213;
            this.tb_OneBetUnit.Text = "1,00";
            this.tb_OneBetUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ExcludeLast
            // 
            this.tb_ExcludeLast.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ExcludeLast.Location = new System.Drawing.Point(288, 236);
            this.tb_ExcludeLast.Name = "tb_ExcludeLast";
            this.tb_ExcludeLast.Size = new System.Drawing.Size(92, 26);
            this.tb_ExcludeLast.TabIndex = 212;
            this.tb_ExcludeLast.Text = "0";
            this.tb_ExcludeLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 199;
            this.label4.Text = "How many roulette sessions?";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label123.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label123.Location = new System.Drawing.Point(8, 239);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(182, 18);
            this.label123.TabIndex = 211;
            this.label123.Text = "Exclude last (0-12) numbers:";
            // 
            // tb_SessionStart
            // 
            this.tb_SessionStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_SessionStart.Location = new System.Drawing.Point(288, 268);
            this.tb_SessionStart.Name = "tb_SessionStart";
            this.tb_SessionStart.Size = new System.Drawing.Size(92, 26);
            this.tb_SessionStart.TabIndex = 210;
            this.tb_SessionStart.Text = "56";
            this.tb_SessionStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_numberOfSessions
            // 
            this.tb_numberOfSessions.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_numberOfSessions.Location = new System.Drawing.Point(289, 396);
            this.tb_numberOfSessions.Name = "tb_numberOfSessions";
            this.tb_numberOfSessions.Size = new System.Drawing.Size(92, 26);
            this.tb_numberOfSessions.TabIndex = 200;
            this.tb_numberOfSessions.Text = "10000";
            this.tb_numberOfSessions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_numberOfSessions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_numberOfSessions_KeyDown);
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label122.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label122.Location = new System.Drawing.Point(8, 271);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(196, 18);
            this.label122.TabIndex = 209;
            this.label122.Text = "Session start at (spin number):";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label116.Location = new System.Drawing.Point(9, 367);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(263, 18);
            this.label116.TabIndex = 205;
            this.label116.Text = "Win/Lose treshold (one bet unit times X):";
            // 
            // tb_A3_HappToAVG
            // 
            this.tb_A3_HappToAVG.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_A3_HappToAVG.Location = new System.Drawing.Point(288, 204);
            this.tb_A3_HappToAVG.Name = "tb_A3_HappToAVG";
            this.tb_A3_HappToAVG.Size = new System.Drawing.Size(92, 26);
            this.tb_A3_HappToAVG.TabIndex = 208;
            this.tb_A3_HappToAVG.Text = "0";
            this.tb_A3_HappToAVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_WinLoseTreshold
            // 
            this.tb_WinLoseTreshold.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_WinLoseTreshold.Location = new System.Drawing.Point(289, 364);
            this.tb_WinLoseTreshold.Name = "tb_WinLoseTreshold";
            this.tb_WinLoseTreshold.Size = new System.Drawing.Size(92, 26);
            this.tb_WinLoseTreshold.TabIndex = 206;
            this.tb_WinLoseTreshold.Text = "100";
            this.tb_WinLoseTreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label117.Location = new System.Drawing.Point(9, 207);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(188, 18);
            this.label117.TabIndex = 207;
            this.label117.Text = "A3 Number Happ : Happ AVG:";
            // 
            // tb_StartingMoney
            // 
            this.tb_StartingMoney.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_StartingMoney.Location = new System.Drawing.Point(289, 300);
            this.tb_StartingMoney.Name = "tb_StartingMoney";
            this.tb_StartingMoney.Size = new System.Drawing.Size(92, 26);
            this.tb_StartingMoney.TabIndex = 204;
            this.tb_StartingMoney.Text = "2000,00";
            this.tb_StartingMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label115.Location = new System.Drawing.Point(9, 303);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(105, 18);
            this.label115.TabIndex = 203;
            this.label115.Text = "Starting money:";
            // 
            // tb_A1_NH_Distance
            // 
            this.tb_A1_NH_Distance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_A1_NH_Distance.Location = new System.Drawing.Point(288, 140);
            this.tb_A1_NH_Distance.Name = "tb_A1_NH_Distance";
            this.tb_A1_NH_Distance.Size = new System.Drawing.Size(92, 26);
            this.tb_A1_NH_Distance.TabIndex = 202;
            this.tb_A1_NH_Distance.Text = "7";
            this.tb_A1_NH_Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 18);
            this.label5.TabIndex = 201;
            this.label5.Text = "A1 Not-Happ to number AVG distance:";
            // 
            // checkBox_A3_AvgHappAlgo
            // 
            this.checkBox_A3_AvgHappAlgo.AutoSize = true;
            this.checkBox_A3_AvgHappAlgo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_A3_AvgHappAlgo.Location = new System.Drawing.Point(12, 67);
            this.checkBox_A3_AvgHappAlgo.Name = "checkBox_A3_AvgHappAlgo";
            this.checkBox_A3_AvgHappAlgo.Size = new System.Drawing.Size(207, 22);
            this.checkBox_A3_AvgHappAlgo.TabIndex = 198;
            this.checkBox_A3_AvgHappAlgo.Text = "Average Happ Algorithm (A3)";
            this.checkBox_A3_AvgHappAlgo.UseVisualStyleBackColor = true;
            // 
            // checkBox_A2_AvgGapAlgo
            // 
            this.checkBox_A2_AvgGapAlgo.AutoSize = true;
            this.checkBox_A2_AvgGapAlgo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_A2_AvgGapAlgo.Location = new System.Drawing.Point(12, 40);
            this.checkBox_A2_AvgGapAlgo.Name = "checkBox_A2_AvgGapAlgo";
            this.checkBox_A2_AvgGapAlgo.Size = new System.Drawing.Size(199, 22);
            this.checkBox_A2_AvgGapAlgo.TabIndex = 197;
            this.checkBox_A2_AvgGapAlgo.Text = "Average Gap Algorithm (A2)";
            this.checkBox_A2_AvgGapAlgo.UseVisualStyleBackColor = true;
            // 
            // checkBox_A1_NumGapAlgo
            // 
            this.checkBox_A1_NumGapAlgo.AutoSize = true;
            this.checkBox_A1_NumGapAlgo.Checked = true;
            this.checkBox_A1_NumGapAlgo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_A1_NumGapAlgo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_A1_NumGapAlgo.Location = new System.Drawing.Point(12, 12);
            this.checkBox_A1_NumGapAlgo.Name = "checkBox_A1_NumGapAlgo";
            this.checkBox_A1_NumGapAlgo.Size = new System.Drawing.Size(199, 22);
            this.checkBox_A1_NumGapAlgo.TabIndex = 196;
            this.checkBox_A1_NumGapAlgo.Text = "Number Gap Algorithm (A1)";
            this.checkBox_A1_NumGapAlgo.UseVisualStyleBackColor = true;
            // 
            // AlgoTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(397, 539);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.tb_A2_NH_Distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label129);
            this.Controls.Add(this.tb_OneBetUnit);
            this.Controls.Add(this.tb_ExcludeLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.tb_SessionStart);
            this.Controls.Add(this.tb_numberOfSessions);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.tb_A3_HappToAVG);
            this.Controls.Add(this.tb_WinLoseTreshold);
            this.Controls.Add(this.label117);
            this.Controls.Add(this.tb_StartingMoney);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.tb_A1_NH_Distance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_A3_AvgHappAlgo);
            this.Controls.Add(this.checkBox_A2_AvgGapAlgo);
            this.Controls.Add(this.checkBox_A1_NumGapAlgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlgoTesterForm";
            this.Text = "Algorithm Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox tb_A2_NH_Distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.TextBox tb_OneBetUnit;
        private System.Windows.Forms.TextBox tb_ExcludeLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox tb_SessionStart;
        private System.Windows.Forms.TextBox tb_numberOfSessions;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox tb_A3_HappToAVG;
        private System.Windows.Forms.TextBox tb_WinLoseTreshold;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox tb_StartingMoney;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox tb_A1_NH_Distance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_A3_AvgHappAlgo;
        private System.Windows.Forms.CheckBox checkBox_A2_AvgGapAlgo;
        private System.Windows.Forms.CheckBox checkBox_A1_NumGapAlgo;
    }
}

