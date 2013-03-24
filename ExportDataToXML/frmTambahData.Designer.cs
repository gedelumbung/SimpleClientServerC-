/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 31/03/2011
 * Time: 20:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ExportDataToXML
{
	partial class frmTambahData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTambahData));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.noInduk = new System.Windows.Forms.TextBox();
			this.namaSiswa = new System.Windows.Forms.TextBox();
			this.keLahiran = new System.Windows.Forms.TextBox();
			this.aLamat = new System.Windows.Forms.TextBox();
			this.passWord = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "No Induk";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Siswa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kelahiran";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Alamat";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// noInduk
			// 
			this.noInduk.Location = new System.Drawing.Point(101, 11);
			this.noInduk.Name = "noInduk";
			this.noInduk.Size = new System.Drawing.Size(131, 20);
			this.noInduk.TabIndex = 5;
			this.noInduk.TextChanged += new System.EventHandler(this.NoIndukTextChanged);
			// 
			// namaSiswa
			// 
			this.namaSiswa.Location = new System.Drawing.Point(101, 41);
			this.namaSiswa.Name = "namaSiswa";
			this.namaSiswa.Size = new System.Drawing.Size(206, 20);
			this.namaSiswa.TabIndex = 6;
			// 
			// keLahiran
			// 
			this.keLahiran.Location = new System.Drawing.Point(101, 67);
			this.keLahiran.Name = "keLahiran";
			this.keLahiran.Size = new System.Drawing.Size(206, 20);
			this.keLahiran.TabIndex = 7;
			// 
			// aLamat
			// 
			this.aLamat.Location = new System.Drawing.Point(101, 93);
			this.aLamat.Name = "aLamat";
			this.aLamat.Size = new System.Drawing.Size(206, 20);
			this.aLamat.TabIndex = 8;
			// 
			// passWord
			// 
			this.passWord.Location = new System.Drawing.Point(101, 121);
			this.passWord.Name = "passWord";
			this.passWord.Size = new System.Drawing.Size(206, 20);
			this.passWord.TabIndex = 9;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(203, 147);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 36);
			this.button3.TabIndex = 10;
			this.button3.Text = "Tambah Data";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(209, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 36);
			this.button1.TabIndex = 11;
			this.button1.Text = "Update Data";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// frmTambahData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 198);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.passWord);
			this.Controls.Add(this.aLamat);
			this.Controls.Add(this.keLahiran);
			this.Controls.Add(this.namaSiswa);
			this.Controls.Add(this.noInduk);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmTambahData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTambahData";
			this.Load += new System.EventHandler(this.FrmTambahDataLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox noInduk;
		private System.Windows.Forms.TextBox namaSiswa;
		private System.Windows.Forms.TextBox keLahiran;
		private System.Windows.Forms.TextBox aLamat;
		private System.Windows.Forms.TextBox passWord;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
	}
}
