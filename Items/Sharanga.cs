using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Mods.Items
{
    public class Windbow : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 35;
            item.noMelee = true;
            item.ranged = true;
            item.width = 69;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 1;
            item.knockBack = 1;
            item.value = 120;
            item.rare = 7;
            item.autoReuse = true;
            item.shootSpeed = 10f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FrostburnArrow, damage, knockBack, player.whoAmI, 0f, 0f);
            return false;
        }
        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}