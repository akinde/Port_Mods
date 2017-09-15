using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	class SpectralRobe : ModItem
	{

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("5% increased magical damage"
                 + "\n10% reduced mana use"
                 + "\n10% increased magical critical strike chance");
        }

        public override void SetDefaults()
		{
			item.width = 18;
			item.height = 14;
			item.rare = 5;
			item.defense = 15;
		}

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
		{
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("SpectralRobe_Legs", EquipType.Legs);
		}

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
		{
			drawHands = true;
		}

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.05f;
            player.manaCost -= 0.10f;
            player.magicCrit += 10;
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
