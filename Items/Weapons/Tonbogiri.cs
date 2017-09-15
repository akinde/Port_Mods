using ConsoleMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items.Weapons
{
	public class Tonbogiri : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An example spear");
		}

		public override void SetDefaults()
		{
			item.damage = 53;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 24;
			item.shootSpeed = 3.7f;
			item.knockBack = 13;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<TonbogiriProj>();
			item.value = 1000;
			item.noMelee = true; // Important because the spear is acutally a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.melee = true;
			item.autoReuse = true; // Most spears dont autoReuse, but it's possible
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1; // This is to ensure the spear doesn't bug out when using autoReuse = true
		}
		
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.DirtBlock, 10);
		recipe.AddTile(TileID.WorkBenches);
		recipe.SetResult(this);
		recipe.AddRecipe();
		}
	}
}
