namespace MongoDBChallenge
{
    partial class Dashboard
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.existingRecordLabel = new System.Windows.Forms.Label();
            this.existingRecordDropDown = new System.Windows.Forms.ComboBox();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(89, 125);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(262, 122);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(254, 31);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(262, 171);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(254, 31);
            this.lastNameText.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(89, 174);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(262, 223);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(254, 31);
            this.emailText.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(89, 226);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(65, 25);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(262, 335);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(189, 42);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // existingRecordLabel
            // 
            this.existingRecordLabel.AutoSize = true;
            this.existingRecordLabel.Location = new System.Drawing.Point(89, 47);
            this.existingRecordLabel.Name = "existingRecordLabel";
            this.existingRecordLabel.Size = new System.Drawing.Size(79, 25);
            this.existingRecordLabel.TabIndex = 10;
            this.existingRecordLabel.Text = "People";
            // 
            // existingRecordDropDown
            // 
            this.existingRecordDropDown.FormattingEnabled = true;
            this.existingRecordDropDown.Location = new System.Drawing.Point(262, 44);
            this.existingRecordDropDown.Name = "existingRecordDropDown";
            this.existingRecordDropDown.Size = new System.Drawing.Size(254, 33);
            this.existingRecordDropDown.TabIndex = 15;
            this.existingRecordDropDown.SelectedIndexChanged += new System.EventHandler(this.existingRecordDropDown_SelectedIndexChanged);
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Location = new System.Drawing.Point(262, 278);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(254, 31);
            this.phoneNumberText.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(89, 281);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.phoneNumberLabel.TabIndex = 17;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 417);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.existingRecordDropDown);
            this.Controls.Add(this.existingRecordLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label existingRecordLabel;
        private System.Windows.Forms.ComboBox existingRecordDropDown;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.Label phoneNumberLabel;
    }
}

