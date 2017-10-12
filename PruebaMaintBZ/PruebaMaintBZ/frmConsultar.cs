using PruebaMaintBZ.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMaintBZ
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            GetClientes();
        }

        private void GetClientes()
        {
            DemoContext dbContext = new DemoContext();

            if (textBox1.Text == string.Empty)
            {
                var peopleList = from people in dbContext.People
                                 select new DataBinding
                                 {
                                     Nombre = people.Nombre,
                                     Apellidos = people.Apellidos,
                                     Ocupacion = people.Ocupacion,
                                     Direccion = people.Direccion
                                 };
                var users = peopleList.ToList();
                dataGridView1.DataSource = users;
            }
            else
            {
                var peopleList = from people in dbContext.People
                                 where people.Nombre.ToUpper() == textBox1.Text.ToUpper()
                                 select new DataBinding
                                 {
                                     Nombre = people.Nombre,
                                     Apellidos = people.Apellidos,
                                     Ocupacion = people.Ocupacion,
                                     Direccion = people.Direccion
                                 };
                var users = peopleList.ToList();
                dataGridView1.DataSource = users;
            }


        }
        private class DataBinding
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Ocupacion { get; set; }
            public string Direccion { get; set; }
        }
    }
}
