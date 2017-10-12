using PruebaMaintBZ.Data.DataObject;
using PruebaMaintBZ.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMaintBZ
{
	public partial class frmEnviar : Form
	{
		public frmEnviar()
		{
			InitializeComponent();
		}

		private void frmEnviar_Load(object sender, EventArgs e)
		{
			Database.SetInitializer<DemoContext>( new CreateDatabaseIfNotExists<DemoContext>() );

		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			AddCliente();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form frmConsulta = new frmConsultar();
			frmConsulta.Show();

		}

		private void AddCliente()
		{
			try
			{
				if ( IsAllTextBoxesFilled() )
				{
					if ( !IsExistedInDataBase() )
					{
						DemoContext dbContext = new DemoContext();

						var persona = new Person()
						{
							Id = Guid.NewGuid(),
							Nombre = txtNombres.Text,
							Apellidos = txtApellidos.Text,
							Direccion = txtDireccion.Text,
							Ocupacion = txtOcupacion.Text,
							Nacionalidad = txtNacionalidad.Text
						};

						dbContext.People.Add( persona );
						dbContext.SaveChanges();
						UpdateEstado( true );
						ClearAllTextBox();

					}
					else
					{
						UpdateEstado( false );
					}
				}

			}
			catch ( Exception )
			{

				throw;
			}

		}

		private bool IsAllTextBoxesFilled()
		{
			foreach ( Control x in Controls )         //Realiza la operacion por cada control que hay en el formulario.
			{
				if ( x is TextBox )                //Ejecuta la operacion solo si el control es de tipo TextBox.
				{
					if ( x.Text == string.Empty )
					{
						return false;
					}

				}
                
			}
			return true;
		}

		private bool IsExistedInDataBase()
		{
			try
			{
				DemoContext dbContext = new DemoContext();

				var peopleList = from people in dbContext.People
								 select people;

				foreach ( var p in peopleList )
				{
					if ( ( IsTheSameString( p.Nombre, txtNombres.Text ) )
						&& ( IsTheSameString( p.Apellidos, txtApellidos.Text ) ) )
					{

						return true;
					}
				}

				return false;
			}
			catch ( Exception )
			{

				throw;
			}
		}

		public bool IsTheSameString(string cadenaGuardada, string cadenaPorGuardar)
		{
			cadenaGuardada = ReducirEspaciado( cadenaGuardada ).ToUpper();
			cadenaPorGuardar = ReducirEspaciado( cadenaPorGuardar ).ToUpper();

			if ( cadenaGuardada == cadenaPorGuardar )
			{
				return true;
			}

			return false;
		}

		private void UpdateEstado(bool result)
		{
			if ( result == true )
			{
				lblEstado.Text = "Transmision Exitosa!";
			}
			else
			{
				lblEstado.Text = "Transmision Cancelada!";
			}

		}

		private void ClearAllTextBox()
		{
			try
			{
				foreach ( Control x in Controls )    //Realiza la operacion por cada control que hay en el formulario.
				{
					if ( x is TextBox )              //Ejecuta la operacion solo si el control es de tipo TextBox.
					{
						( ( TextBox ) x ).Clear();
					}
				}
			}
			catch ( Exception ex )
			{

				MessageBox.Show( $"Se detecto error en: \n {ex}" );
			}
		}

		public static string ReducirEspaciado(string Cadena)
		{
			while ( Cadena.Contains( " " ) )
			{
				Cadena = Cadena.Replace( " ", "" );
			}

			return Cadena;
		}


	}
}
