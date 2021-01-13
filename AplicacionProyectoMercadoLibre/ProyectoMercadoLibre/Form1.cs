using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMercadoLibre
{
    public partial class Form1 : Form
    {
        string consulta = "";
        DataSet ds = new DataSet();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = "DELETE FROM Cobranza WHERE idCobranza=3";
            Datos.AgregarDataTable(ds, consulta, "ListaCompañiasActivas", dataGridView1);
                MessageBox.Show("Se elimino el registro con idCobranza=3 de la tabla cobranza");

            }
            catch { MessageBox.Show("No esta conectada"); }
        }
    

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = "SELECT * FROM " + cbnSeleccionar.Text + " WHERE estatus=1";
                Datos.AgregarDataTable(ds, consulta, "i18050518_ArisbethLeijaGarza", dataGridView1);


            }
            catch { MessageBox.Show("No esta conectada"); }
        }

        private void btnInsertarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = "INSERT INTO Empresa (nombre,telefono,direccion ) VALUES ('Mercado Libre Asia S.A', '86667382', 'Kasumigaseki C.P. 06040');";
            Datos.AgregarDataTable(ds, consulta, "ListaCompañiasActivas",dataGridView1);
                MessageBox.Show("Se inserto un nuevo registro en la tabla empresa");

            }
            catch { MessageBox.Show("No esta conectada"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = "UPDATE Empleado SET nombre='Ariana' where idEmpleado=4;";
                Datos.AgregarDataTable(ds, consulta, "Actualizartablas", dataGridView1);
                MessageBox.Show("Se ah actualizado la tabla Empleado ");
            

            }
            catch { MessageBox.Show("No esta conectada"); }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        


       
    }
