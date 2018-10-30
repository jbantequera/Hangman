using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado {
	class Diccionario {
		Dictionary<int, string> palabras;

		public Diccionario() {
			palabras = new Dictionary<int, string>();
			palabras.Add(1, "Bote");
			palabras.Add(2, "Canguro");
			palabras.Add(3, "Murcielago");
			palabras.Add(4, "Gorila");
			palabras.Add(5, "Objeto");
			palabras.Add(6, "Programa");
			palabras.Add(7, "Lenguaje");
			palabras.Add(8, "Consola");
			palabras.Add(9, "Interfaz");
		}

		public String getPalabraAleatoria() {
			Random dado = new Random();
			string palabra = null;
			bool continuar = false;
			
			continuar = palabras.TryGetValue(dado.Next(1, (palabras.Count + 1)), out palabra);

			return palabra;
		}

		public void addPalabra(String palabra) {
			palabras.Add(palabras.Count + 1, palabra);
		}
	}
}
