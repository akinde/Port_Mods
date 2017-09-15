
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Weapons
{
	public class Tizona : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tizona");
			Tooltip.SetDefault("Has a chance to cause bleeding.");
            //change
		}
		public override void SetDefaults()
		{
			item.damage = 56;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	
	
	
	
	}
}
