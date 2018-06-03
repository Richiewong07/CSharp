using System;

namespace Methods
{
    public class Point
    {
		// FIELDS
        public int X;
        public int Y;

        // CONSTRUCTOR TO INITIALIZE FIELDS
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // METHOD
        public void Move(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

        // METHOD OVERLOAD 
		public void Move(Point newLocation)
        {
			if (newLocation == null)
				throw new ArgumentNullException("newLocation");

            // CALLS OTHER POINT METHOD
			Move(newLocation.X, newLocation.Y);
        }
        
    }
}
