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
      this.label6 = new System.Windows.Forms.Label();
      this.txtbox_acc_password = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtbox_acc_username = new System.Windows.Forms.TextBox();
      this.btn_commit = new System.Windows.Forms.Button();
      this.txtbox_amount = new System.Windows.Forms.TextBox();
      this.txtbox_description = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.lbl_loggedin = new System.Windows.Forms.Label();
      this.grd_transactions = new System.Windows.Forms.DataGridView();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grd_transactions)).BeginInit();
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
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.txtbox_acc_password);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.txtbox_acc_username);
      this.tabPage1.Controls.Add(this.btn_commit);
      this.tabPage1.Controls.Add(this.txtbox_amount);
      this.tabPage1.Controls.Add(this.txtbox_description);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(768, 400);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Add payment";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(258, 148);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(96, 13);
      this.label6.TabIndex = 9;
      this.label6.Text = "Account Password";
      // 
      // txtbox_acc_password
      // 
      this.txtbox_acc_password.Location = new System.Drawing.Point(360, 145);
      this.txtbox_acc_password.Name = "txtbox_acc_password";
      this.txtbox_acc_password.Size = new System.Drawing.Size(137, 20);
      this.txtbox_acc_password.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(258, 122);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(98, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Account Username";
      // 
      // txtbox_acc_username
      // 
      this.txtbox_acc_username.Location = new System.Drawing.Point(360, 119);
      this.txtbox_acc_username.Name = "txtbox_acc_username";
      this.txtbox_acc_username.Size = new System.Drawing.Size(137, 20);
      this.txtbox_acc_username.TabIndex = 6;
      // 
      // btn_commit
      // 
      this.btn_commit.Location = new System.Drawing.Point(261, 171);
      this.btn_commit.Name = "btn_commit";
      this.btn_commit.Size = new System.Drawing.Size(236, 23);
      this.btn_commit.TabIndex = 3;
      this.btn_commit.Text = "Commit";
      this.btn_commit.UseVisualStyleBackColor = true;
      this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
      // 
      // txtbox_amount
      // 
      this.txtbox_amount.Location = new System.Drawing.Point(360, 92);
      this.txtbox_amount.Name = "txtbox_amount";
      this.txtbox_amount.Size = new System.Drawing.Size(137, 20);
      this.txtbox_amount.TabIndex = 5;
      // 
      // txtbox_description
      // 
      this.txtbox_description.Location = new System.Drawing.Point(360, 65);
      this.txtbox_description.Name = "txtbox_description";
      this.txtbox_description.Size = new System.Drawing.Size(137, 20);
      this.txtbox_description.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(258, 95);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Amount to pay";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(258, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Description";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.grd_transactions);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(768, 400);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Transactions";
      this.tabPage2.UseVisualStyleBackColor = true;
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
      // grd_transactions
      // 
      this.grd_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grd_transactions.Location = new System.Drawing.Point(6, 6);
      this.grd_transactions.Name = "grd_transactions";
      this.grd_transactions.ReadOnly = true;
      this.grd_transactions.Size = new System.Drawing.Size(756, 388);
      this.grd_transactions.TabIndex = 0;
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
      ((System.ComponentModel.ISupportInitialize)(this.grd_transactions)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lbl_loggedin;
    private System.Windows.Forms.TextBox txtbox_amount;
    private System.Windows.Forms.TextBox txtbox_description;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btn_commit;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtbox_acc_password;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtbox_acc_username;
    private System.Windows.Forms.DataGridView grd_transactions;
  }
}