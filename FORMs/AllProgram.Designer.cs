﻿namespace SugarStock.FORMs
{
    partial class AllProgram
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
            this.panelAside = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductsBtn = new FontAwesome.Sharp.IconButton();
            this.CartBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.MaxBtn = new FontAwesome.Sharp.IconButton();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.Btnexit = new FontAwesome.Sharp.IconButton();
            this.TabName = new System.Windows.Forms.Label();
            this.IconRef = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fillpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconRef)).BeginInit();
            this.Fillpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAside
            // 
            this.panelAside.BackColor = System.Drawing.Color.RosyBrown;
            this.panelAside.Controls.Add(this.button1);
            this.panelAside.Controls.Add(this.ProductsBtn);
            this.panelAside.Controls.Add(this.CartBtn);
            this.panelAside.Controls.Add(this.pictureBox1);
            this.panelAside.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAside.Location = new System.Drawing.Point(0, 0);
            this.panelAside.Margin = new System.Windows.Forms.Padding(0);
            this.panelAside.Name = "panelAside";
            this.panelAside.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelAside.Size = new System.Drawing.Size(175, 645);
            this.panelAside.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProductsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsBtn.FlatAppearance.BorderSize = 0;
            this.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsBtn.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.ProductsBtn.IconColor = System.Drawing.Color.Black;
            this.ProductsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductsBtn.IconSize = 32;
            this.ProductsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.Location = new System.Drawing.Point(0, 158);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ProductsBtn.Size = new System.Drawing.Size(175, 60);
            this.ProductsBtn.TabIndex = 5;
            this.ProductsBtn.Text = "Productos";
            this.ProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductsBtn.UseVisualStyleBackColor = false;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // CartBtn
            // 
            this.CartBtn.BackColor = System.Drawing.Color.Transparent;
            this.CartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartBtn.FlatAppearance.BorderSize = 0;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBtn.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.CartBtn.IconColor = System.Drawing.Color.Black;
            this.CartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CartBtn.IconSize = 32;
            this.CartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CartBtn.Location = new System.Drawing.Point(0, 98);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CartBtn.Size = new System.Drawing.Size(175, 60);
            this.CartBtn.TabIndex = 4;
            this.CartBtn.Text = "Carrito";
            this.CartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CartBtn.UseVisualStyleBackColor = false;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SugarStock.Properties.Resources.Component_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Headerpanel.Controls.Add(this.MaxBtn);
            this.Headerpanel.Controls.Add(this.MinimizeBtn);
            this.Headerpanel.Controls.Add(this.Btnexit);
            this.Headerpanel.Controls.Add(this.TabName);
            this.Headerpanel.Controls.Add(this.IconRef);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(175, 0);
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(949, 71);
            this.Headerpanel.TabIndex = 1;
            this.Headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Headerpanel_MouseDown);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MaxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.MaxBtn.IconColor = System.Drawing.Color.Black;
            this.MaxBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaxBtn.IconSize = 15;
            this.MaxBtn.Location = new System.Drawing.Point(900, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(27, 23);
            this.MaxBtn.TabIndex = 3;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimizeBtn.IconColor = System.Drawing.Color.Black;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeBtn.IconSize = 15;
            this.MinimizeBtn.Location = new System.Drawing.Point(876, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(27, 23);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnexit.FlatAppearance.BorderSize = 0;
            this.Btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnexit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.Btnexit.IconColor = System.Drawing.Color.Black;
            this.Btnexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btnexit.IconSize = 15;
            this.Btnexit.Location = new System.Drawing.Point(921, 0);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(27, 23);
            this.Btnexit.TabIndex = 0;
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // TabName
            // 
            this.TabName.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabName.Location = new System.Drawing.Point(80, 21);
            this.TabName.Name = "TabName";
            this.TabName.Size = new System.Drawing.Size(146, 32);
            this.TabName.TabIndex = 1;
            this.TabName.Text = "Home";
            this.TabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TabName.Click += new System.EventHandler(this.TabName_Click);
            // 
            // IconRef
            // 
            this.IconRef.BackColor = System.Drawing.Color.Transparent;
            this.IconRef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconRef.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconRef.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconRef.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconRef.Location = new System.Drawing.Point(42, 21);
            this.IconRef.Name = "IconRef";
            this.IconRef.Size = new System.Drawing.Size(32, 32);
            this.IconRef.TabIndex = 0;
            this.IconRef.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(175, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 7);
            this.panel1.TabIndex = 2;
            // 
            // Fillpanel
            // 
            this.Fillpanel.BackColor = System.Drawing.Color.MistyRose;
            this.Fillpanel.Controls.Add(this.pictureBox2);
            this.Fillpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fillpanel.Location = new System.Drawing.Point(175, 78);
            this.Fillpanel.Name = "Fillpanel";
            this.Fillpanel.Size = new System.Drawing.Size(949, 567);
            this.Fillpanel.TabIndex = 3;
            this.Fillpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Fillpanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::SugarStock.Properties.Resources.Component_3;
            this.pictureBox2.Location = new System.Drawing.Point(272, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(468, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // AllProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 645);
            this.Controls.Add(this.Fillpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.panelAside);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1140, 683);
            this.Name = "AllProgram";
            this.Text = "AllProgram";
            this.panelAside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconRef)).EndInit();
            this.Fillpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAside;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ProductsBtn;
        private FontAwesome.Sharp.IconButton CartBtn;
        private System.Windows.Forms.Panel Headerpanel;
        private FontAwesome.Sharp.IconPictureBox IconRef;
        private System.Windows.Forms.Label TabName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Fillpanel;
        private FontAwesome.Sharp.IconButton Btnexit;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
        private FontAwesome.Sharp.IconButton MaxBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}