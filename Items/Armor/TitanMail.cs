using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class TitanMail : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Titan Mail");
			Tooltip.SetDefault("5% increased ranged damage"
                + "\n5% chance to not consume ammo"
                + "\n10% increased ranged critical strike chance");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 18;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.05f;
            player.ammoCost95 = true;
            player.rangedCrit += 10;

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