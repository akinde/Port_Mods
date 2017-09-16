using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class TitanHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("10% increased ranged damage"
                + "\n5% chance to not consume ammo"
                + "\n10% increased ranged critical strike chance");
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 14;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("TitanMail") && legs.type == mod.ItemType("TitanLeggings");
		}

		public override void UpdateEquip(Player player)
		{
			
			player.rangedDamage += 0.1f;
            player.ammoCost95 = true;
            player.rangedCrit += 10;

		}

        public override void UpdateArmorSet(Player player)
        {
            player.ammoCost72 = true;
        }

        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.CobaltMask);
            recipe.AddIngredient(ItemID.MythrilHat);
            recipe.AddIngredient(ItemID.AdamantiteMask);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.CobaltMask);
            recipe.AddIngredient(ItemID.MythrilHat);
            recipe.AddIngredient(ItemID.TitaniumHelmet);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.CobaltMask);
            recipe.AddIngredient(ItemID.OrichalcumHelmet);
            recipe.AddIngredient(ItemID.AdamantiteMask);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.PalladiumHelmet);
            recipe.AddIngredient(ItemID.MythrilHat);
            recipe.AddIngredient(ItemID.AdamantiteMask);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.CobaltMask);
            recipe.AddIngredient(ItemID.OrichalcumHelmet);
            recipe.AddIngredient(ItemID.TitaniumHelmet);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.PalladiumHelmet);
            recipe.AddIngredient(ItemID.MythrilHat);
            recipe.AddIngredient(ItemID.TitaniumHelmet);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.PalladiumHelmet);
            recipe.AddIngredient(ItemID.OrichalcumHelmet);
            recipe.AddIngredient(ItemID.AdamantiteMask);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedHelmet);
            recipe.AddIngredient(ItemID.PalladiumHelmet);
            recipe.AddIngredient(ItemID.OrichalcumHelmet);
            recipe.AddIngredient(ItemID.TitaniumHelmet);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}