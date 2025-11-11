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
            lstResultados = new ListBox();
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
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.ControlText;
            lblFecha.Location = new Point(12, 76);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(56, 74);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(82, 23);
            dtpFecha.TabIndex = 2;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(12, 110);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(13, 148);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(13, 188);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(84, 15);
            lblPrecioUnitario.TabIndex = 7;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(180, 228);
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
            nudCantidad.Location = new Point(74, 146);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(67, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(103, 188);
            mtbPrecioUnitario.Mask = "000000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(38, 23);
            mtbPrecioUnitario.TabIndex = 11;
            mtbPrecioUnitario.TextChanged += mtbPrecioUnitario_TextChanged;
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Items.AddRange(new object[] { "Papa", "Lechuga", "Tomate" });
            cmbProductos.Location = new Point(74, 107);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(223, 23);
            cmbProductos.TabIndex = 12;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 228);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(12, 257);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(292, 94);
            lstResultados.TabIndex = 14;
            // 
            // FrmRegistroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(321, 373);
            Controls.Add(lstResultados);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmRegistroCompras";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ListBox lstResultados;
    }
}
