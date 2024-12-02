namespace SugarStock
{
    partial class Forms
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IsIncorrect = new System.Windows.Forms.Label();
            this.btnlookpass = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderPANEL = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.BtnMAX = new FontAwesome.Sharp.IconButton();
            this.Btnexit = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.HeaderPANEL.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.Font = new System.Drawing.Font("Montserrat SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(121, 107);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(206, 48);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "LOGIN IN";
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LblUsername.Location = new System.Drawing.Point(24, 210);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(119, 26);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(24, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // TxtUser
            // 
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.LightGray;
            this.TxtUser.Location = new System.Drawing.Point(29, 239);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(370, 32);
            this.TxtUser.TabIndex = 3;
            this.TxtUser.Text = "Username:";
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.TxtPassword.Location = new System.Drawing.Point(29, 337);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(370, 33);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.Text = "Password:";
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Location = new System.Drawing.Point(130, 465);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(151, 40);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login in";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnCreate_MouseLeave);
            this.BtnLogin.MouseHover += new System.EventHandler(this.BtnCreate_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.IsIncorrect);
            this.panel2.Controls.Add(this.btnlookpass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtUser);
            this.panel2.Controls.Add(this.LblUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.LblUsername);
            this.panel2.Controls.Add(this.TxtPassword);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(233, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 574);
            this.panel2.TabIndex = 0;
            // 
            // IsIncorrect
            // 
            this.IsIncorrect.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsIncorrect.ForeColor = System.Drawing.Color.Red;
            this.IsIncorrect.Location = new System.Drawing.Point(3, 408);
            this.IsIncorrect.Name = "IsIncorrect";
            this.IsIncorrect.Size = new System.Drawing.Size(429, 54);
            this.IsIncorrect.TabIndex = 10;
            this.IsIncorrect.Text = "USUARIO O CONTRASEÑA INCORRECTAS";
            this.IsIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IsIncorrect.Visible = false;
            // 
            // btnlookpass
            // 
            this.btnlookpass.BackColor = System.Drawing.SystemColors.Window;
            this.btnlookpass.Enabled = false;
            this.btnlookpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlookpass.ForeColor = System.Drawing.SystemColors.Window;
            this.btnlookpass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnlookpass.IconColor = System.Drawing.Color.White;
            this.btnlookpass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlookpass.IconSize = 1;
            this.btnlookpass.Location = new System.Drawing.Point(355, 341);
            this.btnlookpass.Name = "btnlookpass";
            this.btnlookpass.Size = new System.Drawing.Size(38, 26);
            this.btnlookpass.TabIndex = 9;
            this.btnlookpass.UseVisualStyleBackColor = false;
            this.btnlookpass.Click += new System.EventHandler(this.btnlookpass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Introduzca sus credenciales";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(130, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SugarStock.Properties.Resources.Component_3;
            this.pictureBox1.Location = new System.Drawing.Point(120, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HeaderPANEL);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 625);
            this.panel1.TabIndex = 1;
            // 
            // HeaderPANEL
            // 
            this.HeaderPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.HeaderPANEL.Controls.Add(this.btnMin);
            this.HeaderPANEL.Controls.Add(this.BtnMAX);
            this.HeaderPANEL.Controls.Add(this.Btnexit);
            this.HeaderPANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPANEL.Location = new System.Drawing.Point(0, 0);
            this.HeaderPANEL.Name = "HeaderPANEL";
            this.HeaderPANEL.Size = new System.Drawing.Size(871, 26);
            this.HeaderPANEL.TabIndex = 0;
            this.HeaderPANEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPANEL_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMin.IconColor = System.Drawing.Color.Black;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMin.IconSize = 18;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMin.Location = new System.Drawing.Point(784, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 20);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // BtnMAX
            // 
            this.BtnMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMAX.FlatAppearance.BorderSize = 0;
            this.BtnMAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMAX.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.BtnMAX.IconColor = System.Drawing.Color.Black;
            this.BtnMAX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMAX.IconSize = 18;
            this.BtnMAX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMAX.Location = new System.Drawing.Point(812, 3);
            this.BtnMAX.Name = "BtnMAX";
            this.BtnMAX.Size = new System.Drawing.Size(28, 20);
            this.BtnMAX.TabIndex = 2;
            this.BtnMAX.UseVisualStyleBackColor = true;
            this.BtnMAX.Click += new System.EventHandler(this.BtnMAX_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnexit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btnexit.FlatAppearance.BorderSize = 0;
            this.Btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnexit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.Btnexit.IconColor = System.Drawing.Color.Black;
            this.Btnexit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btnexit.IconSize = 18;
            this.Btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnexit.Location = new System.Drawing.Point(840, 3);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(28, 20);
            this.Btnexit.TabIndex = 1;
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 625);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::SugarStock.Properties.Resources.CXDDD;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(871, 625);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 625);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(887, 664);
            this.Name = "Forms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.HeaderPANEL.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnlookpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeaderPANEL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label IsIncorrect;
        private FontAwesome.Sharp.IconButton Btnexit;
        private FontAwesome.Sharp.IconButton BtnMAX;
        private FontAwesome.Sharp.IconButton btnMin;
    }
}
