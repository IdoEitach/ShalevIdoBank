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
  }
}
