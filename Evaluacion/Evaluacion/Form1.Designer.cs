namespace Evaluacion
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProducto = new TextBox();
            txtValorUnitario = new TextBox();
            txtCantidadVendida = new TextBox();
            cmbProductos = new ComboBox();
            btnAgregarProducto = new Button();
            btnQuitarProducto = new Button();
            btnAgregarVenta = new Button();
            dgProductos = new DataGridView();
            btnProductoMasVendido = new Button();
            btnProductoMenosIngresos = new Button();
            txtProductoMasVendido = new TextBox();
            txtProductoMenosIngresos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 92);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Valor unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 135);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 171);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Cantidad vendida";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(255, 192, 192);
            txtProducto.Location = new Point(154, 43);
            txtProducto.Margin = new Padding(3, 4, 3, 4);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(468, 27);
            txtProducto.TabIndex = 4;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.BackColor = Color.Yellow;
            txtValorUnitario.Location = new Point(328, 81);
            txtValorUnitario.Margin = new Padding(3, 4, 3, 4);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(114, 27);
            txtValorUnitario.TabIndex = 5;
            txtValorUnitario.TextChanged += txtValorUnitario_TextChanged;
            // 
            // txtCantidadVendida
            // 
            txtCantidadVendida.BackColor = Color.Silver;
            txtCantidadVendida.Location = new Point(343, 167);
            txtCantidadVendida.Margin = new Padding(3, 4, 3, 4);
            txtCantidadVendida.Name = "txtCantidadVendida";
            txtCantidadVendida.Size = new Size(81, 27);
            txtCantidadVendida.TabIndex = 6;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.FromArgb(128, 255, 255);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(255, 124);
            cmbProductos.Margin = new Padding(3, 4, 3, 4);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(250, 28);
            cmbProductos.TabIndex = 7;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.ForeColor = Color.FromArgb(0, 0, 192);
            btnAgregarProducto.Location = new Point(711, 41);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(170, 31);
            btnAgregarProducto.TabIndex = 8;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.ForeColor = Color.Red;
            btnQuitarProducto.Location = new Point(751, 135);
            btnQuitarProducto.Margin = new Padding(3, 4, 3, 4);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(86, 31);
            btnQuitarProducto.TabIndex = 9;
            btnQuitarProducto.Text = "Quitar";
            btnQuitarProducto.UseVisualStyleBackColor = true;
            btnQuitarProducto.Click += btnQuitarProducto_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.ForeColor = Color.FromArgb(0, 192, 0);
            btnAgregarVenta.Location = new Point(731, 173);
            btnAgregarVenta.Margin = new Padding(3, 4, 3, 4);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(119, 31);
            btnAgregarVenta.TabIndex = 10;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // dgProductos
            // 
            dgProductos.BackgroundColor = SystemColors.HotTrack;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(178, 247);
            dgProductos.Margin = new Padding(3, 4, 3, 4);
            dgProductos.Name = "dgProductos";
            dgProductos.RowHeadersWidth = 51;
            dgProductos.Size = new Size(482, 200);
            dgProductos.TabIndex = 11;
            // 
            // btnProductoMasVendido
            // 
            btnProductoMasVendido.BackColor = Color.DarkOrange;
            btnProductoMasVendido.Location = new Point(53, 489);
            btnProductoMasVendido.Margin = new Padding(3, 4, 3, 4);
            btnProductoMasVendido.Name = "btnProductoMasVendido";
            btnProductoMasVendido.Size = new Size(187, 31);
            btnProductoMasVendido.TabIndex = 12;
            btnProductoMasVendido.Text = "Producto Más Vendido";
            btnProductoMasVendido.UseVisualStyleBackColor = false;
            btnProductoMasVendido.Click += btnProductoMasVendido_Click;
            // 
            // btnProductoMenosIngresos
            // 
            btnProductoMenosIngresos.BackColor = Color.Peru;
            btnProductoMenosIngresos.Location = new Point(56, 532);
            btnProductoMenosIngresos.Margin = new Padding(3, 4, 3, 4);
            btnProductoMenosIngresos.Name = "btnProductoMenosIngresos";
            btnProductoMenosIngresos.Size = new Size(184, 31);
            btnProductoMenosIngresos.TabIndex = 13;
            btnProductoMenosIngresos.Text = "Producto Menos Ingresos";
            btnProductoMenosIngresos.UseVisualStyleBackColor = false;
            btnProductoMenosIngresos.Click += btnProductoMenosIngresos_Click;
            // 
            // txtProductoMasVendido
            // 
            txtProductoMasVendido.BackColor = Color.Red;
            txtProductoMasVendido.Enabled = false;
            txtProductoMasVendido.Location = new Point(255, 489);
            txtProductoMasVendido.Margin = new Padding(3, 4, 3, 4);
            txtProductoMasVendido.Name = "txtProductoMasVendido";
            txtProductoMasVendido.Size = new Size(405, 27);
            txtProductoMasVendido.TabIndex = 14;
            // 
            // txtProductoMenosIngresos
            // 
            txtProductoMenosIngresos.BackColor = Color.Blue;
            txtProductoMenosIngresos.Enabled = false;
            txtProductoMenosIngresos.Location = new Point(255, 533);
            txtProductoMenosIngresos.Margin = new Padding(3, 4, 3, 4);
            txtProductoMenosIngresos.Name = "txtProductoMenosIngresos";
            txtProductoMenosIngresos.Size = new Size(405, 27);
            txtProductoMenosIngresos.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            BackgroundImage = Properties.Resources.Magistral;
            ClientSize = new Size(914, 600);
            Controls.Add(txtProductoMenosIngresos);
            Controls.Add(txtProductoMasVendido);
            Controls.Add(btnProductoMenosIngresos);
            Controls.Add(btnProductoMasVendido);
            Controls.Add(dgProductos);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnQuitarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(cmbProductos);
            Controls.Add(txtCantidadVendida);
            Controls.Add(txtValorUnitario);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(192, 0, 0);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private TextBox txtValorUnitario;
        private TextBox txtCantidadVendida;
        private ComboBox cmbProductos;
        private Button btnAgregarProducto;
        private Button btnQuitarProducto;
        private Button btnAgregarVenta;
        private DataGridView dgProductos;
        private Button btnProductoMasVendido;
        private Button btnProductoMenosIngresos;
        private TextBox txtProductoMasVendido;
        private TextBox txtProductoMenosIngresos;
    }
}
