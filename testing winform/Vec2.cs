using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Documents;

namespace testing_winform
{
	class Vec2
	{
		public double x;
		public double y;
		public double mag { 
			get {
				return Math.Sqrt(x*x + y*y);
			} set { /* read only */ } }

		public Vec2(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public static Vec2 operator +(Vec2 v1, Vec2 v2)
		{
			// set origin to v1 head and move a point to v2 relative to v1 head
			return new Vec2(v1.x + v2.x, v1.y + v2.y);
		}

		public short GetAngleRelativeToOrigin()
		{
			double angleRadians = Math.Atan2(y, x); // radians
			// now gotta convert it to deg and return it
			return (short)((180/Math.PI) * angleRadians); // now a value between 0 and 360, and is 16 bits.
			// TODO reduce to 8 bits by subtracting 105 and adding the 105 on arduino.
			// store sign bit in another data byte lol
		}
	}
}
