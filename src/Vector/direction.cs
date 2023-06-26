interface I_Direction
{
	
}

namespace Vector
{
	public class Direction_2D : Vector_2D, I_Direction
	{
		public Direction_2D(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public Direction_2D(Direction_2D direction)
		{
			this.x = direction.x;
			this.y = direction.y;
		}
	}


	public class Direction_3D : Vector_3D, I_Direction
	{
		public Direction_3D(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public Direction_3D(Direction_3D direction)
		{
			this.x = direction.x;
			this.y = direction.y;
			this.z = direction.z;
		}
	}
}
