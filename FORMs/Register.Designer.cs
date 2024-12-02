namespace SugarStock.FORMs
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderPANEL = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConfirm = new System.Windows.Forms.TextBox();
            this.btnlookpass = new FontAwesome.Sharp.IconButton();
            this.BtnlookpasCFM = new FontAwesome.Sharp.IconButton();
            this.IsIncorrect = new System.Windows.Forms.Label();
            this.Btnexit = new FontAwesome.Sharp.IconButton();
            this.BtnMAX = new FontAwesome.Sharp.IconButton();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.HeaderPANEL.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.HeaderPANEL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 625);
            this.panel1.TabIndex = 0;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 599);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SugarStock.Properties.Resources.FONDO2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.panel4.Controls.Add(this.IsIncorrect);
            this.panel4.Controls.Add(this.BtnlookpasCFM);
            this.panel4.Controls.Add(this.btnlookpass);
            this.panel4.Controls.Add(this.TxtConfirm);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BtnRegister);
            this.panel4.Controls.Add(this.BtnLogin);
            this.panel4.Controls.Add(this.TxtPassword);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TxtUser);
            this.panel4.Controls.Add(this.LblUsername);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.LblUser);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(218, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 574);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SugarStock.Properties.Resources.Component_3;
            this.pictureBox2.Location = new System.Drawing.Point(120, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // LblUser
            // 
            this.LblUser.Font = new System.Drawing.Font("Montserrat SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(121, 107);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(206, 48);
            this.LblUser.TabIndex = 8;
            this.LblUser.Text = "REGISTER";
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cree sus credenciales";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LblUsername.Location = new System.Drawing.Point(25, 211);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(191, 26);
            this.LblUsername.TabIndex = 10;
            this.LblUsername.Text = "Enter a username:";
            // 
            // TxtUser
            // 
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.LightGray;
            this.TxtUser.Location = new System.Drawing.Point(30, 239);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(379, 32);
            this.TxtUser.TabIndex = 11;
            this.TxtUser.Text = "Username:";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(25, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter a password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.TxtPassword.Location = new System.Drawing.Point(30, 302);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(379, 33);
            this.TxtPassword.TabIndex = 13;
            this.TxtPassword.Text = "Password:";
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Location = new System.Drawing.Point(131, 511);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(151, 40);
            this.BtnLogin.TabIndex = 14;
            this.BtnLogin.Text = "Login in";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRegister.Location = new System.Drawing.Point(130, 465);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(151, 40);
            this.BtnRegister.TabIndex = 15;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(25, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm the password:";
            // 
            // TxtConfirm
            // 
            this.TxtConfirm.BackColor = System.Drawing.Color.White;
            this.TxtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirm.ForeColor = System.Drawing.Color.LightGray;
            this.TxtConfirm.Location = new System.Drawing.Point(30, 366);
            this.TxtConfirm.Multiline = true;
            this.TxtConfirm.Name = "TxtConfirm";
            this.TxtConfirm.Size = new System.Drawing.Size(379, 33);
            this.TxtConfirm.TabIndex = 17;
            this.TxtConfirm.Text = "Confirm password:";
            this.TxtConfirm.TextChanged += new System.EventHandler(this.TxtConfirm_TextChanged);
            this.TxtConfirm.Enter += new System.EventHandler(this.TxtConfirm_Enter);
            this.TxtConfirm.Leave += new System.EventHandler(this.TxtConfirm_Leave);
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
            this.btnlookpass.Location = new System.Drawing.Point(368, 306);
            this.btnlookpass.Name = "btnlookpass";
            this.btnlookpass.Size = new System.Drawing.Size(38, 26);
            this.btnlookpass.TabIndex = 18;
            this.btnlookpass.UseVisualStyleBackColor = false;
            this.btnlookpass.Click += new System.EventHandler(this.btnlookpass_Click);
            // 
            // BtnlookpasCFM
            // 
            this.BtnlookpasCFM.BackColor = System.Drawing.SystemColors.Window;
            this.BtnlookpasCFM.Enabled = false;
            this.BtnlookpasCFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnlookpasCFM.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnlookpasCFM.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnlookpasCFM.IconColor = System.Drawing.Color.White;
            this.BtnlookpasCFM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnlookpasCFM.IconSize = 1;
            this.BtnlookpasCFM.Location = new System.Drawing.Point(367, 370);
            this.BtnlookpasCFM.Name = "BtnlookpasCFM";
            this.BtnlookpasCFM.Size = new System.Drawing.Size(38, 26);
            this.BtnlookpasCFM.TabIndex = 19;
            this.BtnlookpasCFM.UseVisualStyleBackColor = false;
            this.BtnlookpasCFM.Click += new System.EventHandler(this.BtnlookpasCFM_Click);
            // 
            // IsIncorrect
            // 
            this.IsIncorrect.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsIncorrect.ForeColor = System.Drawing.Color.Red;
            this.IsIncorrect.Location = new System.Drawing.Point(3, 408);
            this.IsIncorrect.Name = "IsIncorrect";
            this.IsIncorrect.Size = new System.Drawing.Size(429, 54);
            this.IsIncorrect.TabIndex = 20;
            this.IsIncorrect.Text = "USUARIO O CONTRASEÑA INCORRECTAS";
            this.IsIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IsIncorrect.Visible = false;
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
            this.Btnexit.Location = new System.Drawing.Point(843, 3);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(28, 20);
            this.Btnexit.TabIndex = 2;
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
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
            this.BtnMAX.TabIndex = 3;
            this.BtnMAX.UseVisualStyleBackColor = true;
            this.BtnMAX.Click += new System.EventHandler(this.BtnMAX_Click);
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
            this.btnMin.Location = new System.Drawing.Point(782, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 20);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 625);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(887, 664);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.HeaderPANEL.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeaderPANEL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxtConfirm;
        private FontAwesome.Sharp.IconButton BtnlookpasCFM;
        private FontAwesome.Sharp.IconButton btnlookpass;
        private System.Windows.Forms.Label IsIncorrect;
        private FontAwesome.Sharp.IconButton Btnexit;
        private FontAwesome.Sharp.IconButton BtnMAX;
        private FontAwesome.Sharp.IconButton btnMin;
    }
}