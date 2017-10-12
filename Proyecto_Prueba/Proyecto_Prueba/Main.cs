using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace Proyecto_Prueba
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
            
        }

        
        Recibir recibir = new Recibir();
        Enviar enviar = new Enviar();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (enviar.Guardar_en_datos(txtNombre.Text, txtApellido.Text, txtCedula.Text, (Guid)cboPuesto.SelectedValue, Convert.ToInt16(txtEdad.Text)))
                {

                    lblEstado.Text = "Done!";
                    LimpiarControles();
                }
                else
                {

                    MessageBox.Show("El numero de cedula ya se encuentra registrado.");
                }
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LimpiarControles()
        {
            try
            {

                foreach (Control x in this.Controls)
                {

                    if (x is TextBox)
                    {

                        ((TextBox)x).Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LlenarCboPuesto()
        {
            try
            {

                recibir.Lista_de_puestos(cboPuesto);
                
            }
            catch (Exception)
            {

                throw;
            }
          


        }

        private void Main_Load(object sender, EventArgs e)
        {
            LlenarCboPuesto();
        }
    }
}
