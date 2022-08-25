using PhoenixPoint.Modding;

namespace FlashBangGrenade
{
	/// <summary>
	/// ModConfig is mod settings that players can change from within the game.
	/// Config is only editable from players in main menu.
	/// Only one config can exist per mod assembly.
	/// Config is serialized on disk as json.
	/// </summary>
	public class FlashBangGrenadeConfig : ModConfig
	{
		/// Only public fields are serialized.
		/// Supported types for in-game UI are:
		public bool FixText = true;
	}
}
