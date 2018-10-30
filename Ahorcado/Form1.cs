using Ahorcado.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado {
	public partial class Form1 : Form {

		String usuario = "admin";
		String password = "admin";

		Diccionario midiccionario;
		string solucion;
		Label[] labels;
		PictureBox[] ocultas;
		bool partida_completa;
		int intentos;
		Font mifuente;

		public Form1() {
			InitializeComponent();
			comboBox_dificultad.SelectedIndex = 0;
			midiccionario = new Diccionario();
			solucion = null;
			partida_completa = true;
			intentos = 0;
			mifuente = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
		}

		private void button_newgame_Click(object sender, EventArgs e) {
			partida_completa = false;
			Random dado = new Random();
			int x = 39;
			int y = 370;
			int pistas = -1;

			//Reiniciamos los intentos
			intentos = 6;
			cambiarImagenAhorcado();
			button_comprobar.Enabled = true;
			textBox_letrasUsadas.Text = "";

			//Comprobamos la dificultad actual
			if (comboBox_dificultad.Text.Equals("Fácil"))
				pistas = 2;
			else if (comboBox_dificultad.Text.Equals("Intermedio"))
				pistas = 1;
			else if (comboBox_dificultad.Text.Equals("Avanzado"))
				pistas = 0;
			else 
				MessageBox.Show("Seleccione una dificultad");
			
			if (pistas != -1){
				if (labels != null) //Si ya teníamos una palabra antes, la borramos del Form
					for (int i = 0; i < labels.Length; i++)
						Controls.Remove(labels[i]);
				if (ocultas != null)
					for (int i = 0; i < ocultas.Length; i++)
						Controls.Remove(ocultas[i]);
			
				solucion = midiccionario.getPalabraAleatoria().ToUpper();
				labels = new Label[solucion.Length];
				ocultas = new PictureBox[solucion.Length];

				for (int i = 0; i < solucion.Length; i++) {
					labels[i] = new Label(); //Creamos tantas labels como letras tenga la palabra
					ocultas[i] = new PictureBox();
				}

				//Añadimos las labels al form
				for (int i = 0; i < labels.Length; i++) {
					ocultas[i].Left = x;
					ocultas[i].Top = y;
					ocultas[i].Size = new Size(25, 25);
					ocultas[i].Image = Resources.letraoculta;
					ocultas[i].SizeMode = PictureBoxSizeMode.Normal;
					Controls.Add(ocultas[i]);
					x += 30;
				}
				
				//Añadimos las pistas en función de la dificultad escogida
				String pistasAnadidas = "";
				for (int i = 0; i < pistas; i++){ //Número de pistas que vamos a añadir
					char letra;
				
					do{
						letra = (char) dado.Next(65, 91);
					} while(!solucion.Contains(letra) || pistasAnadidas.Contains(letra));

					for (int j = 0; j < solucion.Length; j++) {
						if (solucion[j] == letra) {
							labels[j].Text = letra.ToString();
							//Cambiamos la imagen por el label
							labels[j].Left = ocultas[j].Left;
							labels[j].Top = ocultas[j].Top;
							labels[j].Size = ocultas[j].Size;
							labels[j].Font = mifuente;
							Controls.Remove(ocultas[j]);
							Controls.Add(labels[j]);
							//Añadimos la letra a las letras ya usadas
							pistasAnadidas += letra;
						}
					}
				}
			}
		}
	
		private void comprobarLetra() {
			if (!partida_completa) {
				if (tB_letra.Text.Length == 1){
					char letra = tB_letra.Text.ToUpper()[0];
					bool acierto = false;

					if (solucion.Contains(letra)) {
						for (int i = 0; i < solucion.Length; i++) {
							if (letra == solucion[i]){
								labels[i].Text = letra.ToString();
								labels[i].Left = ocultas[i].Left;
								labels[i].Top = ocultas[i].Top;
								labels[i].Size = ocultas[i].Size;
								labels[i].Font = mifuente;
								Controls.Add(labels[i]);
								Controls.Remove(ocultas[i]);
								acierto = true;
							}
						}
					}

					if (!acierto){
						if (!textBox_letrasUsadas.Text.Contains(letra)){
							intentos -= 1;
							this.cambiarImagenAhorcado();
							textBox_letrasUsadas.Text += (letra + " ");
						} else {
							MessageBox.Show("Ya has introducido esa letra!");
						}
					}

					//Comprobamos si la partida se ha acabado
					partida_completa = true;

					if (intentos > 0){
						for (int i = 0; i < labels.Length; i++) {
							if (labels[i].Text.Equals(""))
								partida_completa = false;
						}

						if (partida_completa){
							MessageBox.Show("¡Enhorabuena!, has ganado la partida");
							button_comprobar.Enabled = false;
						}
					} else { //Si se ha acabado la partida
						MessageBox.Show("¡Vaya!, parece que has perdido...");
						button_comprobar.Enabled = false;

						//Mostramos la solución
						for (int i = 0; i < solucion.Length; i++) {
							if (labels[i].Text.Equals("")) {
								labels[i].Text = solucion[i].ToString();
								labels[i].Left = ocultas[i].Left;
								labels[i].Top = ocultas[i].Top;
								labels[i].Size = ocultas[i].Size;
								labels[i].Font = mifuente;
								Controls.Add(labels[i]);
								Controls.Remove(ocultas[i]);
							}
						}
					}
				} else {
					MessageBox.Show("Debes introducir una única letra");
				}
			} else {
				MessageBox.Show("Debes iniciar una nueva partida");
			}

			tB_letra.Text = "";
		}

		private void cambiarImagenAhorcado() {
			if (intentos == 6)
				pictureBox_ahorcado.Image = Resources.ahorcado1;
			else if (intentos == 5)
				pictureBox_ahorcado.Image = Resources.ahorcado2;
			else if (intentos == 4)
				pictureBox_ahorcado.Image = Resources.ahorcado3;
			else if (intentos == 3)
				pictureBox_ahorcado.Image = Resources.ahorcado4;
			else if (intentos == 2)
				pictureBox_ahorcado.Image = Resources.ahorcado5;
			else if (intentos == 1)
				pictureBox_ahorcado.Image = Resources.ahorcado6;
			else if (intentos == 0)
				pictureBox_ahorcado.Image = Resources.ahorcado7;
		}

		private void addPalabra() {
			string[] credenciales = Login.ShowDialog();
			string nuevapalabra = textBox_aniadir.Text;
			
			if (credenciales[0].Equals(usuario) && credenciales[1].Equals(password))
				midiccionario.addPalabra(nuevapalabra);
			else
				MessageBox.Show("Credenciales incorrectos");

			textBox_aniadir.Text = "";
		}

		private void tB_letra_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)13) {
				comprobarLetra();
			}
		}
	
		private void button_comprobar_Click(object sender, EventArgs e) {
			comprobarLetra();
		}

		private void tB_aniadir_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)13) {
				addPalabra();
			}
		}

		private void button_aniadir_Click(object sender, EventArgs e) {
			addPalabra();
		}
	}
}
