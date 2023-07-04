interface I_Position
{
	public void Translate();
	public void Scale();
}

namespace Vector
{
	public class Position_2D : I_Position
	{
		public float x;
		public float y;

		public Position_2D(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
		public Position_2D(Vector_2D vector)
		{
			this.x = vector.x;
			this.y = vector.y;
		}
		public Position_2D(Position_2D position)
		{
			this.x = position.x;
			this.y = position.y;
		}
	}


	public class Position_3D : I_Position
	{
		public float x;
		public float y;
		public float z;

		public Position_3D(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public Position_3D(Vector_3D vector)
		{
			this.x = vector.x;
			this.y = vector.y;
			this.z = vector.z;
		}
		public Position_3D(Position_3D position)
		{
			this.x = position.x;
			this.y = position.y;
			this.z = position.z;
		}
	}
}
