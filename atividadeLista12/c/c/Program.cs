﻿/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 19/02/2025
 * Time: 07:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace c
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List<int> nums = new List<int>{9, 2, 8, 10, 5};
			
			int maior = 0;
			
			foreach (int i in nums) {
				
				if(i > maior){
					
					maior = i;
					
				}
				
			}
			
			Console.WriteLine("O maior é: "+ maior);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}