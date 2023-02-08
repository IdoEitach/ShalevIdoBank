using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsFrontend
{
  public partial class DashboardForm : Form
  {
    private string username;
    private bank.ClientBankService service = new bank.ClientBankService();

    public DashboardForm(string username)
    {
      this.username = username;
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {
      lbl_loggedin.Text += username;
    }

    private void btn_commit_Click(object sender, EventArgs e)
    {
      bool succeed = service.PayThatBill(float.Parse(txtbox_amount.Text), txtbox_description.Text, txtbox_acc_username.Text, txtbox_acc_password.Text, "EatPasta");
      if (succeed)
      {
        MessageBox.Show("Success!", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Couldn't pay that bill.", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
