namespace TrackerUI
{
    partial class TournamentViewerForm
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
            TournamentLabel = new Label();
            TournamentNameLabel = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            uplayedOnlyCheckBox = new CheckBox();
            matchUpListBox = new ListBox();
            teamOneLabel = new Label();
            scoreLabel = new Label();
            teamOneScoreBox = new TextBox();
            teamTwoScoreBox = new TextBox();
            teamTwoScore = new Label();
            teamTwoLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentLabel.Location = new Point(39, 49);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(213, 47);
            TournamentLabel.TabIndex = 0;
            TournamentLabel.Text = "Tournament :";
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentNameLabel.Location = new Point(247, 49);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(147, 47);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            roundLabel.Location = new Point(39, 118);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FlatStyle = FlatStyle.Flat;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(156, 121);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(238, 38);
            roundDropDown.TabIndex = 3;
            // 
            // uplayedOnlyCheckBox
            // 
            uplayedOnlyCheckBox.AutoSize = true;
            uplayedOnlyCheckBox.ForeColor = Color.FromArgb(51, 153, 255);
            uplayedOnlyCheckBox.Location = new Point(204, 199);
            uplayedOnlyCheckBox.Name = "uplayedOnlyCheckBox";
            uplayedOnlyCheckBox.Size = new Size(168, 34);
            uplayedOnlyCheckBox.TabIndex = 4;
            uplayedOnlyCheckBox.Text = "Unplayed Only";
            uplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            matchUpListBox.FormattingEnabled = true;
            matchUpListBox.ItemHeight = 30;
            matchUpListBox.Location = new Point(39, 267);
            matchUpListBox.Name = "matchUpListBox";
            matchUpListBox.Size = new Size(355, 214);
            matchUpListBox.TabIndex = 5;
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneLabel.Location = new Point(454, 267);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(129, 30);
            teamOneLabel.TabIndex = 6;
            teamOneLabel.Text = "<team one>";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            scoreLabel.Location = new Point(454, 312);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(64, 30);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "Score";
            // 
            // teamOneScoreBox
            // 
            teamOneScoreBox.Location = new Point(524, 309);
            teamOneScoreBox.Name = "teamOneScoreBox";
            teamOneScoreBox.Size = new Size(100, 35);
            teamOneScoreBox.TabIndex = 8;
            // 
            // teamTwoScoreBox
            // 
            teamTwoScoreBox.Location = new Point(524, 430);
            teamTwoScoreBox.Name = "teamTwoScoreBox";
            teamTwoScoreBox.Size = new Size(100, 35);
            teamTwoScoreBox.TabIndex = 11;
            // 
            // teamTwoScore
            // 
            teamTwoScore.AutoSize = true;
            teamTwoScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScore.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoScore.Location = new Point(454, 433);
            teamTwoScore.Name = "teamTwoScore";
            teamTwoScore.Size = new Size(64, 30);
            teamTwoScore.TabIndex = 10;
            teamTwoScore.Text = "Score";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoLabel.Location = new Point(454, 388);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(128, 30);
            teamTwoLabel.TabIndex = 9;
            teamTwoLabel.Text = "<team two>";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            scoreButton.Location = new Point(631, 367);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(104, 40);
            scoreButton.TabIndex = 12;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(747, 560);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoScoreBox);
            Controls.Add(teamTwoScore);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreBox);
            Controls.Add(scoreLabel);
            Controls.Add(teamOneLabel);
            Controls.Add(matchUpListBox);
            Controls.Add(uplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(TournamentNameLabel);
            Controls.Add(TournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLabel;
        private Label TournamentNameLabel;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox uplayedOnlyCheckBox;
        private ListBox matchUpListBox;
        private Label teamOneLabel;
        private Label scoreLabel;
        private TextBox teamOneScoreBox;
        private TextBox teamTwoScoreBox;
        private Label teamTwoScore;
        private Label teamTwoLabel;
        private Button scoreButton;
    }
}