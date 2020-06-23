using System;
using System.Collections.Generic;
using System.Text;

namespace Classi4
{
    class Square : Figure
    {
		private int x, y,a,b;
		public Square(int x, int y, int a, int b)
		{ 
			X = x;
			Y = y;
			A = a;
			B = b;
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
		public int A
		{
			get
			{
				return a;
			}
			set
			{

				this.a = value;

			}
		}
		public int B
		{
			get
			{
				return b;
			}
			set
			{

				this.b = value;

			}
		}
		public override bool PointIN(int x2, int y2)
        {

			int help1;
			int help2;
			int help3;
			int x1 = x;
			int y1 = y;
			help1 = x1 + a;
			help2 = y1 + b;
			help3 = y1 - b;

			if (help1 > x2 && x1 < x2)
			{
				
				if (help2 > y2 || help3 < y2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
            else
            {
				return false;
			}
		}
    }
}
