using Terraria.ModLoader;

namespace Console_Port_Mod
{
	class Console_Port_Mod : Mod
	{
		public Console_Port_Mod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
