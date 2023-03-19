/*
 * Created by SharpDevelop.
 * User: PC06
 * Date: 24/02/2023
 * Time: 02:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AdministradorDeTareas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crearProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dgv_Procesos = new System.Windows.Forms.DataGridView();
			this.index_procesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_procesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre_procesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.memoriaVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tiempoProcesador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_1 = new System.Windows.Forms.Label();
			this.lbl_cuenta = new System.Windows.Forms.Label();
			this.btn_salir = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.dgv_hilos = new System.Windows.Forms.DataGridView();
			this.index_dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_2 = new System.Windows.Forms.Label();
			this.index_dgv_hilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_dgv_hilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Procesos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_hilos)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.opcionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.crearProcesoToolStripMenuItem,
									this.eliminarProcesoToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// crearProcesoToolStripMenuItem
			// 
			this.crearProcesoToolStripMenuItem.Name = "crearProcesoToolStripMenuItem";
			this.crearProcesoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.crearProcesoToolStripMenuItem.Text = "Crear Proceso";
			this.crearProcesoToolStripMenuItem.Click += new System.EventHandler(this.CrearProcesoToolStripMenuItemClick);
			// 
			// eliminarProcesoToolStripMenuItem
			// 
			this.eliminarProcesoToolStripMenuItem.Name = "eliminarProcesoToolStripMenuItem";
			this.eliminarProcesoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.eliminarProcesoToolStripMenuItem.Text = "Eliminar Proceso";
			this.eliminarProcesoToolStripMenuItem.Click += new System.EventHandler(this.EliminarProcesoToolStripMenuItemClick);
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem,
									this.salirToolStripMenuItem1});
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.salirToolStripMenuItem.Text = "Ayuda";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem1
			// 
			this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
			this.salirToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
			this.salirToolStripMenuItem1.Text = "Salir";
			this.salirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem1Click);
			// 
			// dgv_Procesos
			// 
			this.dgv_Procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Procesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.index_procesos,
									this.id_procesos,
									this.nombre_procesos,
									this.memoriaVirtual,
									this.tiempoProcesador});
			this.dgv_Procesos.Location = new System.Drawing.Point(0, 27);
			this.dgv_Procesos.Name = "dgv_Procesos";
			this.dgv_Procesos.Size = new System.Drawing.Size(653, 694);
			this.dgv_Procesos.TabIndex = 1;
			this.dgv_Procesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProcesosCellContentClick);
			// 
			// index_procesos
			// 
			this.index_procesos.HeaderText = "INDEX";
			this.index_procesos.Name = "index_procesos";
			this.index_procesos.ReadOnly = true;
			// 
			// id_procesos
			// 
			this.id_procesos.HeaderText = "ID ";
			this.id_procesos.Name = "id_procesos";
			this.id_procesos.ReadOnly = true;
			// 
			// nombre_procesos
			// 
			this.nombre_procesos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.nombre_procesos.HeaderText = "PROCESOS";
			this.nombre_procesos.Name = "nombre_procesos";
			this.nombre_procesos.ReadOnly = true;
			this.nombre_procesos.Width = 91;
			// 
			// memoriaVirtual
			// 
			this.memoriaVirtual.HeaderText = "MEMORIA VIRTUAL USADA";
			this.memoriaVirtual.Name = "memoriaVirtual";
			this.memoriaVirtual.ReadOnly = true;
			// 
			// tiempoProcesador
			// 
			this.tiempoProcesador.HeaderText = "TIEMPO DE PROCESADOR TOTAL";
			this.tiempoProcesador.Name = "tiempoProcesador";
			this.tiempoProcesador.ReadOnly = true;
			// 
			// lbl_1
			// 
			this.lbl_1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_1.Location = new System.Drawing.Point(898, 37);
			this.lbl_1.Name = "lbl_1";
			this.lbl_1.Size = new System.Drawing.Size(249, 49);
			this.lbl_1.TabIndex = 3;
			this.lbl_1.Text = "Procesos Activos:";
			// 
			// lbl_cuenta
			// 
			this.lbl_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_cuenta.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_cuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lbl_cuenta.Location = new System.Drawing.Point(1153, 37);
			this.lbl_cuenta.Name = "lbl_cuenta";
			this.lbl_cuenta.Size = new System.Drawing.Size(82, 49);
			this.lbl_cuenta.TabIndex = 4;
			this.lbl_cuenta.Click += new System.EventHandler(this.Lbl_cuentaClick);
			// 
			// btn_salir
			// 
			this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_salir.Location = new System.Drawing.Point(1160, 690);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.Size = new System.Drawing.Size(75, 23);
			this.btn_salir.TabIndex = 5;
			this.btn_salir.Text = "SALIR";
			this.btn_salir.UseVisualStyleBackColor = false;
			this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.YellowGreen;
			this.btnActualizar.Location = new System.Drawing.Point(1160, 106);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 6;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// dgv_hilos
			// 
			this.dgv_hilos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.index_dgv_hilos,
									this.id_dgv_hilos});
			this.dgv_hilos.Location = new System.Drawing.Point(898, 210);
			this.dgv_hilos.Name = "dgv_hilos";
			this.dgv_hilos.Size = new System.Drawing.Size(337, 464);
			this.dgv_hilos.TabIndex = 9;
			this.dgv_hilos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_hilosCellContentClick);
			// 
			// index_dgv2
			// 
			this.index_dgv2.HeaderText = "INDEX";
			this.index_dgv2.Name = "index_dgv2";
			// 
			// id_dgv2
			// 
			this.id_dgv2.HeaderText = "ID";
			this.id_dgv2.Name = "id_dgv2";
			// 
			// lbl_2
			// 
			this.lbl_2.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_2.Location = new System.Drawing.Point(898, 130);
			this.lbl_2.Name = "lbl_2";
			this.lbl_2.Size = new System.Drawing.Size(337, 77);
			this.lbl_2.TabIndex = 8;
			this.lbl_2.Text = "Hilos Activos de Los Procesos:";
			// 
			// index_dgv_hilos
			// 
			this.index_dgv_hilos.HeaderText = "INDEX";
			this.index_dgv_hilos.Name = "index_dgv_hilos";
			// 
			// id_dgv_hilos
			// 
			this.id_dgv_hilos.HeaderText = "ID HILO";
			this.id_dgv_hilos.Name = "id_dgv_hilos";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1254, 725);
			this.Controls.Add(this.lbl_2);
			this.Controls.Add(this.dgv_hilos);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btn_salir);
			this.Controls.Add(this.lbl_cuenta);
			this.Controls.Add(this.lbl_1);
			this.Controls.Add(this.dgv_Procesos);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "AdministradorDeTareas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Procesos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_hilos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn id_dgv_hilos;
		private System.Windows.Forms.DataGridViewTextBoxColumn index_dgv_hilos;
		private System.Windows.Forms.Label lbl_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_dgv2;
		private System.Windows.Forms.DataGridViewTextBoxColumn index_dgv2;
		private System.Windows.Forms.DataGridView dgv_hilos;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btn_salir;
		private System.Windows.Forms.DataGridViewTextBoxColumn tiempoProcesador;
		private System.Windows.Forms.DataGridViewTextBoxColumn memoriaVirtual;
		private System.Windows.Forms.Label lbl_cuenta;
		private System.Windows.Forms.Label lbl_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre_procesos;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_procesos;
		private System.Windows.Forms.DataGridViewTextBoxColumn index_procesos;
		private System.Windows.Forms.DataGridView dgv_Procesos;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarProcesoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crearProcesoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
	}
}
