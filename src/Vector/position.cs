interface I_Position
{

}

namespace Vector
{
	public class Position_2D : Vector_2D, I_Position
	{
		public Position_2D(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public Position_2D(Position_2D position)
		{
			this.x = position.x;
			this.y = position.y;
		}
	}


	public class Position_3D : Vector_3D, I_Position
	{
		public Position_3D(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public Position_3D(Position_3D position)
		{
			this.x = position.x;
			this.y = position.y;
			this.z = position.z;
		}
	}
}
