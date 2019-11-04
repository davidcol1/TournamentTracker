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
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
      this.tournamentNameLabel = new System.Windows.Forms.Label();
      this.entryFeeTextBox = new System.Windows.Forms.TextBox();
      this.entryFeeLabel = new System.Windows.Forms.Label();
      this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
      this.selectTeamLabel = new System.Windows.Forms.Label();
      this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
      this.addTeamButton = new System.Windows.Forms.Button();
      this.createPrizeButton = new System.Windows.Forms.Button();
      this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
      this.teamsPlayersLabel = new System.Windows.Forms.Label();
      this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
      this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
      this.prizesLabel = new System.Windows.Forms.Label();
      this.prizesListBox = new System.Windows.Forms.ListBox();
      this.createTournamentButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(19, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(317, 50);
      this.headerLabel.TabIndex = 1;
      this.headerLabel.Text = "Create Tournament";
      // 
      // tournamentNameTextBox
      // 
      this.tournamentNameTextBox.Location = new System.Drawing.Point(28, 129);
      this.tournamentNameTextBox.Name = "tournamentNameTextBox";
      this.tournamentNameTextBox.Size = new System.Drawing.Size(400, 35);
      this.tournamentNameTextBox.TabIndex = 12;
      // 
      // tournamentNameLabel
      // 
      this.tournamentNameLabel.AutoSize = true;
      this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentNameLabel.Location = new System.Drawing.Point(21, 89);
      this.tournamentNameLabel.Name = "tournamentNameLabel";
      this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
      this.tournamentNameLabel.TabIndex = 11;
      this.tournamentNameLabel.Text = "Tournament Name";
      // 
      // entryFeeTextBox
      // 
      this.entryFeeTextBox.Location = new System.Drawing.Point(152, 194);
      this.entryFeeTextBox.Name = "entryFeeTextBox";
      this.entryFeeTextBox.Size = new System.Drawing.Size(133, 35);
      this.entryFeeTextBox.TabIndex = 14;
      this.entryFeeTextBox.Text = "0";
      // 
      // entryFeeLabel
      // 
      this.entryFeeLabel.AutoSize = true;
      this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.entryFeeLabel.Location = new System.Drawing.Point(21, 191);
      this.entryFeeLabel.Name = "entryFeeLabel";
      this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
      this.entryFeeLabel.TabIndex = 13;
      this.entryFeeLabel.Text = "Entry Fee";
      // 
      // selectTeamComboBox
      // 
      this.selectTeamComboBox.FormattingEnabled = true;
      this.selectTeamComboBox.Location = new System.Drawing.Point(28, 301);
      this.selectTeamComboBox.Name = "selectTeamComboBox";
      this.selectTeamComboBox.Size = new System.Drawing.Size(400, 38);
      this.selectTeamComboBox.TabIndex = 16;
      // 
      // selectTeamLabel
      // 
      this.selectTeamLabel.AutoSize = true;
      this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamLabel.Location = new System.Drawing.Point(21, 261);
      this.selectTeamLabel.Name = "selectTeamLabel";
      this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
      this.selectTeamLabel.TabIndex = 15;
      this.selectTeamLabel.Text = "Select Team";
      // 
      // createNewTeamLinkLabel
      // 
      this.createNewTeamLinkLabel.AutoSize = true;
      this.createNewTeamLinkLabel.Location = new System.Drawing.Point(252, 261);
      this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
      this.createNewTeamLinkLabel.Size = new System.Drawing.Size(176, 30);
      this.createNewTeamLinkLabel.TabIndex = 17;
      this.createNewTeamLinkLabel.TabStop = true;
      this.createNewTeamLinkLabel.Text = "Create New Team";
      // 
      // addTeamButton
      // 
      this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addTeamButton.Location = new System.Drawing.Point(154, 345);
      this.addTeamButton.Name = "addTeamButton";
      this.addTeamButton.Size = new System.Drawing.Size(149, 49);
      this.addTeamButton.TabIndex = 18;
      this.addTeamButton.Text = "Add Team";
      this.addTeamButton.UseVisualStyleBackColor = true;
      // 
      // createPrizeButton
      // 
      this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createPrizeButton.Location = new System.Drawing.Point(177, 580);
      this.createPrizeButton.Name = "createPrizeButton";
      this.createPrizeButton.Size = new System.Drawing.Size(149, 49);
      this.createPrizeButton.TabIndex = 19;
      this.createPrizeButton.Text = "Create Prize";
      this.createPrizeButton.UseVisualStyleBackColor = true;
      // 
      // tournamentPlayersListBox
      // 
      this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tournamentPlayersListBox.FormattingEnabled = true;
      this.tournamentPlayersListBox.ItemHeight = 30;
      this.tournamentPlayersListBox.Location = new System.Drawing.Point(471, 129);
      this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
      this.tournamentPlayersListBox.Size = new System.Drawing.Size(283, 182);
      this.tournamentPlayersListBox.TabIndex = 20;
      // 
      // teamsPlayersLabel
      // 
      this.teamsPlayersLabel.AutoSize = true;
      this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamsPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamsPlayersLabel.Location = new System.Drawing.Point(464, 89);
      this.teamsPlayersLabel.Name = "teamsPlayersLabel";
      this.teamsPlayersLabel.Size = new System.Drawing.Size(198, 37);
      this.teamsPlayersLabel.TabIndex = 21;
      this.teamsPlayersLabel.Text = "Teams / Players";
      // 
      // deleteSelectedPlayerButton
      // 
      this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(760, 194);
      this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
      this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(149, 74);
      this.deleteSelectedPlayerButton.TabIndex = 22;
      this.deleteSelectedPlayerButton.Text = "Delete Selected";
      this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
      // 
      // deleteSelectedPrizeButton
      // 
      this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(621, 567);
      this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
      this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(149, 74);
      this.deleteSelectedPrizeButton.TabIndex = 25;
      this.deleteSelectedPrizeButton.Text = "Delete Selected";
      this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
      // 
      // prizesLabel
      // 
      this.prizesLabel.AutoSize = true;
      this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.prizesLabel.Location = new System.Drawing.Point(325, 475);
      this.prizesLabel.Name = "prizesLabel";
      this.prizesLabel.Size = new System.Drawing.Size(85, 37);
      this.prizesLabel.TabIndex = 24;
      this.prizesLabel.Text = "Prizes";
      // 
      // prizesListBox
      // 
      this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.prizesListBox.FormattingEnabled = true;
      this.prizesListBox.ItemHeight = 30;
      this.prizesListBox.Location = new System.Drawing.Point(332, 515);
      this.prizesListBox.Name = "prizesListBox";
      this.prizesListBox.Size = new System.Drawing.Size(283, 182);
      this.prizesListBox.TabIndex = 23;
      // 
      // createTournamentButton
      // 
      this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTournamentButton.Location = new System.Drawing.Point(285, 775);
      this.createTournamentButton.Name = "createTournamentButton";
      this.createTournamentButton.Size = new System.Drawing.Size(346, 49);
      this.createTournamentButton.TabIndex = 26;
      this.createTournamentButton.Text = "Create Tournament";
      this.createTournamentButton.UseVisualStyleBackColor = true;
      // 
      // CreateTournamentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(931, 836);
      this.Controls.Add(this.createTournamentButton);
      this.Controls.Add(this.deleteSelectedPrizeButton);
      this.Controls.Add(this.prizesLabel);
      this.Controls.Add(this.prizesListBox);
      this.Controls.Add(this.deleteSelectedPlayerButton);
      this.Controls.Add(this.teamsPlayersLabel);
      this.Controls.Add(this.tournamentPlayersListBox);
      this.Controls.Add(this.createPrizeButton);
      this.Controls.Add(this.addTeamButton);
      this.Controls.Add(this.createNewTeamLinkLabel);
      this.Controls.Add(this.selectTeamComboBox);
      this.Controls.Add(this.selectTeamLabel);
      this.Controls.Add(this.entryFeeTextBox);
      this.Controls.Add(this.entryFeeLabel);
      this.Controls.Add(this.tournamentNameTextBox);
      this.Controls.Add(this.tournamentNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTournamentForm";
      this.Text = "Create Tournament";
      this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox tournamentNameTextBox;
    private System.Windows.Forms.Label tournamentNameLabel;
    private System.Windows.Forms.TextBox entryFeeTextBox;
    private System.Windows.Forms.Label entryFeeLabel;
    private System.Windows.Forms.ComboBox selectTeamComboBox;
    private System.Windows.Forms.Label selectTeamLabel;
    private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
    private System.Windows.Forms.Button addTeamButton;
    private System.Windows.Forms.Button createPrizeButton;
    private System.Windows.Forms.ListBox tournamentPlayersListBox;
    private System.Windows.Forms.Label teamsPlayersLabel;
    private System.Windows.Forms.Button deleteSelectedPlayerButton;
    private System.Windows.Forms.Button deleteSelectedPrizeButton;
    private System.Windows.Forms.Label prizesLabel;
    private System.Windows.Forms.ListBox prizesListBox;
    private System.Windows.Forms.Button createTournamentButton;
  }
}