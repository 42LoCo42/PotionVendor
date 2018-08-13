using Terraria.ID;
using Terraria.ModLoader;

namespace PotionVendor
{
	class PotionVendor : Mod
	{
		public const int maxPotions = 10;
		//others are 1 each
		
		public static PotionIdent[] buffPotions = {
			new PotionIdent(ItemID.AmmoReservationPotion),
			new PotionIdent(ItemID.ArcheryPotion),
			new PotionIdent(ItemID.BattlePotion),
			new PotionIdent(ItemID.BuilderPotion),
			new PotionIdent(ItemID.CalmingPotion),
			new PotionIdent(ItemID.CratePotion, true, false, false, false), //requires Deathbringer Pickaxe because nobody sifts a trillion silt
			new PotionIdent(ItemID.TrapsightPotion),
			new PotionIdent(ItemID.EndurancePotion),
			new PotionIdent(ItemID.FeatherfallPotion),
			new PotionIdent(ItemID.FishingPotion),
			new PotionIdent(ItemID.FlipperPotion),
			new PotionIdent(ItemID.GillsPotion),
			new PotionIdent(ItemID.GravitationPotion),
			new PotionIdent(ItemID.HeartreachPotion),
			new PotionIdent(ItemID.HunterPotion),
			new PotionIdent(ItemID.InfernoPotion, false, false, true, false),
			new PotionIdent(ItemID.InvisibilityPotion),
			new PotionIdent(ItemID.IronskinPotion),
			new PotionIdent(ItemID.LifeforcePotion, false, false, true, false),
			new PotionIdent(ItemID.LovePotion, false, false, true, false),
			new PotionIdent(ItemID.MagicPowerPotion),
			new PotionIdent(ItemID.ManaRegenerationPotion),
			new PotionIdent(ItemID.MiningPotion),
			new PotionIdent(ItemID.NightOwlPotion),
			new PotionIdent(ItemID.ObsidianSkinPotion),
			new PotionIdent(ItemID.RagePotion),
			new PotionIdent(ItemID.RegenerationPotion),
			new PotionIdent(ItemID.ShinePotion),
			new PotionIdent(ItemID.SonarPotion),
			new PotionIdent(ItemID.SpelunkerPotion),
			new PotionIdent(ItemID.StinkPotion),
			new PotionIdent(ItemID.SummoningPotion),
			new PotionIdent(ItemID.SwiftnessPotion),
			new PotionIdent(ItemID.ThornsPotion),
			new PotionIdent(ItemID.TitanPotion, false, true, false, false),
			new PotionIdent(ItemID.WarmthPotion),
			new PotionIdent(ItemID.WaterWalkingPotion),
			new PotionIdent(ItemID.WrathPotion)
		};

		public static PotionIdent[] flasks = {
			new PotionIdent(ItemID.FlaskofPoison),
			new PotionIdent(ItemID.FlaskofFire, true, false, false, false),
			new PotionIdent(ItemID.FlaskofVenom, false, false, true, true),
			new PotionIdent(ItemID.FlaskofGold, false, false, true, false),
			new PotionIdent(ItemID.FlaskofIchor, false, false, true, false),
			new PotionIdent(ItemID.FlaskofCursedFlames, false, false, true, false),
			new PotionIdent(ItemID.FlaskofNanites, false, false, true, true),
			new PotionIdent(ItemID.FlaskofParty, false, true, false, false)
		};

		public static PotionIdent[] other = {
			new PotionIdent(ItemID.RecallPotion),
			new PotionIdent(ItemID.WormholePotion),
			new PotionIdent(ItemID.TeleportationPotion, false, false, true, false),
			new PotionIdent(ItemID.GenderChangePotion),
			new PotionIdent(ItemID.RedPotion, true, true, true, true) //If you dare...
		};
	}
}