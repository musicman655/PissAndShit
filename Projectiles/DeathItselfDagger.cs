using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace PissAndShit.Projectiles
{
    public class DeathItselfDagger : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("deaths meme stabber");
        }

        public override void SetDefaults()
        {
            projectile.damage = 400;
            projectile.hostile = true;
            projectile.knockBack = 2;
            projectile.ranged = true;
            projectile.aiStyle = 2;
            projectile.penetrate = 1;
            projectile.width = 22;
	    projectile.height = 52;
            projectile.scale *= 1.3f;
        }

	public override void AI()
	{
	    projectile.velocity = projectile.velocity / 1.0f;
	}
    }
}
