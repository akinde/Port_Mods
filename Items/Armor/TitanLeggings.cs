using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class TitanLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("10% increased movement speed and ranged damage"
                + "\n5% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 13;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.10f;
            player.ammoCost95 = true;
            player.rangedDamage *= 0.10f;
            
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