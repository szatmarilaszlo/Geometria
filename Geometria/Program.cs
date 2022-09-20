using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
	class Program
	{

		static void Main(string[] args)
		{
			Kor kor = new Kor();
			try
			{
				kor.Sugar = 2;
				Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\t területe: {kor.Terulet():N2}\tátmérője: {kor.Atmero:N2}.");
				kor.Sugar = 7;
				Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\t területe: {kor.Terulet():N2}\tátmérője: {kor.Atmero:N2}."); kor.Sugar = -2;
				kor.Sugar = -2;
				Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\t területe: {kor.Terulet():N2}\tátmérője: {kor.Atmero:N2}."); kor.Sugar = -2;
				kor.Sugar = 11;
				Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\tkerülete: {kor.Kerulet():N2}\t területe: {kor.Terulet():N2}\tátmérője: {kor.Atmero:N2}.");
			}
			catch(ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
						
			Console.WriteLine("Program vége!");
			Console.ReadKey();
		}
	}
}
