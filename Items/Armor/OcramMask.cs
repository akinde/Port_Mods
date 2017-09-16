using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class OcramMask : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = 1;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}