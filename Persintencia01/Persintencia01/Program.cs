/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 17/4/2026
 * Time: 2:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Persintencia01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("==== TALLER SECCION B =====");
			
			
			// directorio
			
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DATOSIUJO");
			
			string rutaReportes = Path.Combine(rutaRaiz, "REPORTES");
			
			Console.WriteLine(rutaRaiz);
			Console.WriteLine(rutaReportes);
			
			if(!Directory.Exists(rutaReportes)){
			   //crear el directorio reportes
			   	Directory.CreateDirectory(rutaReportes);
			   	Console.WriteLine("Directorio creado correctamente");
			   
			   }
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}