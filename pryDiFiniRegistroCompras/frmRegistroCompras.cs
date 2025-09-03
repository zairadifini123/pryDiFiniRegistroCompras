namespace pryDiFiniRegistroCompras
{
    public partial class FrmRegistroCompras : Form
    {
        public FrmRegistroCompras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.Text != "")
                nudCantidad.Enabled = true;
            else
                nudCantidad.Enabled = false;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Text != "")
                mtbPrecioUnitario.Enabled = true;
            else
                mtbPrecioUnitario.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbPrecioUnitario.Text != "")
                btnRegistrar.Enabled = true;
            else
                btnRegistrar.Enabled = false;
        }
    }
}
