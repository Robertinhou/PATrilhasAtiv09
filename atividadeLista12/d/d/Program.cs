/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 19/02/2025
 * Time: 08:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;

namespace d
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
			List<string> palavras = new List<string>{"Abcd", "aaaa", "zé", "daMangaaaa"};
			
			int quantLetras = 0;
			string maiorPalavra = "";
			
			foreach(string palavra in palavras){
				
				if(palavra.Length > quantLetras){
					quantLetras = palavra.Length;
					maiorPalavra = palavra;
				}
				
			}
			
			Console.WriteLine("A maior palavra é {0} com {1} letras", maiorPalavra, quantLetras);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}