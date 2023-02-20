/*
 * Created by SharpDevelop.
 * User: Vojta
 * Date: 20.02.2023
 * Time: 17:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZP3_Animace
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.obrazekBox = new System.Windows.Forms.PictureBox();
			this.seznamObrazku = new System.Windows.Forms.ImageList(this.components);
			this.casovac = new System.Windows.Forms.Timer(this.components);
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.obrazekBox)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(99, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 62);
			this.button1.TabIndex = 0;
			this.button1.Text = "Pustit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// obrazekBox
			// 
			this.obrazekBox.Image = ((System.Drawing.Image)(resources.GetObject("obrazekBox.Image")));
			this.obrazekBox.Location = new System.Drawing.Point(99, 36);
			this.obrazekBox.Name = "obrazekBox";
			this.obrazekBox.Size = new System.Drawing.Size(317, 229);
			this.obrazekBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.obrazekBox.TabIndex = 1;
			this.obrazekBox.TabStop = false;
			this.obrazekBox.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// seznamObrazku
			// 
			this.seznamObrazku.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("seznamObrazku.ImageStream")));
			this.seznamObrazku.TransparentColor = System.Drawing.Color.Transparent;
			this.seznamObrazku.Images.SetKeyName(0, "1.bmp");
			this.seznamObrazku.Images.SetKeyName(1, "2.bmp");
			this.seznamObrazku.Images.SetKeyName(2, "3.bmp");
			this.seznamObrazku.Images.SetKeyName(3, "4.bmp");
			this.seznamObrazku.Images.SetKeyName(4, "5.bmp");
			// 
			// casovac
			// 
			this.casovac.Enabled = true;
			this.casovac.Interval = 150;
			this.casovac.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(268, 306);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 62);
			this.button2.TabIndex = 2;
			this.button2.Text = "Zastavit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 402);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.obrazekBox);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "ZP3_Animace";
			((System.ComponentModel.ISupportInitialize)(this.obrazekBox)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer casovac;
		private System.Windows.Forms.ImageList seznamObrazku;
		private System.Windows.Forms.PictureBox obrazekBox;
		private System.Windows.Forms.Button button1;
	}
}
