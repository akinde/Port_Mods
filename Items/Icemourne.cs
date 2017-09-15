using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items
{
	public class Icemourne : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icemourne");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 44;
			item.melee = true;
			item.width = 78;
			item.height = 78;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 120;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlade, 1);
            recipe.AddIngredient(ItemID.IceFeather, 10);
            recipe.AddIngredient(ItemID.IceSickle, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
