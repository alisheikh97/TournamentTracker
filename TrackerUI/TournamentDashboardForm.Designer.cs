namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            tournamentDashboardLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentTable = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentDashboardLabel.Location = new Point(85, 57);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(367, 47);
            tournamentDashboardLabel.TabIndex = 13;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(85, 205);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(367, 38);
            loadExistingTournamentDropDown.TabIndex = 15;
            // 
            // loadExistingTournamentTable
            // 
            loadExistingTournamentTable.AutoSize = true;
            loadExistingTournamentTable.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentTable.ForeColor = Color.FromArgb(51, 153, 255);
            loadExistingTournamentTable.Location = new Point(111, 146);
            loadExistingTournamentTable.Name = "loadExistingTournamentTable";
            loadExistingTournamentTable.Size = new Size(322, 37);
            loadExistingTournamentTable.TabIndex = 14;
            loadExistingTournamentTable.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            loadTournamentButton.Location = new Point(138, 274);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(246, 43);
            loadTournamentButton.TabIndex = 31;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(111, 360);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(305, 106);
            createTournamentButton.TabIndex = 32;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(537, 536);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentTable);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentTable;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}