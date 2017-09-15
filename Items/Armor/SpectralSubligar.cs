using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConsoleMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Console_Port_Mod : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("10% increased movement speed and magical damage"
                + "\nIncreases maximum mana by 20");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.10f;
            player.magicDamage += 0.10f;
            player.statManaMax2 += 20;
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