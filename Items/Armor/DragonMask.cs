using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ConsoleMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Console_Port_Mod : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("15% increased melee speed and damage."
				+ "\n10% increased critical strike chance.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 26;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("DragonBreastplate") && legs.type == mod.ItemType("DragonGreaves");
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.15f;
			player.meleeDamage += 0.15f;
			player.meleeCrit += 10;
		}		
		
		public override void UpdateArmorSet(Player player)
		{
			player.meleeSpeed += 0.21f;
			player.moveSpeed += 0.21f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.CobaltHelmet);
			recipe.AddIngredient(ItemID.MythrilHelmet);
			recipe.AddIngredient(ItemID.AdamantiteHelmet);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.CobaltHelmet);
			recipe.AddIngredient(ItemID.MythrilHelmet);
			recipe.AddIngredient(ItemID.TitaniumMask);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.CobaltHelmet);
			recipe.AddIngredient(ItemID.OrichalcumMask);
			recipe.AddIngredient(ItemID.AdamantiteHelmet);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.PalladiumMask);
			recipe.AddIngredient(ItemID.MythrilHelmet);
			recipe.AddIngredient(ItemID.AdamantiteHelmet);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.CobaltHelmet);
			recipe.AddIngredient(ItemID.OrichalcumMask);
			recipe.AddIngredient(ItemID.TitaniumMask);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.PalladiumMask);
			recipe.AddIngredient(ItemID.MythrilHelmet);
			recipe.AddIngredient(ItemID.TitaniumMask);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.PalladiumMask);
			recipe.AddIngredient(ItemID.OrichalcumMask);
			recipe.AddIngredient(ItemID.AdamantiteHelmet);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask);
			recipe.AddIngredient(ItemID.PalladiumMask);
			recipe.AddIngredient(ItemID.OrichalcumMask);
			recipe.AddIngredient(ItemID.TitaniumMask);							
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();			
		}
	}
}