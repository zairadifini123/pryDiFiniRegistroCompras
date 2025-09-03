namespace pryDiFiniRegistroCompras
{
    partial class FrmRegistroCompras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistroCompras = new Label();
            lblFecha = new Label();
            dtp = new DateTimePicker();
            lblProducto = new Label();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPrecioUnitario = new TextBox();
            lblPrecioUnitario = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblRegistroCompras
            // 
            lblRegistroCompras.AutoSize = true;
            lblRegistroCompras.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroCompras.Location = new Point(146, 30);
            lblRegistroCompras.Name = "lblRegistroCompras";
            lblRegistroCompras.Size = new Size(307, 47);
            lblRegistroCompras.TabIndex = 0;
            lblRegistroCompras.Text = "Registro compras";
            lblRegistroCompras.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(50, 91);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // dtp
            // 
            dtp.Location = new Point(94, 85);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 2;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(50, 127);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(112, 124);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(280, 124);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(218, 127);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(403, 88);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 23);
            txtPrecioUnitario.TabIndex = 8;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(313, 91);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(84, 15);
            lblPrecioUnitario.TabIndex = 7;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(242, 165);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 263);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(dtp);
            Controls.Add(lblFecha);
            Controls.Add(lblRegistroCompras);
            Name = "FrmRegistroCompras";
            Text = "RegistroCompras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroCompras;
        private Label lblFecha;
        private DateTimePicker dtp;
        private Label lblProducto;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioUnitario;
        private Label lblPrecioUnitario;
        private Button btnRegistrar;
    }
}
