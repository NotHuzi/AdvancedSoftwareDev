using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalApplication
{
	class Rectangle:Shape
	{
		TextureBrush tbrush;
		int width, height;
		
		public Rectangle() : base()
		{
			width = 100;
			height = 100;
		}

		public Rectangle(Color colour, int x, int y, int width, int height):base(colour, x, y)
		{
			this.width = width;
			this.height = height;
		}

		/// Sets the colour, currentX, currentY, width and height values of the Rectangle shape.

		public override void Set(Color colour, params int[] list)
		{
			base.Set(colour, list[0], list[1]);
			this.width = list[2];
			this.height = list[3];
		}


		/// Draws a rectangle based on the width and height.

		public override void Draw(Graphics g)
		{
			if (tbrush != null)
			{
				g.FillRectangle(tbrush, x, y, height, width);
			}

			Pen p = new Pen(colour, 2);
			g.DrawRectangle(p, x, y, height, width);
		}

		public override void SetTexture(string textureFile)
		{
			Image image = new Bitmap(textureFile);
			tbrush = new TextureBrush(image);
		}
	}
}
