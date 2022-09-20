using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
	internal class Kor
	{
		double sugar;
		double atmero;

		public double Sugar { get => sugar;
			set 
			{ 
				if(value <= 0)
				{
					throw new ArgumentOutOfRangeException($"{value} értékkel nem szerkeszhető kör!");
				}
				else 
				{
					sugar = value;
				}
			}
		}
		public double Atmero { get => sugar * 2; }

		public double Kerulet()
		{
			return sugar * 2 * Math.PI;
		}

		public double Terulet()
		{
			return sugar * sugar * Math.PI;
		}
	}
}
