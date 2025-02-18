/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 18/02/2025
 * Time: 10:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace b
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List<string> lista = new List<string>{"Opa", "aaaaa", "AAHhhhh"};
			Console.WriteLine("Hello World!");
			
			foreach (string i in lista) {
				Console.WriteLine(i);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}