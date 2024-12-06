namespace SugarStock.FORMs
{
    partial class Carrito
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
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.BtnRport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.RowHeadersWidth = 51;
            this.dataGridViewCarrito.RowTemplate.Height = 24;
            this.dataGridViewCarrito.Size = new System.Drawing.Size(617, 642);
            this.dataGridViewCarrito.TabIndex = 0;
            this.dataGridViewCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrito_CellContentClick);
            this.dataGridViewCarrito.VisibleChanged += new System.EventHandler(this.dataGridViewCarrito_VisibleChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmar.Location = new System.Drawing.Point(881, 570);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(90, 41);
            this.buttonConfirmar.TabIndex = 2;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.Location = new System.Drawing.Point(993, 570);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 41);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRport);
            this.panel1.Controls.Add(this.LabelTotal);
            this.panel1.Controls.Add(this.buttonConfirmar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.dataGridViewCarrito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 642);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(547, 140);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(0, 13);
            this.LabelTotal.TabIndex = 4;
            this.LabelTotal.Click += new System.EventHandler(this.LabelTotal_Click);
            // 
            // BtnRport
            // 
            this.BtnRport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRport.Location = new System.Drawing.Point(778, 570);
            this.BtnRport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRport.Name = "BtnRport";
            this.BtnRport.Size = new System.Drawing.Size(90, 41);
            this.BtnRport.TabIndex = 5;
            this.BtnRport.Text = "Ver Factura";
            this.BtnRport.UseVisualStyleBackColor = true;
            this.BtnRport.Click += new System.EventHandler(this.BtnRport_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 642);
            this.Controls.Add(this.panel1);
            this.Name = "Carrito";
            this.Load += new System.EventHandler(this.Carrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button BtnRport;
    }
}