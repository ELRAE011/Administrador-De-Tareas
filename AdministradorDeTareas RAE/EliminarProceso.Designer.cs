/*
 * Created by SharpDevelop.
 * User: PC06
 * Date: 24/02/2023
 * Time: 02:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AdministradorDeTareas
{
	partial class EliminarProceso
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
			this.txtEliminarProceso = new System.Windows.Forms.TextBox();
			this.btnSalirEliminar = new System.Windows.Forms.Button();
			this.btnEliminarProceso = new System.Windows.Forms.Button();
			this.lblPid = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEliminarProceso2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtEliminarProceso
			// 
			this.txtEliminarProceso.Location = new System.Drawing.Point(12, 33);
			this.txtEliminarProceso.Name = "txtEliminarProceso";
			this.txtEliminarProceso.Size = new System.Drawing.Size(274, 20);
			this.txtEliminarProceso.TabIndex = 0;
			// 
			// btnSalirEliminar
			// 
			this.btnSalirEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnSalirEliminar.Location = new System.Drawing.Point(211, 142);
			this.btnSalirEliminar.Name = "btnSalirEliminar";
			this.btnSalirEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnSalirEliminar.TabIndex = 6;
			this.btnSalirEliminar.Text = "Salir";
			this.btnSalirEliminar.UseVisualStyleBackColor = false;
			this.btnSalirEliminar.Click += new System.EventHandler(this.BtnSalirEliminarClick);
			// 
			// btnEliminarProceso
			// 
			this.btnEliminarProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnEliminarProceso.Location = new System.Drawing.Point(12, 142);
			this.btnEliminarProceso.Name = "btnEliminarProceso";
			this.btnEliminarProceso.Size = new System.Drawing.Size(113, 23);
			this.btnEliminarProceso.TabIndex = 7;
			this.btnEliminarProceso.Text = "Eliminar Proceso";
			this.btnEliminarProceso.UseVisualStyleBackColor = false;
			this.btnEliminarProceso.Click += new System.EventHandler(this.BtnEliminarProcesoClick);
			// 
			// lblPid
			// 
			this.lblPid.Location = new System.Drawing.Point(12, 9);
			this.lblPid.Name = "lblPid";
			this.lblPid.Size = new System.Drawing.Size(175, 23);
			this.lblPid.TabIndex = 8;
			this.lblPid.Text = "ID DEL PROCESO A ELIMINAR:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "NOMBRE DEL PROCESO A ELIMINAR:";
			// 
			// txtEliminarProceso2
			// 
			this.txtEliminarProceso2.Location = new System.Drawing.Point(12, 99);
			this.txtEliminarProceso2.Name = "txtEliminarProceso2";
			this.txtEliminarProceso2.Size = new System.Drawing.Size(274, 20);
			this.txtEliminarProceso2.TabIndex = 10;
			this.txtEliminarProceso2.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// EliminarProceso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 184);
			this.Controls.Add(this.txtEliminarProceso2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPid);
			this.Controls.Add(this.btnEliminarProceso);
			this.Controls.Add(this.btnSalirEliminar);
			this.Controls.Add(this.txtEliminarProceso);
			this.Name = "EliminarProceso";
			this.Text = "EliminarProceso";
			this.Load += new System.EventHandler(this.EliminarProcesoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtEliminarProceso2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPid;
		private System.Windows.Forms.Button btnEliminarProceso;
		private System.Windows.Forms.Button btnSalirEliminar;
		private System.Windows.Forms.TextBox txtEliminarProceso;
		
		void EliminarProcesoLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
