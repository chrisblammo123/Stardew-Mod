using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace StardewMod
{
	// The mod entry point.


	/**
	 * @class ModEntry
	 * @description The mod entry point.
	 */
	public class ModEntry : Mod
	{
		// Public Methods



		/**
		 * @function Entry
		 * @description Called when SMAPI loads the mod.
		 * @param helper Gives access to SMAPI.
		 */
		public override void Entry(IModHelper helper)
		{
			// Creates a event handler for button presses by a player.
			helper.Events.Input.ButtonPressed += this.OnButtonPressed;
		}


		// Private Methods

		/**
		 * @function OnButtonPressed
		 * @description Handles the event of a button being pressed by a player.
		 * @param sender Player who triggered the event.
		 * @param e The data from the event.
		 */
		private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
		{
			// ignore if player hasn't loaded a save yet
			if (!Context.IsWorldReady)
				return;

			// print button presses to the console window
			this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
		}
	}
}