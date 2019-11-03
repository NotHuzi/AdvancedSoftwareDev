using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalApplication
{
	class Circle:Shape
	{
		int radius;

		public Circle() : base()
		{

		}


		/// Sets the colour and diameter values of the circle

		public override void Set(Color colour, params int[] list)
		{
			try
			{
				base.Set(colour, list[0], list[1]);
				radius = list[2];
			}
			catch (IndexOutOfRangeException)
			{
				throw;
			}
		}

	
		/// Draws a circle based on the diameter.
		public override void Draw(Graphics g)
		{
			Pen pen = new Pen(colour, 2);
			g.DrawEllipse(pen, x, y, radius * 2, radius * 2);
		}
	}
}
