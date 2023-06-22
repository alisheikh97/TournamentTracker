namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new TextBox();
            createTeamLabel = new Label();
            selectTeamLabel = new Label();
            selectTeamBox = new ComboBox();
            addMemberButton = new Button();
            teamNameLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneLabel = new Label();
            cellPhoneValue = new TextBox();
            emailLabel = new Label();
            emailValue = new TextBox();
            lastNameLabel = new Label();
            lastNameValue = new TextBox();
            firstNameLabel = new Label();
            firstNameValue = new TextBox();
            teamMemeberListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(33, 128);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(338, 35);
            teamNameValue.TabIndex = 13;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new Point(33, 20);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(202, 47);
            createTeamLabel.TabIndex = 11;
            createTeamLabel.Text = "Create Team";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(33, 197);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(271, 37);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team Member";
            // 
            // selectTeamBox
            // 
            selectTeamBox.FormattingEnabled = true;
            selectTeamBox.Location = new Point(33, 253);
            selectTeamBox.Name = "selectTeamBox";
            selectTeamBox.Size = new Size(338, 38);
            selectTeamBox.TabIndex = 15;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new Point(114, 306);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(190, 40);
            addMemberButton.TabIndex = 17;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(33, 79);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(161, 37);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellPhoneLabel);
            addNewMemberGroupBox.Controls.Add(cellPhoneValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Location = new Point(33, 392);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(338, 410);
            addNewMemberGroupBox.TabIndex = 18;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(81, 333);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(190, 40);
            createMemberButton.TabIndex = 19;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellPhoneLabel.Location = new Point(19, 268);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(106, 30);
            cellPhoneLabel.TabIndex = 25;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new Point(138, 265);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(171, 35);
            cellPhoneValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(19, 196);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(138, 193);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(171, 35);
            emailValue.TabIndex = 24;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(18, 127);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 30);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(137, 124);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(171, 35);
            lastNameValue.TabIndex = 22;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(18, 55);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(113, 30);
            firstNameLabel.TabIndex = 19;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(137, 52);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(171, 35);
            firstNameValue.TabIndex = 20;
            // 
            // teamMemeberListBox
            // 
            teamMemeberListBox.FormattingEnabled = true;
            teamMemeberListBox.ItemHeight = 30;
            teamMemeberListBox.Location = new Point(418, 128);
            teamMemeberListBox.Name = "teamMemeberListBox";
            teamMemeberListBox.Size = new Size(261, 664);
            teamMemeberListBox.TabIndex = 19;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedMemberButton.Location = new Point(702, 327);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(150, 78);
            deleteSelectedMemberButton.TabIndex = 20;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(332, 821);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(246, 59);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 912);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMemeberListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(51, 153, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label createTeamLabel;
        private Label selectTeamLabel;
        private ComboBox selectTeamBox;
        private Button addMemberButton;
        private Label teamNameLabel;
        private GroupBox addNewMemberGroupBox;
        private Label lastNameLabel;
        private TextBox lastNameValue;
        private Label firstNameLabel;
        private TextBox firstNameValue;
        private Button createMemberButton;
        private Label cellPhoneLabel;
        private TextBox cellPhoneValue;
        private Label emailLabel;
        private TextBox emailValue;
        private ListBox teamMemeberListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}