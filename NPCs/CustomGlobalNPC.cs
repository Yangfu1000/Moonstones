using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Moonstones.NPCs
{
	public class CustomGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}

		public override void NPCLoot(NPC npc)
		{
			if (npc.lifeMax > 100 && npc.value > 0f && Main.rand.Next(250) == 0)//This is because i find it drops too often while farming
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MoonstoneBlank"));
			}
		}
	}
}
