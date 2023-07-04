using SDL2;


namespace SDL_Window
{
	class WindowEvents
	{
		public HashSet<SDL.SDL_Keycode> keydown       = new HashSet<SDL.SDL_Keycode>();
		public bool                     quit_window   = false;

		public void Listening(out bool rerender_frame)
		{
			SDL.SDL_Event e;

			rerender_frame = false;

			while (SDL.SDL_PollEvent(out e) != 0)
			{
				switch (e.type)
				{
					case SDL.SDL_EventType.SDL_QUIT:
						quit_window   = true;
						rerender_frame = true;
						break;
					case SDL.SDL_EventType.SDL_KEYDOWN:
						keydown.Add(e.key.keysym.sym);
						rerender_frame = true;
						break;
					case SDL.SDL_EventType.SDL_KEYUP:
						keydown.Remove(e.key.keysym.sym);
						rerender_frame = true;
						break;
					case SDL.SDL_EventType.SDL_WINDOWEVENT:
						Console.WriteLine("Something is happening");
						break;
					default:
						break;
				}
			}
		}
	}
}
