/*
 * Created by SharpDevelop.
 * User: PC06
 * Date: 24/02/2023
 * Time: 02:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorDeTareas
{
	/// <summary>
	/// Description of EliminarProceso.
	/// </summary>
	public partial class EliminarProceso : Form
	{
		public EliminarProceso()
		{

			InitializeComponent();
			
		}
		
		
		void BtnSalirEliminarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		//DESCARTAMOS ESTA OPCION
		void PictureBox2EliminarClick(object sender, EventArgs e)
		{
			OpenFileDialog AbrirArchivo = new OpenFileDialog();
			AbrirArchivo.InitialDirectory="c:\\";
			AbrirArchivo.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
			AbrirArchivo.ShowDialog();
			if (AbrirArchivo.ShowDialog() == DialogResult.OK){
					string nombreArchivo = AbrirArchivo.FileName;
					txtEliminarProceso.Text = nombreArchivo.ToString();
			}
		}
		//BOTON ELIMINAR PROCESO
		void BtnEliminarProcesoClick(object sender, EventArgs e)
		{//PODEMOS ELIMINAR POR ID O POR NOMBRE PERO SOLO 1, PARA ELLO OCUPAMOS ESTE IF QUE LE DA PIORIDAD AL METODO POR ID
			if(txtEliminarProceso.Text != ""){
			int idProceso = int.Parse(txtEliminarProceso.Text);
			Process procesoEliminar = Process.GetProcessById(idProceso);
			procesoEliminar.Kill();
			//METODO POR NOMBRE
			} else if(txtEliminarProceso2.Text != ""){
				string nombreProceso = txtEliminarProceso2.Text;
				Process[] proceso = Process.GetProcessesByName(nombreProceso);
				proceso[0].Kill();
			}
			//LIMPIAMOS CAMPOS
			txtEliminarProceso.Text="";
			txtEliminarProceso2.Text="";
		}
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
