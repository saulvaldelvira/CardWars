// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// BuildingCard
public class BuildingCard : CardForm
{
	public override int BaseATK
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override int BaseDEF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public BuildingCard()
	{
		base.Type = CardType.Building;
	}
}
