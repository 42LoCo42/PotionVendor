using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PotionVendor
{
	class ShopChanges : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if(type == NPCID.TravellingMerchant) {
				var rng = new Random();
				rng.Shuffle(PotionVendor.buffPotions);
				
				int index = 0;
				
				for(int i=0; i<PotionVendor.maxPotions; i++) {
					while(true) {
						PotionIdent p = PotionVendor.buffPotions[index];
						if((!p.boss2 || p.boss2 & NPC.downedBoss2) & (!p.skeletron || p.skeletron & NPC.downedBoss3) & (!p.hardmode || p.boss2 & Main.hardMode) & (!p.plantera || p.boss2 & NPC.downedPlantBoss)) {
							shop.item[nextSlot].SetDefaults(p.id);
							nextSlot++;
							break;
						}
						else {
							index++;
						}
					}
					index++;
				}
				
				index = 0;
				while(true) {
					PotionIdent p = PotionVendor.flasks[index];
					if((!p.boss2 || p.boss2 & NPC.downedBoss2) & (!p.skeletron || p.skeletron & NPC.downedBoss3) & (!p.hardmode || p.boss2 & Main.hardMode) & (!p.plantera || p.boss2 & NPC.downedPlantBoss)) {
						shop.item[nextSlot].SetDefaults(p.id);
						nextSlot++;
						break;
					}
					else {
						index++;
					}
				}
				
				index = 0;
				while(true) {
					PotionIdent p = PotionVendor.other[index];
					if((!p.boss2 || p.boss2 & NPC.downedBoss2) & (!p.skeletron || p.skeletron & NPC.downedBoss3) & (!p.hardmode || p.boss2 & Main.hardMode) & (!p.plantera || p.boss2 & NPC.downedPlantBoss)) {
						shop.item[nextSlot].SetDefaults(p.id);
						nextSlot++;
						break;
					}
					else {
						index++;
					}
				}
			}
		}
	}
}