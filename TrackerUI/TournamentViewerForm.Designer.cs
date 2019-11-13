namespace TrackerUI
{
  partial class TournamentViewerForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentNameLabel = new System.Windows.Forms.Label();
      this.roundLabel = new System.Windows.Forms.Label();
      this.roundComboBox = new System.Windows.Forms.ComboBox();
      this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
      this.matchupListBox = new System.Windows.Forms.ListBox();
      this.teamOneNameLabel = new System.Windows.Forms.Label();
      this.teamTwoNameLabel = new System.Windows.Forms.Label();
      this.teamOneScoreLabel = new System.Windows.Forms.Label();
      this.teamTwoScoreLabel = new System.Windows.Forms.Label();
      this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
      this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
      this.vsLabel = new System.Windows.Forms.Label();
      this.scoreButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(214, 50);
      this.headerLabel.TabIndex = 0;
      this.headerLabel.Text = "Tournament:";
      // 
      // tournamentNameLabel
      // 
      this.tournamentNameLabel.AutoSize = true;
      this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentNameLabel.Location = new System.Drawing.Point(232, 9);
      this.tournamentNameLabel.Name = "tournamentNameLabel";
      this.tournamentNameLabel.Size = new System.Drawing.Size(157, 50);
      this.tournamentNameLabel.TabIndex = 1;
      this.tournamentNameLabel.Text = "<name>";
      // 
      // roundLabel
      // 
      this.roundLabel.AutoSize = true;
      this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.roundLabel.Location = new System.Drawing.Point(14, 106);
      this.roundLabel.Name = "roundLabel";
      this.roundLabel.Size = new System.Drawing.Size(94, 37);
      this.roundLabel.TabIndex = 2;
      this.roundLabel.Text = "Round";
      // 
      // roundComboBox
      // 
      this.roundComboBox.FormattingEnabled = true;
      this.roundComboBox.Location = new System.Drawing.Point(114, 105);
      this.roundComboBox.Name = "roundComboBox";
      this.roundComboBox.Size = new System.Drawing.Size(190, 38);
      this.roundComboBox.TabIndex = 3;
      this.roundComboBox.SelectedIndexChanged += new System.EventHandler(this.roundComboBox_SelectedIndexChanged);
      // 
      // unplayedOnlyCheckBox
      // 
      this.unplayedOnlyCheckBox.AutoSize = true;
      this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(114, 170);
      this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
      this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(209, 41);
      this.unplayedOnlyCheckBox.TabIndex = 4;
      this.unplayedOnlyCheckBox.Text = "Unplayed Only";
      this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
      // 
      // matchupListBox
      // 
      this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.matchupListBox.FormattingEnabled = true;
      this.matchupListBox.ItemHeight = 30;
      this.matchupListBox.Location = new System.Drawing.Point(21, 264);
      this.matchupListBox.Name = "matchupListBox";
      this.matchupListBox.Size = new System.Drawing.Size(283, 302);
      this.matchupListBox.TabIndex = 5;
      this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
      // 
      // teamOneNameLabel
      // 
      this.teamOneNameLabel.AutoSize = true;
      this.teamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamOneNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamOneNameLabel.Location = new System.Drawing.Point(336, 264);
      this.teamOneNameLabel.Name = "teamOneNameLabel";
      this.teamOneNameLabel.Size = new System.Drawing.Size(208, 37);
      this.teamOneNameLabel.TabIndex = 6;
      this.teamOneNameLabel.Text = "<team 1 name>";
      // 
      // teamTwoNameLabel
      // 
      this.teamTwoNameLabel.AutoSize = true;
      this.teamTwoNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamTwoNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamTwoNameLabel.Location = new System.Drawing.Point(336, 477);
      this.teamTwoNameLabel.Name = "teamTwoNameLabel";
      this.teamTwoNameLabel.Size = new System.Drawing.Size(208, 37);
      this.teamTwoNameLabel.TabIndex = 7;
      this.teamTwoNameLabel.Text = "<team 2 name>";
      // 
      // teamOneScoreLabel
      // 
      this.teamOneScoreLabel.AutoSize = true;
      this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamOneScoreLabel.Location = new System.Drawing.Point(347, 301);
      this.teamOneScoreLabel.Name = "teamOneScoreLabel";
      this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
      this.teamOneScoreLabel.TabIndex = 8;
      this.teamOneScoreLabel.Text = "Score";
      // 
      // teamTwoScoreLabel
      // 
      this.teamTwoScoreLabel.AutoSize = true;
      this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamTwoScoreLabel.Location = new System.Drawing.Point(347, 515);
      this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
      this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
      this.teamTwoScoreLabel.TabIndex = 9;
      this.teamTwoScoreLabel.Text = "Score";
      // 
      // teamOneScoreTextBox
      // 
      this.teamOneScoreTextBox.Location = new System.Drawing.Point(435, 304);
      this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
      this.teamOneScoreTextBox.Size = new System.Drawing.Size(133, 35);
      this.teamOneScoreTextBox.TabIndex = 10;
      // 
      // teamTwoScoreTextBox
      // 
      this.teamTwoScoreTextBox.Location = new System.Drawing.Point(435, 518);
      this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
      this.teamTwoScoreTextBox.Size = new System.Drawing.Size(133, 35);
      this.teamTwoScoreTextBox.TabIndex = 11;
      // 
      // vsLabel
      // 
      this.vsLabel.AutoSize = true;
      this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.vsLabel.Location = new System.Drawing.Point(373, 389);
      this.vsLabel.Name = "vsLabel";
      this.vsLabel.Size = new System.Drawing.Size(70, 37);
      this.vsLabel.TabIndex = 12;
      this.vsLabel.Text = "-VS-";
      // 
      // scoreButton
      // 
      this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.scoreButton.Location = new System.Drawing.Point(602, 386);
      this.scoreButton.Name = "scoreButton";
      this.scoreButton.Size = new System.Drawing.Size(119, 49);
      this.scoreButton.TabIndex = 13;
      this.scoreButton.Text = "Score";
      this.scoreButton.UseVisualStyleBackColor = true;
      // 
      // TournamentViewerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(760, 663);
      this.Controls.Add(this.scoreButton);
      this.Controls.Add(this.vsLabel);
      this.Controls.Add(this.teamTwoScoreTextBox);
      this.Controls.Add(this.teamOneScoreTextBox);
      this.Controls.Add(this.teamTwoScoreLabel);
      this.Controls.Add(this.teamOneScoreLabel);
      this.Controls.Add(this.teamTwoNameLabel);
      this.Controls.Add(this.teamOneNameLabel);
      this.Controls.Add(this.matchupListBox);
      this.Controls.Add(this.unplayedOnlyCheckBox);
      this.Controls.Add(this.roundComboBox);
      this.Controls.Add(this.roundLabel);
      this.Controls.Add(this.tournamentNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentViewerForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Tournament Viewer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label tournamentNameLabel;
    private System.Windows.Forms.Label roundLabel;
    private System.Windows.Forms.ComboBox roundComboBox;
    private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
    private System.Windows.Forms.ListBox matchupListBox;
    private System.Windows.Forms.Label teamOneNameLabel;
    private System.Windows.Forms.Label teamTwoNameLabel;
    private System.Windows.Forms.Label teamOneScoreLabel;
    private System.Windows.Forms.Label teamTwoScoreLabel;
    private System.Windows.Forms.TextBox teamOneScoreTextBox;
    private System.Windows.Forms.TextBox teamTwoScoreTextBox;
    private System.Windows.Forms.Label vsLabel;
    private System.Windows.Forms.Button scoreButton;
  }
}

