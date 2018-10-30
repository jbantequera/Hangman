using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado {
	public static class Login {
		
		private static string[] credenciales;

		public static string[] ShowDialog() {
			Form prompt = new Form() {
				Width = 500,
				Height = 200,
				FormBorderStyle = FormBorderStyle.FixedDialog,
				Text = "Credenciales",
				StartPosition = FormStartPosition.CenterScreen
			};

			credenciales = null;
			Label labelUsuario = new Label() { Left = 50, Top=20, Text= "Usuario" };
			TextBox textBoxUsuario = new TextBox() { Left = 50, Top=40, Width=400 };
			Label labelContra = new Label() { Left = 50, Top = 70, Text = "Contraseña"};
			TextBox textBoxContra = new TextBox() { Left = 50, Top = 90, Width = 400 };
			Button confirmation = new Button() { Text = "Ok", Left=350, Width=100, Top=120, DialogResult = DialogResult.OK };
			
			confirmation.Click += (sender, e) => { 
				credenciales = new string [2];
				credenciales[0] = textBoxUsuario.Text;
				credenciales[1] = textBoxContra.Text;
				prompt.Close(); 
			};
			
			prompt.Controls.Add(textBoxUsuario);
			prompt.Controls.Add(textBoxContra);
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(labelUsuario);
			prompt.Controls.Add(labelContra);
			prompt.AcceptButton = confirmation;
			
			return prompt.ShowDialog() == DialogResult.OK ? credenciales : null;
		}
		
	}
}
