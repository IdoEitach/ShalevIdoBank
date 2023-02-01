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
      bool succeed = service.PayThatBill(int.Parse(txtbox_accid.Text), txtbox_payee.Text, float.Parse(txtbox_amount.Text));
      if (succeed)
      {
        MessageBox.Show("Success!", "Pay that bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else
      {
        MessageBox.Show("Couldn't pay that bill.", "Pay that bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void lbl_loggedin_Click(object sender, EventArgs e)
    {

    }
  }
}
