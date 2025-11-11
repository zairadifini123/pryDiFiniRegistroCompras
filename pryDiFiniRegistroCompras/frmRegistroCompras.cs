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
            if (nudCantidad.Value > 0)
                mtbPrecioUnitario.Enabled = true;
            else
                mtbPrecioUnitario.Enabled = false;
        }

        // ?? Evento corregido: se ejecuta cuando cambia el texto del precio unitario
        private void mtbPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbPrecioUnitario.Text))
                btnRegistrar.Enabled = true;
            else
                btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (indiceCompra < compras.Length)
            {
                compras[indiceCompra].Fecha = dtpFecha.Value;
                compras[indiceCompra].Producto = cmbProductos.Text;
                compras[indiceCompra].Cantidad = Convert.ToInt32(nudCantidad.Value);
                compras[indiceCompra].PrecioUnitario = Convert.ToInt32(mtbPrecioUnitario.Text);

                int total = compras[indiceCompra].Cantidad * compras[indiceCompra].PrecioUnitario;

                lstResultados.Items.Add(
                    $"{compras[indiceCompra].Fecha:dd/MM/yyyy} - " +
                    $"{compras[indiceCompra].Producto} " +
                    $"{compras[indiceCompra].Cantidad} - " +
                    $"${compras[indiceCompra].PrecioUnitario} - " +
                    $"Total: $ {total}");

                MessageBox.Show($"Compra registrada: {compras[indiceCompra].Producto}, Cantidad: {compras[indiceCompra].Cantidad}, Precio Unitario: {compras[indiceCompra].PrecioUnitario}");

                indiceCompra++;
            }
            else
            {
                MessageBox.Show("Ya no se pueden registrar más compras. El límite de compras ha sido alcanzado.");
            }

            cmbProductos.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mtbPrecioUnitario.Clear();
            btnRegistrar.Enabled = false;
            nudCantidad.Enabled = false;
            mtbPrecioUnitario.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

