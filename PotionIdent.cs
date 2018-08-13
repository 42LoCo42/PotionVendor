public class PotionIdent
{
	public int id;
	public bool boss2 = false;
	public bool skeletron = false;
	public bool hardmode = false;
	public bool plantera = false;
	
	public PotionIdent(int id) {
		this.id = id;
	}
	
	public PotionIdent(int id, bool boss2, bool skeletron, bool hardmode, bool plantera) {
		this.id = id;
		this.boss2 = boss2;
		this.skeletron = skeletron;
		this.hardmode = hardmode;
		this.plantera = plantera;
	}
}