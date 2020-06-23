using System;
using System.Collections.Generic;
using System.Text;

namespace Classi4
{
    class Circle : Figure
    {
		private int x, y, r;
		public Circle(int x, int y, int r)
		{ 
			X = x;
			Y = y;
			R = r;
		}
		public int X
		{
			get
			{
				return x;
			}
			set
			{
				
				this.x = value;
				
			}
		}
		public int Y
		{
			get
			{
				return y;
			}
			set
			{

				this.y = value;
				
			}
		}
		public int R
		{
			get
			{
				return r;
			}
			set
			{

				this.r = value;

			}
		}

		public override bool PointIN(int x2, int y2)
		{
			if ((x - x2)* (x - x2) + (y - y2)* (y - y2) < r *r)

			{
				return true;
            }
            else
            {
				return false;
            }

		}
	}
}
