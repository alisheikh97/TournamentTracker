namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            TournamentLabel = new Label();
            tournamentValue = new TextBox();
            tournamentName = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            teamPlayerLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            label1 = new Label();
            prizeListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentLabel.Location = new Point(24, 23);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(301, 47);
            TournamentLabel.TabIndex = 1;
            TournamentLabel.Text = "Create Tournament";
            // 
            // tournamentValue
            // 
            tournamentValue.Location = new Point(61, 152);
            tournamentValue.Name = "tournamentValue";
            tournamentValue.Size = new Size(338, 35);
            tournamentValue.TabIndex = 10;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentName.Location = new Point(61, 101);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(245, 37);
            tournamentName.TabIndex = 9;
            tournamentName.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(178, 217);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(116, 35);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(61, 220);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(98, 30);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(42, 427);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(338, 38);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(42, 387);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(161, 37);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLink.Location = new Point(249, 400);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(131, 21);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New Team";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(87, 488);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(246, 40);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(87, 558);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(246, 40);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(432, 105);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(269, 154);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // teamPlayerLabel
            // 
            teamPlayerLabel.AutoSize = true;
            teamPlayerLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            teamPlayerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamPlayerLabel.Location = new Point(432, 53);
            teamPlayerLabel.Name = "teamPlayerLabel";
            teamPlayerLabel.Size = new Size(205, 37);
            teamPlayerLabel.TabIndex = 19;
            teamPlayerLabel.Text = "Teams / Players";
            teamPlayerLabel.Click += label1_Click;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPlayerButton.Location = new Point(445, 286);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(246, 40);
            deleteSelectedPlayerButton.TabIndex = 20;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPrizeButton.Location = new Point(445, 568);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(246, 40);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(51, 153, 255);
            label1.Location = new Point(432, 335);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 22;
            label1.Text = "Teams / Players";
            // 
            // prizeListBox
            // 
            prizeListBox.FormattingEnabled = true;
            prizeListBox.ItemHeight = 30;
            prizeListBox.Location = new Point(432, 387);
            prizeListBox.Name = "prizeListBox";
            prizeListBox.Size = new Size(269, 154);
            prizeListBox.TabIndex = 21;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(51, 153, 255);
            button1.Location = new Point(249, 654);
            button1.Name = "button1";
            button1.Size = new Size(246, 59);
            button1.TabIndex = 24;
            button1.Text = "Create Tournament";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 749);
            Controls.Add(button1);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(label1);
            Controls.Add(prizeListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(teamPlayerLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentValue);
            Controls.Add(tournamentName);
            Controls.Add(TournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLabel;
        private TextBox tournamentValue;
        private Label tournamentName;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label teamPlayerLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label label1;
        private ListBox prizeListBox;
        private Button button1;
    }
}