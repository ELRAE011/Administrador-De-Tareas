/*
 * Created by SharpDevelop.
 * User: PC06
 * Date: 24/02/2023
 * Time: 02:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace AdministradorDeTareas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CrearProcesoToolStripMenuItemClick(object sender, EventArgs e)
		{
			//MOSTRAR VENTANA DE CREAR PROCESOS
			CrearProceso crearProceso = new CrearProceso();
			crearProceso.Show();
		}
		
		void Dgv_ProcesosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//Evento DGV
			Process[] procesos = Process.GetProcesses();
				try{
				var Proc = dgv_Procesos.SelectionMode.ToString;
					ProcessThreadCollection hilos = Proc.Threads;
					foreach(ProcessThread HiloProceso in hilos){
						dgv_hilos.Rows.Add(dgv_hilos.Rows.Count,HiloProceso.Id);
					}
				}catch(Exception){	
					}
		}
		
		//BOTON ACTUALIZAR PROCESOS ANTIGUO
		void Btn_actualizar_procesosClick(object sender, EventArgs e)
		{

		}
		
		void Txt_countProcesosTextChanged(object sender, EventArgs e)
		{
		}
		
		void Lbl_cuentaClick(object sender, EventArgs e)
		{
			
		}
		
		void Btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SalirToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ayuda ayuda = new Ayuda();
			ayuda.Show();
		}
		
		void EliminarProcesoToolStripMenuItemClick(object sender, EventArgs e)
		{
			EliminarProceso eliminarProceso = new EliminarProceso();
			eliminarProceso.Show();
		}
		//INICIAMOS DIRECTAMENTE LOS DATOS DEL GRID VIEW
		void MainFormLoad(object sender, EventArgs e)
		{
			Process[] procesos = Process.GetProcesses();
			dgv_Procesos.Rows.Clear();//AL ACTUALIZAR LIMPIAMOS LOS PROCESOS
			foreach(Process proceso in procesos){
				try{
					dgv_Procesos.Rows.Add(dgv_Procesos.RowCount,proceso.Id,proceso.ProcessName,proceso.VirtualMemorySize64,proceso.TotalProcessorTime);//MOSTRAMOS UN INDEX,ID,NOMBRE
				}catch(Exception){
					MessageBox.Show("Error");
				}
			}
			//LABEL DE SUMA DE PROCESOS
			int cuenta = dgv_Procesos.Rows.Count;
			lbl_cuenta.Text = cuenta.ToString();	
		}
		//BOTON ACTUALIZAR PROCESOS NUEVO PARA ACTUALIZAR EL ADMINISTRADOR
		void BtnActualizarClick(object sender, EventArgs e)
		{
			Process[] procesos = Process.GetProcesses();
			dgv_Procesos.Rows.Clear();//AL ACTUALIZAR LIMPIAMOS LOS PROCESOS
			foreach(Process proceso in procesos){
				try{
					dgv_Procesos.Rows.Add(dgv_Procesos.RowCount,proceso.Id,proceso.ProcessName,proceso.VirtualMemorySize64,proceso.TotalProcessorTime);//MOSTRAMOS UN INDEX,ID,NOMBRE
				}catch(Exception){
					Console.WriteLine("Error");					
				}
			}
			//LABEL DE SUMA DE PROCESOS
			int cuenta = dgv_Procesos.Rows.Count;
			lbl_cuenta.Text = cuenta.ToString();	
		}
		void Dgv_hilosCellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
	}
}