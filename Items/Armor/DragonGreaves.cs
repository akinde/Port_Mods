using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class DragonGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("12% increased movement speed"
				+ "\n2% increased melee speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 14;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.12f;
			player.meleeSpeed += 0.02f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.CobaltLeggings);
			recipe.AddIngredient(ItemID.MythrilGreaves);
			recipe.AddIngredient(ItemID.AdamantiteLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.CobaltLeggings);
			recipe.AddIngredient(ItemID.MythrilGreaves);
			recipe.AddIngredient(ItemID.TitaniumLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.CobaltLeggings);
			recipe.AddIngredient(ItemID.OrichalcumLeggings);
			recipe.AddIngredient(ItemID.AdamantiteLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.PalladiumLeggings);
			recipe.AddIngredient(ItemID.MythrilGreaves);
			recipe.AddIngredient(ItemID.AdamantiteLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.CobaltLeggings);
			recipe.AddIngredient(ItemID.OrichalcumLeggings);
			recipe.AddIngredient(ItemID.TitaniumLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.PalladiumLeggings);
			recipe.AddIngredient(ItemID.MythrilGreaves);
			recipe.AddIngredient(ItemID.TitaniumLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.PalladiumLeggings);
			recipe.AddIngredient(ItemID.OrichalcumLeggings);
			recipe.AddIngredient(ItemID.AdamantiteLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves);
			recipe.AddIngredient(ItemID.PalladiumLeggings);
			recipe.AddIngredient(ItemID.OrichalcumLeggings);
			recipe.AddIngredient(ItemID.TitaniumLeggings);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();			
		}
	}
}