namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            createPrizeLabel = new Label();
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            prizeAmountLabel = new Label();
            priceAmountValue = new TextBox();
            pricePercentage = new Label();
            pricePercentageValue = new TextBox();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new Point(34, 40);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(198, 47);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(65, 121);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(144, 30);
            placeNumberLabel.TabIndex = 21;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(215, 116);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(217, 35);
            placeNumberValue.TabIndex = 22;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(65, 186);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(124, 30);
            placeNameLabel.TabIndex = 23;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(215, 182);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(217, 35);
            placeNameValue.TabIndex = 24;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new Point(65, 249);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(139, 30);
            prizeAmountLabel.TabIndex = 25;
            prizeAmountLabel.Text = "Price Amount";
            // 
            // priceAmountValue
            // 
            priceAmountValue.Location = new Point(215, 248);
            priceAmountValue.Name = "priceAmountValue";
            priceAmountValue.Size = new Size(217, 35);
            priceAmountValue.TabIndex = 26;
            // 
            // pricePercentage
            // 
            pricePercentage.AutoSize = true;
            pricePercentage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pricePercentage.ForeColor = Color.FromArgb(51, 153, 255);
            pricePercentage.Location = new Point(65, 370);
            pricePercentage.Name = "pricePercentage";
            pricePercentage.Size = new Size(171, 30);
            pricePercentage.TabIndex = 27;
            pricePercentage.Text = "Place Percentage";
            // 
            // pricePercentageValue
            // 
            pricePercentageValue.Location = new Point(242, 367);
            pricePercentageValue.Name = "pricePercentageValue";
            pricePercentageValue.Size = new Size(217, 35);
            pricePercentageValue.TabIndex = 28;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(182, 314);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(58, 30);
            orLabel.TabIndex = 29;
            orLabel.Text = "-OR-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(171, 457);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(246, 70);
            createPrizeButton.TabIndex = 30;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(656, 697);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(pricePercentage);
            Controls.Add(pricePercentageValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(priceAmountValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private Label placeNumberLabel;
        private TextBox placeNumberValue;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label prizeAmountLabel;
        private TextBox priceAmountValue;
        private Label pricePercentage;
        private TextBox pricePercentageValue;
        private Label orLabel;
        private Button createPrizeButton;
    }
}