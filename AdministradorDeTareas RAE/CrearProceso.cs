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
	/// Description of CrearProceso.
	/// </summary>
	public partial class CrearProceso : Form
	{
		public CrearProceso()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//ABRIMOS EL EXPLORADOR DE ARCHIVOS EN CASO DE NECESITAR BUSCAR MANUALMENTE O GRAFICAMENTE EL PROCESO U APLICACION
		void PictureBox1Click(object sender, EventArgs e)
		{
			OpenFileDialog AbrirArchivo = new OpenFileDialog();
			AbrirArchivo.InitialDirectory="c:\\";//LO ABRIMOS DIRECTAMENTE EN EL DISCO LOCAL C: YA QUE EN LA MAYORIA DE LOS CASOS AQUI SE ALOJAN TODAS NUESTRAS APLICACIONES
			AbrirArchivo.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";//APLICAMOS UN FILTRO PARA QUE SOLO NOS MUESTRE ARCHIVOS CON TERMINACION .EXE
			AbrirArchivo.ShowDialog();
			if (AbrirArchivo.ShowDialog() == DialogResult.OK){//SI OBTENEMOS UN ARCHIVO GUARDAMOS LA RUTA EN TEXTPROCESO.TEXT
					string nombreArchivo = AbrirArchivo.FileName;
					textProceso.Text = nombreArchivo.ToString();
			}
			
			
			   	
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		//BOTON CREAR PROCESO
		void BtnCrearProcesoClick(object sender, EventArgs e)
		{	//MEDIANTE EL TEXTPROCESO.TEXT OBTENEMOS LA RUTA DE EL PROCESO A ABRIR Y LO EJECUTAMOS
			Process proceso = new Process();
			proceso.StartInfo.FileName = textProceso.Text;
			proceso.Start();
			textProceso.Text="";//LIMPIAMOS EL TEXTPROCESO.TEXT
		}
		//BOTON SALIR, NOS CIERRA SOLO ESTA VENTANA
		void BtnSalirClick(object sender, EventArgs e)
		{		
			this.Close();
		}
	}
}
