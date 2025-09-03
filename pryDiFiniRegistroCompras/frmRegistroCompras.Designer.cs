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
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            btnRegistrar = new Button();
            nudCantidad = new NumericUpDown();
            mtbPrecioUnitario = new MaskedTextBox();
            cmbProductos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroCompras
            // 
            lblRegistroCompras.AutoSize = true;
            lblRegistroCompras.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroCompras.Location = new Point(113, 9);
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
            dtp.Location = new Point(103, 85);
            dtp.Name = "dtp";
            dtp.Size = new Size(223, 23);
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
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(51, 166);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(42, 203);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(84, 15);
            lblPrecioUnitario.TabIndex = 7;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(390, 199);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;

            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(112, 163);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 10;

            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Location = new Point(132, 200);
            mtbPrecioUnitario.Mask = "000000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(100, 23);
            mtbPrecioUnitario.TabIndex = 11;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(103, 124);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(121, 23);
            cmbProductos.TabIndex = 12;
            // 
            // FrmRegistroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 263);
            Controls.Add(cmbProductos);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(dtp);
            Controls.Add(lblFecha);
            Controls.Add(lblRegistroCompras);
            Name = "FrmRegistroCompras";
            Text = "RegistroCompras";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroCompras;
        private Label lblFecha;
        private DateTimePicker dtp;
        private Label lblProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioUnitario;
        private Label lblPrecioUnitario;
        private Button btnRegistrar;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecioUnitario;
        private ComboBox cmbProductos;
    }
}
