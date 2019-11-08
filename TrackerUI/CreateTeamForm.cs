using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
  public partial class CreateTeamForm : Form
  {
    public CreateTeamForm()
    {
      InitializeComponent();
    }

    private void createMemberButton_Click(object sender, EventArgs e)
    {
      if ( ValidateForm() )
      {
        PersonModel p = new PersonModel();

        p.FirstName = firstNameTextBox.Text;
        p.LastName = lastNameTextBox.Text;
        p.EmailAddress = emailAddrTextBox.Text;
        p.CellPhoneNumber = cellPhoneTextBox.Text;

        GlobalConfig.Connection.CreatePerson( p );

        firstNameTextBox.Text = "";
        lastNameTextBox.Text = "";
        emailAddrTextBox.Text = "";
        cellPhoneTextBox.Text = "";

      }
      else
      {
        MessageBox.Show("This form has invalid data.  Please check it and try again");
      }
    }

    private bool ValidateForm()
    {
      if ( firstNameTextBox.Text.Length == 0 )
      {
        return false;
      }

      if (lastNameTextBox.Text.Length == 0)
      {
        return false;
      }

      if (emailAddrTextBox.Text.Length == 0)
      {
        return false;
      }

      if (cellPhoneTextBox.Text.Length == 0)
      {
        return false;
      }

      return true;
    }
  }
}
