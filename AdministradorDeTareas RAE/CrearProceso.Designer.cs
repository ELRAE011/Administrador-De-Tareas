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
	partial class CrearProceso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProceso));
			this.textProceso = new System.Windows.Forms.TextBox();
			this.btnCrearProceso = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textProceso
			// 
			this.textProceso.Location = new System.Drawing.Point(127, 12);
			this.textProceso.Name = "textProceso";
			this.textProceso.Size = new System.Drawing.Size(581, 20);
			this.textProceso.TabIndex = 0;
			// 
			// btnCrearProceso
			// 
			this.btnCrearProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCrearProceso.Location = new System.Drawing.Point(569, 56);
			this.btnCrearProceso.Name = "btnCrearProceso";
			this.btnCrearProceso.Size = new System.Drawing.Size(94, 23);
			this.btnCrearProceso.TabIndex = 1;
			this.btnCrearProceso.Text = "Crear Proceso";
			this.btnCrearProceso.UseVisualStyleBackColor = false;
			this.btnCrearProceso.Click += new System.EventHandler(this.BtnCrearProcesoClick);
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(12, 9);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Proceso";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnSalir.Location = new System.Drawing.Point(669, 56);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(725, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(19, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// CrearProceso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 91);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnCrearProceso);
			this.Controls.Add(this.textProceso);
			this.Name = "CrearProceso";
			this.Text = "CrearProceso";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnCrearProceso;
		private System.Windows.Forms.TextBox textProceso;
	}
}
