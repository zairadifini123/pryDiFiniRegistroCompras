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
            dtpFecha = new DateTimePicker();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            btnRegistrar = new Button();
            nudCantidad = new NumericUpDown();
            mtbPrecioUnitario = new MaskedTextBox();
            cmbProductos = new ComboBox();
            btnSalir = new Button();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroCompras
            // 
            lblRegistroCompras.BackColor = SystemColors.ActiveCaption;
            lblRegistroCompras.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroCompras.Location = new Point(-2, 0);
            lblRegistroCompras.Name = "lblRegistroCompras";
            lblRegistroCompras.Size = new Size(640, 55);
            lblRegistroCompras.TabIndex = 0;
            lblRegistroCompras.Text = "Registro compras";
            lblRegistroCompras.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.ControlText;
            lblFecha.Location = new Point(50, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(111, 68);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(82, 23);
            dtpFecha.TabIndex = 2;
            dtpFecha.ValueChanged += dtp_ValueChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(49, 110);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(350, 74);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(350, 110);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(84, 15);
            lblPrecioUnitario.TabIndex = 7;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(310, 149);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(124, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(413, 72);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(67, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(440, 110);
            mtbPrecioUnitario.Mask = "000000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(38, 23);
            mtbPrecioUnitario.TabIndex = 11;
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Items.AddRange(new object[] { "Papa", "Lechuga", "Tomate" });
            cmbProductos.Location = new Point(111, 107);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(223, 23);
            cmbProductos.TabIndex = 12;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(180, 149);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.Control;
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(49, 225);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(36, 34);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "--";
            // 
            // FrmRegistroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(638, 373);
            Controls.Add(lblResultado);
            Controls.Add(btnSalir);
            Controls.Add(cmbProductos);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(dtpFecha);
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
        private DateTimePicker dtpFecha;
        private Label lblProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioUnitario;
        private Label lblPrecioUnitario;
        private Button btnRegistrar;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecioUnitario;
        private ComboBox cmbProductos;
        private Button btnSalir;
        private Label lblResultado;
    }
}
