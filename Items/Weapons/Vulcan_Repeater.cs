using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Console_Port_Mod.Items
{
    public class Vulcan_Repeater : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 38;
            item.useAnimation = 38;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.DD2_BallistaTowerShot;
            item.autoReuse = false;
            item.shoot = 1; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 14f;
            item.useAmmo = 40;
            item.autoReuse = true;
        }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);   //you need 1 DirtBlock
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
        /*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if(type == ProjectileID.WoodenArrowFriendly)
            {
                type = ProjectileID.ExplosiveBullet;
            }
            return true;
        }*/

    }

}