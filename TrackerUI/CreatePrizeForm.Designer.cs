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
      this.headerLabel = new System.Windows.Forms.Label();
      this.placeNumberTextBox = new System.Windows.Forms.TextBox();
      this.placeNumberLabel = new System.Windows.Forms.Label();
      this.placeNameTextBox = new System.Windows.Forms.TextBox();
      this.placeNameLabel = new System.Windows.Forms.Label();
      this.prizeAmountTextBox = new System.Windows.Forms.TextBox();
      this.prizeAmountLabel = new System.Windows.Forms.Label();
      this.prizePercentageTextBox = new System.Windows.Forms.TextBox();
      this.prizePercentageLabel = new System.Windows.Forms.Label();
      this.orLabel = new System.Windows.Forms.Label();
      this.createPrizeButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(209, 50);
      this.headerLabel.TabIndex = 16;
      this.headerLabel.Text = "Create Prize";
      // 
      // placeNumberTextBox
      // 
      this.placeNumberTextBox.Location = new System.Drawing.Point(229, 99);
      this.placeNumberTextBox.Name = "placeNumberTextBox";
      this.placeNumberTextBox.Size = new System.Drawing.Size(234, 35);
      this.placeNumberTextBox.TabIndex = 18;
      // 
      // placeNumberLabel
      // 
      this.placeNumberLabel.AutoSize = true;
      this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.placeNumberLabel.Location = new System.Drawing.Point(14, 96);
      this.placeNumberLabel.Name = "placeNumberLabel";
      this.placeNumberLabel.Size = new System.Drawing.Size(183, 37);
      this.placeNumberLabel.TabIndex = 17;
      this.placeNumberLabel.Text = "Place Number";
      // 
      // placeNameTextBox
      // 
      this.placeNameTextBox.Location = new System.Drawing.Point(229, 156);
      this.placeNameTextBox.Name = "placeNameTextBox";
      this.placeNameTextBox.Size = new System.Drawing.Size(234, 35);
      this.placeNameTextBox.TabIndex = 20;
      // 
      // placeNameLabel
      // 
      this.placeNameLabel.AutoSize = true;
      this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.placeNameLabel.Location = new System.Drawing.Point(14, 153);
      this.placeNameLabel.Name = "placeNameLabel";
      this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
      this.placeNameLabel.TabIndex = 19;
      this.placeNameLabel.Text = "Place Name";
      // 
      // prizeAmountTextBox
      // 
      this.prizeAmountTextBox.Location = new System.Drawing.Point(229, 213);
      this.prizeAmountTextBox.Name = "prizeAmountTextBox";
      this.prizeAmountTextBox.Size = new System.Drawing.Size(234, 35);
      this.prizeAmountTextBox.TabIndex = 22;
      this.prizeAmountTextBox.Text = "0";
      // 
      // prizeAmountLabel
      // 
      this.prizeAmountLabel.AutoSize = true;
      this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.prizeAmountLabel.Location = new System.Drawing.Point(14, 210);
      this.prizeAmountLabel.Name = "prizeAmountLabel";
      this.prizeAmountLabel.Size = new System.Drawing.Size(176, 37);
      this.prizeAmountLabel.TabIndex = 21;
      this.prizeAmountLabel.Text = "Prize Amount";
      // 
      // prizePercentageTextBox
      // 
      this.prizePercentageTextBox.Location = new System.Drawing.Point(229, 333);
      this.prizePercentageTextBox.Name = "prizePercentageTextBox";
      this.prizePercentageTextBox.Size = new System.Drawing.Size(234, 35);
      this.prizePercentageTextBox.TabIndex = 24;
      this.prizePercentageTextBox.Text = "0";
      // 
      // prizePercentageLabel
      // 
      this.prizePercentageLabel.AutoSize = true;
      this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.prizePercentageLabel.Location = new System.Drawing.Point(12, 333);
      this.prizePercentageLabel.Name = "prizePercentageLabel";
      this.prizePercentageLabel.Size = new System.Drawing.Size(212, 37);
      this.prizePercentageLabel.TabIndex = 23;
      this.prizePercentageLabel.Text = "Prize Percentage";
      // 
      // orLabel
      // 
      this.orLabel.AutoSize = true;
      this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.orLabel.Location = new System.Drawing.Point(150, 276);
      this.orLabel.Name = "orLabel";
      this.orLabel.Size = new System.Drawing.Size(64, 37);
      this.orLabel.TabIndex = 25;
      this.orLabel.Text = "-or-";
      // 
      // createPrizeButton
      // 
      this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createPrizeButton.Location = new System.Drawing.Point(105, 423);
      this.createPrizeButton.Name = "createPrizeButton";
      this.createPrizeButton.Size = new System.Drawing.Size(258, 49);
      this.createPrizeButton.TabIndex = 28;
      this.createPrizeButton.Text = "Create Prize";
      this.createPrizeButton.UseVisualStyleBackColor = true;
      this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
      // 
      // CreatePrizeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(517, 484);
      this.Controls.Add(this.createPrizeButton);
      this.Controls.Add(this.orLabel);
      this.Controls.Add(this.prizePercentageTextBox);
      this.Controls.Add(this.prizePercentageLabel);
      this.Controls.Add(this.prizeAmountTextBox);
      this.Controls.Add(this.prizeAmountLabel);
      this.Controls.Add(this.placeNameTextBox);
      this.Controls.Add(this.placeNameLabel);
      this.Controls.Add(this.placeNumberTextBox);
      this.Controls.Add(this.placeNumberLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreatePrizeForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create Prize";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox placeNumberTextBox;
    private System.Windows.Forms.Label placeNumberLabel;
    private System.Windows.Forms.TextBox placeNameTextBox;
    private System.Windows.Forms.Label placeNameLabel;
    private System.Windows.Forms.TextBox prizeAmountTextBox;
    private System.Windows.Forms.Label prizeAmountLabel;
    private System.Windows.Forms.TextBox prizePercentageTextBox;
    private System.Windows.Forms.Label prizePercentageLabel;
    private System.Windows.Forms.Label orLabel;
    private System.Windows.Forms.Button createPrizeButton;
  }
}