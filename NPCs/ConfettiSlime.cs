﻿using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace PissAndShit.NPCs
{
    public class ConfettiSlime : ModNPC
    {
        private int frameNum = 0;
        private int frameTimer = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Confetti Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void SetDefaults()
        {
            npc.height = 139;
            npc.width = 224;
            npc.damage = 50;
            npc.lifeMax = 5000;
            npc.defense = 10;
            npc.knockBackResist = 0;
            npc.value = 20000f;
            npc.aiStyle = 1;
            animationType = NPCID.GreenSlime;
        }

        public override void AI()
        {
            Dust.NewDust(npc.position, npc.width, npc.height, 139);
            Dust.NewDust(npc.position, npc.width, npc.height, 140);
            Dust.NewDust(npc.position, npc.width, npc.height, 141);
            Dust.NewDust(npc.position, npc.width, npc.height, 142);
            frameTimer++;
        }

        public override void FindFrame(int frameHeight)
        {
            if (frameTimer == 6)
            {
                frameNum++;
                frameTimer = 0;
            }

            if (frameNum == 2)
            {
                frameNum = 0;
            }

            npc.frame.Y = frameNum * frameHeight;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (BirthdayParty.PartyIsUp)
            {
                return SpawnCondition.OverworldDaySlime.Chance * 0.1f / 2;
            }

            return 0f;
        }
    }
}