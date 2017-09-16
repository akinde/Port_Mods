using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SpectralHood : ModItem
	{
		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("Increases maximum mana by 100"
                 + "\n10% increased magic damage and critical strike chance");
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 10;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("SpectralRobe") && legs.type == mod.ItemType("SpectralSubligar");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.manaCost -= 0.23f;
		}

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 120;
            player.magicDamage += 0.10f;
            player.magicCrit += 10;
        }

        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.CobaltHat);
            recipe.AddIngredient(ItemID.MythrilHood);
            recipe.AddIngredient(ItemID.AdamantiteHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.CobaltHat);
            recipe.AddIngredient(ItemID.MythrilHood);
            recipe.AddIngredient(ItemID.TitaniumHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.CobaltHat);
            recipe.AddIngredient(ItemID.OrichalcumHeadgear);
            recipe.AddIngredient(ItemID.AdamantiteHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.PalladiumHeadgear);
            recipe.AddIngredient(ItemID.MythrilHood);
            recipe.AddIngredient(ItemID.AdamantiteHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.CobaltHat);
            recipe.AddIngredient(ItemID.OrichalcumHeadgear);
            recipe.AddIngredient(ItemID.TitaniumHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.PalladiumHeadgear);
            recipe.AddIngredient(ItemID.MythrilHood);
            recipe.AddIngredient(ItemID.TitaniumHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.PalladiumHeadgear);
            recipe.AddIngredient(ItemID.OrichalcumHeadgear);
            recipe.AddIngredient(ItemID.AdamantiteHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHeadgear);
            recipe.AddIngredient(ItemID.PalladiumHeadgear);
            recipe.AddIngredient(ItemID.OrichalcumHeadgear);
            recipe.AddIngredient(ItemID.TitaniumHeadgear);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}