using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class DragonBreastplate: ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dragon Breastplate");
			Tooltip.SetDefault("10% increased critical strike chance"
				+ "\n5% increased melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 20;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeCrit += 10;
			player.meleeDamage += 0.05f;
	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.CobaltBreastplate);
			recipe.AddIngredient(ItemID.MythrilChainmail);
			recipe.AddIngredient(ItemID.AdamantiteBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.CobaltBreastplate);
			recipe.AddIngredient(ItemID.MythrilChainmail);
			recipe.AddIngredient(ItemID.TitaniumBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.CobaltBreastplate);
			recipe.AddIngredient(ItemID.OrichalcumBreastplate);
			recipe.AddIngredient(ItemID.AdamantiteBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.PalladiumBreastplate);
			recipe.AddIngredient(ItemID.MythrilChainmail);
			recipe.AddIngredient(ItemID.AdamantiteBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.CobaltBreastplate);
			recipe.AddIngredient(ItemID.OrichalcumBreastplate);
			recipe.AddIngredient(ItemID.TitaniumBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.PalladiumBreastplate);
			recipe.AddIngredient(ItemID.MythrilChainmail);
			recipe.AddIngredient(ItemID.TitaniumBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.PalladiumBreastplate);
			recipe.AddIngredient(ItemID.OrichalcumBreastplate);
			recipe.AddIngredient(ItemID.AdamantiteBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail);
			recipe.AddIngredient(ItemID.PalladiumBreastplate);
			recipe.AddIngredient(ItemID.OrichalcumBreastplate);
			recipe.AddIngredient(ItemID.TitaniumBreastplate);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();			
		}
	}
}