using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;

using GeometryWars;

namespace GeoWars
{
	public class AppMain
	{
		//private static GraphicsContext graphics;
		private static GameRoot game;
		
		public static void Main (string[] args)
		{
			game = new GameRoot();
			game.Run ();
			
			//will not pass this point
			/*
			Initialize ();

			while (true) {
				SystemEvents.CheckEvents ();
				Update ();
				Render ();
			}*/
		}

		public static void Initialize ()
		{
			// Set up the graphics system
			//graphics = new GraphicsContext ();
		}

		public static void Update ()
		{
			// Query gamepad for current state
			//var gamePadData = GamePad.GetData (0);
		}

		public static void Render ()
		{
			// Clear the screen
			//graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			//graphics.Clear ();

			// Present the screen
			//graphics.SwapBuffers ();
		}
	}
}
