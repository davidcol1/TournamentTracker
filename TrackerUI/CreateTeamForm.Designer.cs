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
      this.teamNameTextBox = new System.Windows.Forms.TextBox();
      this.teamNameLabel = new System.Windows.Forms.Label();
      this.headerLabel = new System.Windows.Forms.Label();
      this.addTeamMemberButton = new System.Windows.Forms.Button();
      this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
      this.selectTeamMemberLabel = new System.Windows.Forms.Label();
      this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.cellPhoneTextBox = new System.Windows.Forms.TextBox();
      this.cellPhoneLabel = new System.Windows.Forms.Label();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.emailAddrTextBox = new System.Windows.Forms.TextBox();
      this.emailLabel = new System.Windows.Forms.Label();
      this.createMemberButton = new System.Windows.Forms.Button();
      this.teamMembersListBox = new System.Windows.Forms.ListBox();
      this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
      this.createTeamButton = new System.Windows.Forms.Button();
      this.addNewMemberGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // teamNameTextBox
      // 
      this.teamNameTextBox.Location = new System.Drawing.Point(21, 142);
      this.teamNameTextBox.Name = "teamNameTextBox";
      this.teamNameTextBox.Size = new System.Drawing.Size(413, 35);
      this.teamNameTextBox.TabIndex = 14;
      // 
      // teamNameLabel
      // 
      this.teamNameLabel.AutoSize = true;
      this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamNameLabel.Location = new System.Drawing.Point(14, 102);
      this.teamNameLabel.Name = "teamNameLabel";
      this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
      this.teamNameLabel.TabIndex = 13;
      this.teamNameLabel.Text = "Team Name";
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(213, 50);
      this.headerLabel.TabIndex = 15;
      this.headerLabel.Text = "Create Team";
      // 
      // addTeamMemberButton
      // 
      this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTeamMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addTeamMemberButton.Location = new System.Drawing.Point(74, 307);
      this.addTeamMemberButton.Name = "addTeamMemberButton";
      this.addTeamMemberButton.Size = new System.Drawing.Size(315, 49);
      this.addTeamMemberButton.TabIndex = 21;
      this.addTeamMemberButton.Text = "Add Team Member";
      this.addTeamMemberButton.UseVisualStyleBackColor = true;
      // 
      // selectTeamMemberComboBox
      // 
      this.selectTeamMemberComboBox.FormattingEnabled = true;
      this.selectTeamMemberComboBox.Location = new System.Drawing.Point(21, 263);
      this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
      this.selectTeamMemberComboBox.Size = new System.Drawing.Size(413, 38);
      this.selectTeamMemberComboBox.TabIndex = 20;
      // 
      // selectTeamMemberLabel
      // 
      this.selectTeamMemberLabel.AutoSize = true;
      this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 223);
      this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
      this.selectTeamMemberLabel.TabIndex = 19;
      this.selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // addNewMemberGroupBox
      // 
      this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
      this.addNewMemberGroupBox.Controls.Add(this.emailAddrTextBox);
      this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
      this.addNewMemberGroupBox.Controls.Add(this.lastNameTextBox);
      this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
      this.addNewMemberGroupBox.Controls.Add(this.cellPhoneTextBox);
      this.addNewMemberGroupBox.Controls.Add(this.cellPhoneLabel);
      this.addNewMemberGroupBox.Controls.Add(this.firstNameTextBox);
      this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
      this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addNewMemberGroupBox.Location = new System.Drawing.Point(21, 390);
      this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
      this.addNewMemberGroupBox.Size = new System.Drawing.Size(413, 320);
      this.addNewMemberGroupBox.TabIndex = 22;
      this.addNewMemberGroupBox.TabStop = false;
      this.addNewMemberGroupBox.Text = "Add New Member";
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(164, 57);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(234, 35);
      this.firstNameTextBox.TabIndex = 12;
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.firstNameLabel.Location = new System.Drawing.Point(14, 54);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
      this.firstNameLabel.TabIndex = 11;
      this.firstNameLabel.Text = "First Name";
      // 
      // cellPhoneTextBox
      // 
      this.cellPhoneTextBox.Location = new System.Drawing.Point(164, 139);
      this.cellPhoneTextBox.Name = "cellPhoneTextBox";
      this.cellPhoneTextBox.Size = new System.Drawing.Size(234, 35);
      this.cellPhoneTextBox.TabIndex = 14;
      // 
      // cellPhoneLabel
      // 
      this.cellPhoneLabel.AutoSize = true;
      this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cellPhoneLabel.Location = new System.Drawing.Point(14, 136);
      this.cellPhoneLabel.Name = "cellPhoneLabel";
      this.cellPhoneLabel.Size = new System.Drawing.Size(144, 37);
      this.cellPhoneLabel.TabIndex = 13;
      this.cellPhoneLabel.Text = "Cell Phone";
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(164, 98);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(234, 35);
      this.lastNameTextBox.TabIndex = 16;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.lastNameLabel.Location = new System.Drawing.Point(14, 95);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
      this.lastNameLabel.TabIndex = 15;
      this.lastNameLabel.Text = "Last Name";
      // 
      // emailAddrTextBox
      // 
      this.emailAddrTextBox.Location = new System.Drawing.Point(164, 180);
      this.emailAddrTextBox.Name = "emailAddrTextBox";
      this.emailAddrTextBox.Size = new System.Drawing.Size(234, 35);
      this.emailAddrTextBox.TabIndex = 18;
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.emailLabel.Location = new System.Drawing.Point(14, 177);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(147, 37);
      this.emailLabel.TabIndex = 17;
      this.emailLabel.Text = "Email Addr";
      // 
      // createMemberButton
      // 
      this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createMemberButton.Location = new System.Drawing.Point(96, 244);
      this.createMemberButton.Name = "createMemberButton";
      this.createMemberButton.Size = new System.Drawing.Size(214, 49);
      this.createMemberButton.TabIndex = 23;
      this.createMemberButton.Text = "Create Member";
      this.createMemberButton.UseVisualStyleBackColor = true;
      // 
      // teamMembersListBox
      // 
      this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teamMembersListBox.FormattingEnabled = true;
      this.teamMembersListBox.ItemHeight = 30;
      this.teamMembersListBox.Location = new System.Drawing.Point(459, 142);
      this.teamMembersListBox.Name = "teamMembersListBox";
      this.teamMembersListBox.Size = new System.Drawing.Size(283, 572);
      this.teamMembersListBox.TabIndex = 23;
      // 
      // deleteSelectedMemberButton
      // 
      this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.deleteSelectedMemberButton.Location = new System.Drawing.Point(754, 367);
      this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
      this.deleteSelectedMemberButton.Size = new System.Drawing.Size(149, 74);
      this.deleteSelectedMemberButton.TabIndex = 24;
      this.deleteSelectedMemberButton.Text = "Delete Selected";
      this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
      // 
      // createTeamButton
      // 
      this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTeamButton.Location = new System.Drawing.Point(284, 804);
      this.createTeamButton.Name = "createTeamButton";
      this.createTeamButton.Size = new System.Drawing.Size(346, 49);
      this.createTeamButton.TabIndex = 27;
      this.createTeamButton.Text = "Create Team";
      this.createTeamButton.UseVisualStyleBackColor = true;
      // 
      // CreateTeamForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(925, 865);
      this.Controls.Add(this.createTeamButton);
      this.Controls.Add(this.deleteSelectedMemberButton);
      this.Controls.Add(this.teamMembersListBox);
      this.Controls.Add(this.addNewMemberGroupBox);
      this.Controls.Add(this.addTeamMemberButton);
      this.Controls.Add(this.selectTeamMemberComboBox);
      this.Controls.Add(this.selectTeamMemberLabel);
      this.Controls.Add(this.headerLabel);
      this.Controls.Add(this.teamNameTextBox);
      this.Controls.Add(this.teamNameLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTeamForm";
      this.Text = "Create Team";
      this.addNewMemberGroupBox.ResumeLayout(false);
      this.addNewMemberGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox teamNameTextBox;
    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Button addTeamMemberButton;
    private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.GroupBox addNewMemberGroupBox;
    private System.Windows.Forms.Button createMemberButton;
    private System.Windows.Forms.TextBox emailAddrTextBox;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox cellPhoneTextBox;
    private System.Windows.Forms.Label cellPhoneLabel;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.ListBox teamMembersListBox;
    private System.Windows.Forms.Button deleteSelectedMemberButton;
    private System.Windows.Forms.Button createTeamButton;
  }
}