﻿using SDL2;

while (true)
{
	SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

	SDL.SDL_CreateWindow(
		"test",
		SDL.SDL_WINDOWPOS_CENTERED,
		SDL.SDL_WINDOWPOS_CENTERED,
		600,
		400,
		SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE
	);

	
}