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
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 50);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(230, 80);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(331, 35);
            placeNumberValue.TabIndex = 24;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.Location = new Point(12, 77);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 23;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(230, 186);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(331, 35);
            prizeAmountValue.TabIndex = 26;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.Location = new Point(12, 183);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 25;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(230, 131);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(331, 35);
            placeNameValue.TabIndex = 28;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.Location = new Point(12, 131);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 27;
            placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(230, 367);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(331, 35);
            prizePercentageValue.TabIndex = 30;
            prizePercentageValue.TextChanged += textBox3_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.Location = new Point(12, 367);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 29;
            prizePercentageLabel.Text = "Prize Percentage";
            prizePercentageLabel.Click += label3_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.Location = new Point(230, 269);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 31;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(12, 449);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(549, 61);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1371, 900);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.CornflowerBlue;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += this.CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}