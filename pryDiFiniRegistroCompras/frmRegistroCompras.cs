namespace pryDiFiniRegistroCompras
{
    public partial class FrmRegistroCompras : Form
    {
        public FrmRegistroCompras()
        {
            InitializeComponent();
        }

        public struct Compra
        {
            public DateTime Fecha;
            public string Producto;
            public int Cantidad;
            public int PrecioUnitario;
        }

        // Usar una matriz con espacio fijo para 10 compras
        Compra[] compras = new Compra[10];
        int indiceCompra = 0;  // Índice para la siguiente compra

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.Text != "")
                nudCantidad.Enabled = true;
            else
                nudCantidad.Enabled = false;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Text != "")
                mtbPrecioUnitario.Enabled = true;
            else
                mtbPrecioUnitario.Enabled = false;
        }

        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbPrecioUnitario.Text != "")
                btnRegistrar.Enabled = true;
            else
                btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay espacio en la matriz para más compras
            if (indiceCompra < compras.Length)
            {
                // Asignar los valores a la compra en la matriz
                compras[indiceCompra].Fecha = dtpFecha.Value;
                compras[indiceCompra].Producto = cmbProductos.Text;
                compras[indiceCompra].Cantidad = Convert.ToInt32(nudCantidad.Value);
                compras[indiceCompra].PrecioUnitario = Convert.ToInt32(mtbPrecioUnitario.Text);

                // Calcular el total de la compra
                int total = compras[indiceCompra].Cantidad * compras[indiceCompra].PrecioUnitario;

                // Mostrar los resultados en el ListBox
                lstResultados.Items.Add(
                    $"{compras[indiceCompra].Fecha:dd/MM/yyyy} - " +
                    $"{compras[indiceCompra].Producto} " +
                    $"{compras[indiceCompra].Cantidad} - " +
                    $"${compras[indiceCompra].PrecioUnitario} - " +
                    $"Total: $ {total}");

                // Mostrar un mensaje de depuración con el contenido de la matriz
                MessageBox.Show($"Compra registrada: {compras[indiceCompra].Producto}, Cantidad: {compras[indiceCompra].Cantidad}, Precio Unitario: {compras[indiceCompra].PrecioUnitario}");

                // Incrementar el índice para la siguiente compra
                indiceCompra++;
            }
            else
            {
                MessageBox.Show("Ya no se pueden registrar más compras. El límite de compras ha sido alcanzado.");
            }

            // Limpiar los campos para la siguiente compra
            cmbProductos.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mtbPrecioUnitario.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
