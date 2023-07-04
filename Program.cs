using SDL2;


if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
{
	Console.WriteLine("Error when initializing SDL.");
	Console.WriteLine("Error: {0}", SDL.SDL_GetError());
}
else
{
	SDL_Window.WindowInstance window = new SDL_Window.WindowInstance();

	window.Run(
		(IntPtr window_ptr, SDL_Window.WindowEvents e) =>
		{
			float screen_aspect_ratio = window.WindowAspectRatio();
		}
	);
}
