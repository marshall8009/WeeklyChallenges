namespace SearchingForDataApp
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
			this.textToSearchLabel = new System.Windows.Forms.Label();
			this.textToSearchText = new System.Windows.Forms.TextBox();
			this.resultsListBox = new System.Windows.Forms.ListBox();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.searchTextButton = new System.Windows.Forms.Button();
			this.searchForPhoneNumberBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textToSearchLabel
			// 
			this.textToSearchLabel.AutoSize = true;
			this.textToSearchLabel.Location = new System.Drawing.Point(12, 28);
			this.textToSearchLabel.Name = "textToSearchLabel";
			this.textToSearchLabel.Size = new System.Drawing.Size(138, 29);
			this.textToSearchLabel.TabIndex = 0;
			this.textToSearchLabel.Text = "Search For:";
			// 
			// textToSearchText
			// 
			this.textToSearchText.Location = new System.Drawing.Point(156, 25);
			this.textToSearchText.Name = "textToSearchText";
			this.textToSearchText.Size = new System.Drawing.Size(237, 35);
			this.textToSearchText.TabIndex = 1;
			this.textToSearchText.TextChanged += new System.EventHandler(this.textToSearchText_TextChanged);
			// 
			// resultsListBox
			// 
			this.resultsListBox.FormattingEnabled = true;
			this.resultsListBox.ItemHeight = 29;
			this.resultsListBox.Location = new System.Drawing.Point(12, 126);
			this.resultsListBox.Name = "resultsListBox";
			this.resultsListBox.Size = new System.Drawing.Size(1054, 207);
			this.resultsListBox.TabIndex = 2;
			// 
			// resultsLabel
			// 
			this.resultsLabel.AutoSize = true;
			this.resultsLabel.Location = new System.Drawing.Point(12, 94);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(99, 29);
			this.resultsLabel.TabIndex = 3;
			this.resultsLabel.Text = "Results:";
			// 
			// searchTextButton
			// 
			this.searchTextButton.Location = new System.Drawing.Point(399, 22);
			this.searchTextButton.Name = "searchTextButton";
			this.searchTextButton.Size = new System.Drawing.Size(144, 40);
			this.searchTextButton.TabIndex = 4;
			this.searchTextButton.Text = "Search";
			this.searchTextButton.UseVisualStyleBackColor = true;
			this.searchTextButton.Click += new System.EventHandler(this.searchTextButton_Click);
			// 
			// searchForPhoneNumberBtn
			// 
			this.searchForPhoneNumberBtn.Location = new System.Drawing.Point(594, 22);
			this.searchForPhoneNumberBtn.Name = "searchForPhoneNumberBtn";
			this.searchForPhoneNumberBtn.Size = new System.Drawing.Size(300, 40);
			this.searchForPhoneNumberBtn.TabIndex = 5;
			this.searchForPhoneNumberBtn.Text = "Phone Number Search ";
			this.searchForPhoneNumberBtn.UseVisualStyleBackColor = true;
			this.searchForPhoneNumberBtn.Click += new System.EventHandler(this.searchForPhoneNumberBtn_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 410);
			this.Controls.Add(this.searchForPhoneNumberBtn);
			this.Controls.Add(this.searchTextButton);
			this.Controls.Add(this.resultsLabel);
			this.Controls.Add(this.resultsListBox);
			this.Controls.Add(this.textToSearchText);
			this.Controls.Add(this.textToSearchLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.Name = "Dashboard";
			this.Text = "Searching For Data Solution";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label textToSearchLabel;
		private System.Windows.Forms.TextBox textToSearchText;
		private System.Windows.Forms.ListBox resultsListBox;
		private System.Windows.Forms.Label resultsLabel;
		private System.Windows.Forms.Button searchTextButton;
		private System.Windows.Forms.Button searchForPhoneNumberBtn;
	}
}

