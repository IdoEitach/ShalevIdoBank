namespace FormsFrontend
{
  partial class Form1
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
      this.lbl_username = new System.Windows.Forms.Label();
      this.lbl_password = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.btn_login = new System.Windows.Forms.Button();
      this.grubox_login.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl_title
      // 
      this.lbl_title.AutoSize = true;
      this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.lbl_title.Location = new System.Drawing.Point(295, 119);
      this.lbl_title.Name = "lbl_title";
      this.lbl_title.Size = new System.Drawing.Size(219, 55);
      this.lbl_title.TabIndex = 0;
      this.lbl_title.Text = "EatPasta";
      // 
      // grubox_login
      // 
      this.grubox_login.Controls.Add(this.textBox2);
      this.grubox_login.Controls.Add(this.textBox1);
      this.grubox_login.Controls.Add(this.lbl_password);
      this.grubox_login.Controls.Add(this.lbl_username);
      this.grubox_login.Controls.Add(this.btn_login);
      this.grubox_login.Location = new System.Drawing.Point(222, 177);
      this.grubox_login.Name = "grubox_login";
      this.grubox_login.Size = new System.Drawing.Size(354, 118);
      this.grubox_login.TabIndex = 1;
      this.grubox_login.TabStop = false;
      this.grubox_login.Text = "Login";
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
      // lbl_password
      // 
      this.lbl_password.AutoSize = true;
      this.lbl_password.Location = new System.Drawing.Point(17, 63);
      this.lbl_password.Name = "lbl_password";
      this.lbl_password.Size = new System.Drawing.Size(53, 13);
      this.lbl_password.TabIndex = 1;
      this.lbl_password.Text = "Password";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(78, 26);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(248, 20);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(79, 60);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(247, 20);
      this.textBox2.TabIndex = 3;
      // 
      // btn_login
      // 
      this.btn_login.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btn_login.Location = new System.Drawing.Point(143, 89);
      this.btn_login.Name = "btn_login";
      this.btn_login.Size = new System.Drawing.Size(75, 23);
      this.btn_login.TabIndex = 2;
      this.btn_login.Text = "Login";
      this.btn_login.UseVisualStyleBackColor = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.grubox_login);
      this.Controls.Add(this.lbl_title);
      this.Name = "Form1";
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
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
  }
}

