namespace FormsFrontend
{
  partial class DashboardForm
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.txtbox_amount = new System.Windows.Forms.TextBox();
      this.txtbox_payee = new System.Windows.Forms.TextBox();
      this.txtbox_accid = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.lbl_loggedin = new System.Windows.Forms.Label();
      this.btn_commit = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(776, 426);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btn_commit);
      this.tabPage1.Controls.Add(this.txtbox_amount);
      this.tabPage1.Controls.Add(this.txtbox_payee);
      this.tabPage1.Controls.Add(this.txtbox_accid);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(768, 400);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Add payment";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // txtbox_amount
      // 
      this.txtbox_amount.Location = new System.Drawing.Point(339, 106);
      this.txtbox_amount.Name = "txtbox_amount";
      this.txtbox_amount.Size = new System.Drawing.Size(158, 20);
      this.txtbox_amount.TabIndex = 5;
      // 
      // txtbox_payee
      // 
      this.txtbox_payee.Location = new System.Drawing.Point(339, 74);
      this.txtbox_payee.Name = "txtbox_payee";
      this.txtbox_payee.Size = new System.Drawing.Size(158, 20);
      this.txtbox_payee.TabIndex = 4;
      // 
      // txtbox_accid
      // 
      this.txtbox_accid.Location = new System.Drawing.Point(339, 39);
      this.txtbox_accid.Name = "txtbox_accid";
      this.txtbox_accid.Size = new System.Drawing.Size(158, 20);
      this.txtbox_accid.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(258, 108);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Amount to pay";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(258, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Payee";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(258, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Account ID";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.label1);
      this.tabPage2.Controls.Add(this.button2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(768, 400);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(280, 64);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(321, 55);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 0;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(594, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(73, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Logout";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lbl_loggedin
      // 
      this.lbl_loggedin.AutoSize = true;
      this.lbl_loggedin.Location = new System.Drawing.Point(669, 10);
      this.lbl_loggedin.Name = "lbl_loggedin";
      this.lbl_loggedin.Size = new System.Drawing.Size(71, 13);
      this.lbl_loggedin.TabIndex = 2;
      this.lbl_loggedin.Text = "Logged in as ";
      this.lbl_loggedin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btn_commit
      // 
      this.btn_commit.Location = new System.Drawing.Point(261, 148);
      this.btn_commit.Name = "btn_commit";
      this.btn_commit.Size = new System.Drawing.Size(236, 23);
      this.btn_commit.TabIndex = 3;
      this.btn_commit.Text = "Commit";
      this.btn_commit.UseVisualStyleBackColor = true;
      this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
      // 
      // DashboardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbl_loggedin);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "DashboardForm";
      this.Text = "DashboardForm";
      this.Load += new System.EventHandler(this.DashboardForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lbl_loggedin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtbox_amount;
    private System.Windows.Forms.TextBox txtbox_payee;
    private System.Windows.Forms.TextBox txtbox_accid;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btn_commit;
  }
}