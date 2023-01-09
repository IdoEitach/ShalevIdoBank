namespace FormsFrontend
{
  partial class LoginForm
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
      this.lbl_title = new System.Windows.Forms.Label();
      this.grubox_login = new System.Windows.Forms.GroupBox();
      this.txtbox_password = new System.Windows.Forms.TextBox();
      this.txtbox_username = new System.Windows.Forms.TextBox();
      this.lbl_password = new System.Windows.Forms.Label();
      this.lbl_username = new System.Windows.Forms.Label();
      this.btn_login = new System.Windows.Forms.Button();
      this.grubox_login.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl_title
      // 
      this.lbl_title.AutoSize = true;
      this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.lbl_title.Location = new System.Drawing.Point(87, 26);
      this.lbl_title.Name = "lbl_title";
      this.lbl_title.Size = new System.Drawing.Size(219, 55);
      this.lbl_title.TabIndex = 0;
      this.lbl_title.Text = "EatPasta";
      // 
      // grubox_login
      // 
      this.grubox_login.Controls.Add(this.txtbox_password);
      this.grubox_login.Controls.Add(this.txtbox_username);
      this.grubox_login.Controls.Add(this.lbl_password);
      this.grubox_login.Controls.Add(this.lbl_username);
      this.grubox_login.Controls.Add(this.btn_login);
      this.grubox_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.grubox_login.Location = new System.Drawing.Point(14, 84);
      this.grubox_login.Name = "grubox_login";
      this.grubox_login.Size = new System.Drawing.Size(354, 126);
      this.grubox_login.TabIndex = 1;
      this.grubox_login.TabStop = false;
      this.grubox_login.Text = "Login";
      // 
      // txtbox_password
      // 
      this.txtbox_password.Location = new System.Drawing.Point(79, 60);
      this.txtbox_password.Name = "txtbox_password";
      this.txtbox_password.PasswordChar = '*';
      this.txtbox_password.Size = new System.Drawing.Size(247, 20);
      this.txtbox_password.TabIndex = 2;
      // 
      // txtbox_username
      // 
      this.txtbox_username.Location = new System.Drawing.Point(78, 26);
      this.txtbox_username.Name = "txtbox_username";
      this.txtbox_username.Size = new System.Drawing.Size(248, 20);
      this.txtbox_username.TabIndex = 1;
      // 
      // lbl_password
      // 
      this.lbl_password.AutoSize = true;
      this.lbl_password.Location = new System.Drawing.Point(17, 63);
      this.lbl_password.Name = "lbl_password";
      this.lbl_password.Size = new System.Drawing.Size(53, 13);
      this.lbl_password.TabIndex = 1;
      this.lbl_password.Text = "Password";
      // 
      // lbl_username
      // 
      this.lbl_username.AutoSize = true;
      this.lbl_username.Location = new System.Drawing.Point(17, 29);
      this.lbl_username.Name = "lbl_username";
      this.lbl_username.Size = new System.Drawing.Size(55, 13);
      this.lbl_username.TabIndex = 0;
      this.lbl_username.Text = "Username";
      // 
      // btn_login
      // 
      this.btn_login.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btn_login.Location = new System.Drawing.Point(143, 97);
      this.btn_login.Name = "btn_login";
      this.btn_login.Size = new System.Drawing.Size(75, 23);
      this.btn_login.TabIndex = 3;
      this.btn_login.Text = "Login";
      this.btn_login.UseVisualStyleBackColor = false;
      this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(380, 223);
      this.Controls.Add(this.grubox_login);
      this.Controls.Add(this.lbl_title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "LoginForm";
      this.Text = "EatPasta";
      this.grubox_login.ResumeLayout(false);
      this.grubox_login.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_title;
    private System.Windows.Forms.GroupBox grubox_login;
    private System.Windows.Forms.Label lbl_password;
    private System.Windows.Forms.Label lbl_username;
    private System.Windows.Forms.Button btn_login;
    private System.Windows.Forms.TextBox txtbox_password;
    private System.Windows.Forms.TextBox txtbox_username;
  }
}

