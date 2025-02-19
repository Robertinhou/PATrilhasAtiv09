/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 19/02/2025
 * Time: 08:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;

namespace e
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List<int> nums = new List<int>{ 1, 2, 3 ,4 ,5 ,6 };
			 
			int soma = 0;
			
			foreach (int i in nums) {
				
				soma += i;
				
			}
			
			Console.WriteLine("A média é: "+ (double) soma / nums.Count );
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}