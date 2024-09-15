namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Producto[] productosArray = new Producto[0];
        Venta[] ventasArray = new Venta[0];
        Producto productoActual;

        public Form1()
        {
            InitializeComponent();

            dgProductos.Columns.Clear();
            dgProductos.Rows.Clear();

            dgProductos.Columns.Add("Producto", "Producto");
            dgProductos.Columns.Add("Cantidad", "Cantidad");
            dgProductos.Columns.Add("Valor", "Valor");

            btnAgregarProducto.Enabled = false;
            btnQuitarProducto.Enabled = false;
            txtCantidadVendida.Enabled = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            productosArray = AgregarProducto(productosArray, txtProducto.Text, int.Parse(txtValorUnitario.Text));
            ActualizarComboBox();
            txtProducto.Text = "";
            txtValorUnitario.Text = "";
        }
        private void ActualizarComboBox()
        {
            cmbProductos.Items.Clear();
            for (int i = 0; i < productosArray.Length; i++)
            {
                cmbProductos.Items.Add(productosArray[i].ToString());
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            productosArray = EliminarProducto(productosArray, productosArray[cmbProductos.SelectedIndex]);
            cmbProductos.SelectedIndex = -1;
            ActualizarComboBox();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            deshabilitarBtnAgregarProducto();
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            deshabilitarBtnAgregarProducto();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            ventasArray = AgregarVenta(ventasArray, productoActual, int.Parse(txtCantidadVendida.Text));
            llenarDataGrid();
            deshabilitarBtnQuitarProducto();

            txtCantidadVendida.Text = "";
        }

        private void deshabilitarTxtCantidadVenta()
        {
            if (cmbProductos.SelectedIndex == -1) txtCantidadVendida.Enabled = false;
            else txtCantidadVendida.Enabled = true;
        }

        private void deshabilitarBtnAgregarProducto()
        {
            if (txtProducto.Text.Length == 0 || txtValorUnitario.Text.Length == 0) btnAgregarProducto.Enabled = false;
            else btnAgregarProducto.Enabled = true;
        }

        private void deshabilitarBtnQuitarProducto()
        {
            if (cmbProductos.SelectedIndex == -1) btnQuitarProducto.Enabled = false;
            else btnQuitarProducto.Enabled = !calcularSiTieneVentas();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarProductoSeleccionado();
            deshabilitarBtnQuitarProducto();
            deshabilitarTxtCantidadVenta();
        }

        private void btnProductoMenosIngresos_Click(object sender, EventArgs e)
        {
            if (ventasArray.Length == 0)
            {
                txtProductoMenosIngresos.Text = "No hay datos de ventas o ingresos no disponibles.";
                return;
            }

            int[] ingresos = new int[productosArray.Length];
            Producto[] productosConMenosIngresos = new Producto[productosArray.Length];
            int count = 0;

            foreach (var venta in ventasArray)
            {
                int index = Array.IndexOf(productosArray, venta.Producto);
                if (index != -1) ingresos[index] += venta.Valor;
            }

            int minIngreso = int.MaxValue;
            for (int i = 0; i < ingresos.Length; i++)
            {
                if (ingresos[i] < minIngreso && ingresos[i] > 0)
                {
                    minIngreso = ingresos[i];
                }
            }

            for (int i = 0; i < ingresos.Length; i++)
            {
                if (ingresos[i] == minIngreso)
                {
                    productosConMenosIngresos[count++] = productosArray[i];
                }
            }

            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    txtProductoMenosIngresos.Text = $"{productosConMenosIngresos[i].NombreProducto} - ${minIngreso.ToString("N0")}, ";
                }
            }
        }

        private void btnProductoMasVendido_Click(object sender, EventArgs e)
        {
            if (ventasArray.Length == 0)
            {
                txtProductoMasVendido.Text = "No hay datos de ventas o ingresos no disponibles.";
                return;
            }

            int[] cantidades = new int[productosArray.Length];

            foreach (var venta in ventasArray)
            {
                int index = Array.IndexOf(productosArray, venta.Producto);
                cantidades[index] += venta.Cantidad;
            }

            int maxCantidad = -1;
            Producto productoMasVendido = null;

            for (int i = 0; i < productosArray.Length; i++)
            {
                if (cantidades[i] > maxCantidad)
                {
                    maxCantidad = cantidades[i];
                    productoMasVendido = productosArray[i];
                }
            }

            txtProductoMasVendido.Text = $"{productoMasVendido.NombreProducto} - {maxCantidad}";
        }

        private void llenarDataGrid()
        {
            dgProductos.Rows.Clear();
            foreach (var venta in ventasArray)
            {
                object[] fila = { venta.Producto.NombreProducto, venta.Cantidad, venta.Valor };
                dgProductos.Rows.Add(fila);
            }
        }

        private void actualizarProductoSeleccionado()
        {
            if (cmbProductos.SelectedIndex == -1) productoActual = null;
            else productoActual = productosArray[cmbProductos.SelectedIndex];
        }

        private bool calcularSiTieneVentas()
        {
            bool tieneVentas = false;

            foreach (var venta in ventasArray)
            {
                if (venta.Producto == productoActual) tieneVentas = true;
            }

            return tieneVentas;
        }

        private Producto[] AgregarProducto(Producto[] arr, string nombreProducto, int valorUnitario)
        {
            Producto[] nuevoArreglo = new Producto[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                nuevoArreglo[i] = arr[i];
            }
            nuevoArreglo[arr.Length] = new Producto(nombreProducto, valorUnitario);
            return nuevoArreglo;
        }

        private Producto[] EliminarProducto(Producto[] productos, Producto producto)
        {
            Producto[] nuevoArreglo = new Producto[productos.Length - 1];
            int index = 0;

            foreach (var prod in productos)
            {
                if (!prod.Equals(producto))
                {
                    nuevoArreglo[index++] = prod;
                }
            }

            return nuevoArreglo;
        }

        private Venta[] AgregarVenta(Venta[] arr, Producto producto, int cantidad)
        {
            Venta[] nuevoArreglo = new Venta[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                nuevoArreglo[i] = arr[i];
            }
            nuevoArreglo[arr.Length] = new Venta(producto, cantidad);
            return nuevoArreglo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

