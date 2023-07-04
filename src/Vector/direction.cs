interface I_Direction
{
	public float Norm();
	public void Normalize();
}

namespace Vector
{
	public class Direction_2D : I_Direction
	{
		public float x;
		public float y;

		public Direction_2D(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
		public Direction_2D(Vector_2D vector)
		{
			this.x = vector.x;
			this.y = vector.y;
		}
		public Direction_2D(Direction_2D direction)
		{
			this.x = direction.x;
			this.y = direction.y;
		}
	}


	public class Direction_3D : I_Direction
	{
		public float x;
		public float y;
		public float z;

		public Direction_3D(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public Direction_3D(Vector_3D vector)
		{
			this.x = vector.x;
			this.y = vector.y;
			this.z = vector.z;
		}
		public Direction_3D(Direction_3D direction)
		{
			this.x = direction.x;
			this.y = direction.y;
			this.z = direction.z;
		}
	}
}
