namespace Color
{
	public class RGB
	{
		int red   { get; set; }
		int green { get; set; }
		int blue  { get; set; }

		public RGB(int red, int green, int blue)
		{
			this.red   = (red   < 0) ? 0 : red   % 256;
			this.green = (green < 0) ? 0 : green % 256;
			this.blue  = (blue  < 0) ? 0 : blue  % 256;
		}
		public RGB(RGB color)
		{
			this.red   = color.red;
			this.green = color.green;
			this.blue  = color.blue;
		}
	} 	
}