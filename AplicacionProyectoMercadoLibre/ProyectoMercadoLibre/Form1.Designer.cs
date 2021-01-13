
namespace ProyectoMercadoLibre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertarRegistro = new System.Windows.Forms.Button();
            this.cbnSeleccionar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.Location = new System.Drawing.Point(727, 120);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(125, 21);
            this.btnEliminarRegistro.TabIndex = 0;
            this.btnEliminarRegistro.Text = "Eliminar Registro";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(162, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 21);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Seleccionar tabla";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(868, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnInsertarRegistro
            // 
            this.btnInsertarRegistro.BackColor = System.Drawing.Color.White;
            this.btnInsertarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRegistro.Location = new System.Drawing.Point(727, 93);
            this.btnInsertarRegistro.Name = "btnInsertarRegistro";
            this.btnInsertarRegistro.Size = new System.Drawing.Size(125, 21);
            this.btnInsertarRegistro.TabIndex = 3;
            this.btnInsertarRegistro.Text = "Insertar Registro";
            this.btnInsertarRegistro.UseVisualStyleBackColor = false;
            this.btnInsertarRegistro.Click += new System.EventHandler(this.btnInsertarRegistro_Click);
            // 
            // cbnSeleccionar
            // 
            this.cbnSeleccionar.FormattingEnabled = true;
            this.cbnSeleccionar.Items.AddRange(new object[] {
            "Almacen\t\t\t\t\t\t\t\t\t\t",
            "Area \t\t\t\t\t\t\t\t\t\t",
            "Articulo\t\t\t\t\t\t\t\t\t\t",
            "Ascenso\t\t\t\t\t\t\t\t\t\t",
            "Aseguradora\t\t\t\t\t\t\t\t\t\t",
            "Camion\t\t\t\t\t\t\t\t\t",
            "Camionero",
            "Categoria\t\t\t\t\t\t\t\t\t",
            "Cliente\t\t\t\t\t\t\t\t\t\t\t",
            "Cobranza\t\t\t\t\t\t\t\t\t\t",
            "Contratacion\t\t\t\t\t\t\t\t\t\t\t",
            "Contrato",
            "ControlDeCalidad\t\t\t\t\t\t\t\t\t\t",
            "Coordinacion\t\t\t\t\t\t\t\t\t\t\t",
            "Costo\t\t\t\t\t\t\t\t\t\t\t",
            "Cuenta\t\t\t\t\t\t\t\t\t\t\t",
            "Departamento\t\t\t\t\t\t\t\t",
            "DetalleEnvio\t",
            "Devolucion\t\t\t\t\t\t\t\t\t\t\t\t",
            "Empresa",
            "Empleado\t\t\t\t\t\t\t\t\t\t\t",
            "Fabricante\t\t\t\t\t\t\t\t\t\t",
            "Factura\t\t\t\t\t\t\t\t\t\t\t",
            "Garantia\t\t\t\t\t\t\t\t\t\t",
            "GestionDeBanco\t\t\t\t\t\t\t\t\t\t\t",
            "GestionDeFinanza\t\t\t\t\t\t\t\t\t\t\t",
            "Horario\t\t\t\t\t\t\t\t\t\t\t",
            "Inventario\t\t\t\t\t\t\t\t\t\t\t",
            "Inversion\t\t\t\t\t\t\t\t\t\t\t",
            "Mantenimiento\t\t\t\t\t\t\t\t\t\t\t",
            "Movimiento\t\t\t\t\t\t\t\t\t\t",
            "Nomina\t\t\t\t\t\t\t\t\t\t\t",
            "Pago\t\t\t\t\t\t\t\t\t\t",
            "Paquete\t\t\t\t\t\t\t\t\t\t\t",
            "Pedido\t\t\t\t\t\t\t\t\t\t",
            "Prestamo\t\t\t\t\t\t\t\t\t\t\t",
            "Presupuesto\t\t\t\t\t\t\t\t\t\t\t",
            "Produccion\t\t\t\t\t\t\t\t\t\t\t",
            "Producto\t\t\t\t\t\t\t\t\t\t\t",
            "Proveedor\t\t\t\t\t\t\t\t\t\t\t",
            "Provincia\t\t\t\t\t\t\t\t\t\t",
            "Reclutamiento\t\t\t\t\t\t\t\t\t\t\t",
            "RecursosHumanos\t\t\t\t\t\t\t\t\t\t\t",
            "Salario\t\t\t\t\t\t\t\t\t\t",
            "Servicio\t\t\t\t\t\t\t\t\t\t\t",
            "Tarjeta\t\t\t\t\t\t\t\t\t\t\t",
            "TicketDeVenta\t\t\t\t\t\t\t\t\t\t\t",
            "Transferencia\t\t\t\t\t\t\t\t\t\t",
            "Venta\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "AreaDepartamento\t\t\t\t\t\t\t\t\t\t",
            "ArticuloFabricante\t\t\t\t\t\t\t\t\t\t\t",
            "ArticuloPedido\t\t\t\t\t\t\t\t\t\t\t",
            "CamioneroCamion\t\t\t\t\t\t\t\t\t\t\t",
            "DistribuidoraCliente\t\t\t\t\t\t\t\t\t\t\t",
            "DistribuidoraServicio\t\t\t\t\t\t\t\t\t\t\t",
            "PaqueteCosto\t\t\t\t\t\t\t\t\t\t",
            "\t\t\t"});
            this.cbnSeleccionar.Location = new System.Drawing.Point(12, 103);
            this.cbnSeleccionar.Name = "cbnSeleccionar";
            this.cbnSeleccionar.Size = new System.Drawing.Size(121, 21);
            this.cbnSeleccionar.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(892, 60);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Mercado Libre";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(727, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 21);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbnSeleccionar);
            this.Controls.Add(this.btnInsertarRegistro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Base de datos SQL Server";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertarRegistro;
        private System.Windows.Forms.ComboBox cbnSeleccionar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

