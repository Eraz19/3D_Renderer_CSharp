using SDL2;


namespace SDL_Window
{
	class WindowInstance
	{
		private IntPtr window_ptr = IntPtr.Zero;
		private WindowEvents e    = new WindowEvents();

		public float WindowAspectRatio()
		{
			int window_width;
			int window_height;

			SDL.SDL_GetWindowSize(window_ptr, out window_width, out window_height);

			return (window_height / window_width);
		}

		public void Run(Action<IntPtr,WindowEvents> callback)
		{
			bool rerender_frame = false;

			window_ptr = SDL.SDL_CreateWindow(
				"3D_Renderer",
				SDL.SDL_WINDOWPOS_CENTERED,
				SDL.SDL_WINDOWPOS_CENTERED,
				1000,
				800,
				SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE
			);

			if (window_ptr == IntPtr.Zero)
			{
				Console.WriteLine("Error when creating SDL window.");
				Console.WriteLine("Error: {0}", SDL.SDL_GetError());
			}
			else
			{
				while (!e.quit_window)
				{
					e.Listening(out rerender_frame);

					if (rerender_frame)
					{
						callback(window_ptr, e);
						rerender_frame = false;
					}
				}

				SDL.SDL_DestroyWindow(window_ptr);
				SDL.SDL_Quit();
			}
		}
	}
}
