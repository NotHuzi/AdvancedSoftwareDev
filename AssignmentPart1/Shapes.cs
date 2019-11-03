using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalApplication
{
	interface Shapes
	{
		void Set(Color c, params int[] list);
		void Draw(Graphics g);
	}
}
