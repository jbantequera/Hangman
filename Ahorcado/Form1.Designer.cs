namespace Ahorcado {
	partial class Form1 {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button_newgame = new System.Windows.Forms.Button();
			this.pictureBox_ahorcado = new System.Windows.Forms.PictureBox();
			this.tB_letra = new System.Windows.Forms.TextBox();
			this.button_comprobar = new System.Windows.Forms.Button();
			this.label_letrasUsadas = new System.Windows.Forms.Label();
			this.textBox_letrasUsadas = new System.Windows.Forms.TextBox();
			this.comboBox_dificultad = new System.Windows.Forms.ComboBox();
			this.textBox_aniadir = new System.Windows.Forms.TextBox();
			this.button_aniadir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ahorcado)).BeginInit();
			this.SuspendLayout();
			// 
			// button_newgame
			// 
			this.button_newgame.Location = new System.Drawing.Point(503, 7);
			this.button_newgame.Name = "button_newgame";
			this.button_newgame.Size = new System.Drawing.Size(90, 31);
			this.button_newgame.TabIndex = 0;
			this.button_newgame.Text = "Nueva partida";
			this.button_newgame.UseVisualStyleBackColor = true;
			this.button_newgame.Click += new System.EventHandler(this.button_newgame_Click);
			// 
			// pictureBox_ahorcado
			// 
			this.pictureBox_ahorcado.Image = global::Ahorcado.Properties.Resources.ahorcado1;
			this.pictureBox_ahorcado.Location = new System.Drawing.Point(13, 13);
			this.pictureBox_ahorcado.Name = "pictureBox_ahorcado";
			this.pictureBox_ahorcado.Size = new System.Drawing.Size(347, 350);
			this.pictureBox_ahorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_ahorcado.TabIndex = 1;
			this.pictureBox_ahorcado.TabStop = false;
			// 
			// tB_letra
			// 
			this.tB_letra.Location = new System.Drawing.Point(373, 111);
			this.tB_letra.MaxLength = 1;
			this.tB_letra.Name = "tB_letra";
			this.tB_letra.Size = new System.Drawing.Size(27, 20);
			this.tB_letra.TabIndex = 2;
			this.tB_letra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_letra_KeyPress);
			// 
			// button_comprobar
			// 
			this.button_comprobar.Enabled = false;
			this.button_comprobar.Location = new System.Drawing.Point(406, 109);
			this.button_comprobar.Name = "button_comprobar";
			this.button_comprobar.Size = new System.Drawing.Size(75, 23);
			this.button_comprobar.TabIndex = 3;
			this.button_comprobar.Text = "Comprobar";
			this.button_comprobar.UseVisualStyleBackColor = true;
			this.button_comprobar.Click += new System.EventHandler(this.button_comprobar_Click);
			// 
			// label_letrasUsadas
			// 
			this.label_letrasUsadas.AutoSize = true;
			this.label_letrasUsadas.Location = new System.Drawing.Point(366, 146);
			this.label_letrasUsadas.Name = "label_letrasUsadas";
			this.label_letrasUsadas.Size = new System.Drawing.Size(73, 13);
			this.label_letrasUsadas.TabIndex = 6;
			this.label_letrasUsadas.Text = "Letras usadas";
			// 
			// textBox_letrasUsadas
			// 
			this.textBox_letrasUsadas.Location = new System.Drawing.Point(369, 162);
			this.textBox_letrasUsadas.Name = "textBox_letrasUsadas";
			this.textBox_letrasUsadas.ReadOnly = true;
			this.textBox_letrasUsadas.Size = new System.Drawing.Size(150, 20);
			this.textBox_letrasUsadas.TabIndex = 7;
			// 
			// comboBox_dificultad
			// 
			this.comboBox_dificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_dificultad.FormattingEnabled = true;
			this.comboBox_dificultad.Items.AddRange(new object[] {
            "Fácil",
            "Intermedio",
            "Avanzado"});
			this.comboBox_dificultad.Location = new System.Drawing.Point(373, 13);
			this.comboBox_dificultad.Name = "comboBox_dificultad";
			this.comboBox_dificultad.Size = new System.Drawing.Size(121, 21);
			this.comboBox_dificultad.TabIndex = 8;
			// 
			// textBox_aniadir
			// 
			this.textBox_aniadir.Location = new System.Drawing.Point(369, 343);
			this.textBox_aniadir.Name = "textBox_aniadir";
			this.textBox_aniadir.Size = new System.Drawing.Size(128, 20);
			this.textBox_aniadir.TabIndex = 9;
			this.textBox_aniadir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_aniadir_KeyPress);
			// 
			// button_aniadir
			// 
			this.button_aniadir.Location = new System.Drawing.Point(503, 337);
			this.button_aniadir.Name = "button_aniadir";
			this.button_aniadir.Size = new System.Drawing.Size(90, 31);
			this.button_aniadir.TabIndex = 10;
			this.button_aniadir.Text = "Añadir";
			this.button_aniadir.UseVisualStyleBackColor = true;
			this.button_aniadir.Click += new System.EventHandler(this.button_aniadir_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 450);
			this.Controls.Add(this.button_aniadir);
			this.Controls.Add(this.textBox_aniadir);
			this.Controls.Add(this.comboBox_dificultad);
			this.Controls.Add(this.textBox_letrasUsadas);
			this.Controls.Add(this.label_letrasUsadas);
			this.Controls.Add(this.button_comprobar);
			this.Controls.Add(this.tB_letra);
			this.Controls.Add(this.pictureBox_ahorcado);
			this.Controls.Add(this.button_newgame);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(621, 489);
			this.MinimumSize = new System.Drawing.Size(621, 489);
			this.Name = "Form1";
			this.Text = "Ahorcado";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ahorcado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_newgame;
		private System.Windows.Forms.PictureBox pictureBox_ahorcado;
		private System.Windows.Forms.TextBox tB_letra;
		private System.Windows.Forms.Button button_comprobar;
		private System.Windows.Forms.Label label_letrasUsadas;
		private System.Windows.Forms.TextBox textBox_letrasUsadas;
		private System.Windows.Forms.ComboBox comboBox_dificultad;
		private System.Windows.Forms.TextBox textBox_aniadir;
		private System.Windows.Forms.Button button_aniadir;
	}
}

