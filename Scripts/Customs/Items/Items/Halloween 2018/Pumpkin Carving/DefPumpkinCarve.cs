using System;
using Server.Items;

namespace Server.Engines.Craft
{
	public class DefPumpkinCarve : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Cooking;	}
		}

		public override int GumpTitleNumber
		{
			get { return 0; } // Use String
		}

		public override string GumpTitleString
		{
			get { return "<basefont color=#FFFFFF><CENTER>PUMPKIN CARVING</CENTER></basefont>"; } 
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefPumpkinCarve();

				return m_CraftSystem;
			}
		}

		public override CraftECA ECA{ get{ return CraftECA.ChanceMinusSixtyToFourtyFive; } }

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.0; // 0%
		}

        private DefPumpkinCarve()
            : base(1, 1, 1.25)// base( 1, 1, 1.5 )
		{
		}

		public override int CanCraft( Mobile from, BaseTool tool, Type itemType )
		{
			if ( tool.Deleted || tool.UsesRemaining < 0 )
				return 1044038; // You have worn out your tool!
			else if ( !BaseTool.CheckAccessible( tool, from ) )
				return 1044263; // The tool must be on your person to use.

			return 0;
		}

		public override void PlayCraftEffect( Mobile from )
		{
			from.PlaySound( 0x21 );
		}

		public override int PlayEndingEffect( Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality, bool makersMark, CraftItem item )
		{
			if ( toolBroken )
				from.SendLocalizedMessage( 1044038 ); // You have worn out your tool

			if ( failed )
			{
				if ( lostMaterial )
					return 1044043; // You failed to create the item, and some of your materials are lost.
				else
					return 1044157; // You failed to create the item, but no materials were lost.
			}
			else
			{
				if ( quality == 0 )
					return 502785; // You were barely able to make this item.  It's quality is below average.
				else if ( makersMark && quality == 2 )
					return 1044156; // You create an exceptional quality item and affix your maker's mark.
				else if ( quality == 2 )
					return 1044155; // You create an exceptional quality item.
				else
                    return 1154339; // *You carefully carve the pumpkin*
			}
		}


// format of AddCraft: AddCraft( typeof( ThingToMake ), Category (text or ##),
//			ThingToMake (text or ##), minskill, maxskill, typeof( FirstThingToConsume),
//			FirstThingToConsume (text or ##), Qty,
//			ErrorMessageForNotHavingFirstThingToConsume (text or ##) );
// format of AddRes:   AddRes( index, typeof( SecondThingToConsume ),
//			SecondThingToConsume (text or ##), Qty,
//			ErrorMessageForNotHavingSecondThingToConsume (text or ##) );

// index = AddCraft( typeof( Make ), Category, Make, minskill, maxskill, typeof( Consume1 ), Consume1, qty, Error );
// AddRes( index, typeof( Consume2 ), Consume2, qty, Error );

		public override void InitCraftList()
		{
			int index = -1;
            index = AddCraft(typeof(PumpkinTallAnkh), "Tall Pumpkin", "Tall Pumpkin Ankh", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
			index = AddCraft(typeof(PumpkinTallBat), "Tall Pumpkin", "Tall Pumpkin Bat", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
            index = AddCraft(typeof(PumpkinTallDemon), "Tall Pumpkin", "Tall Pumpkin Demon", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
            index = AddCraft(typeof(PumpkinTallScalele), "Tall Pumpkin", "Tall Pumpkin Scalele", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
            index = AddCraft(typeof(PumpkinTallSkull), "Tall Pumpkin", "Tall Pumpkin Skull", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
            index = AddCraft(typeof(PumpkinTallSpider), "Tall Pumpkin", "Tall Pumpkin Spider", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
			index = AddCraft(typeof(PumpkinTallSpirit), "Tall Pumpkin", "Tall Pumpkin Spirit", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
			index = AddCraft(typeof(PumpkinTallUO), "Tall Pumpkin", "Tall Pumpkin UO", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
			index = AddCraft(typeof(PumpkinTallWitch), "Tall Pumpkin", "Tall Pumpkin Witch", 0.0, 0.0, typeof(PumpkinTall), 1123239, 1, "You don't have a Tall Pumpkin.");
			
			//Pub 94/101 Additions [Witch/Zombie]/[Rest]
			index = AddCraft(typeof(PumpkinGreenAnkh), "Green Pumpkin", "Green Pumpkin Ankh", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenBat), "Green Pumpkin", "Green Pumpkin Bat", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenCat), "Green Pumpkin", "Green Pumpkin Cat", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenDevil), "Green Pumpkin", "Green Pumpkin Devil", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenGhost), "Green Pumpkin", "Green Pumpkin Ghost", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenOwl), "Green Pumpkin", "Green Pumpkin Owl", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenSkull), "Green Pumpkin", "Green Pumpkin Skull", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenSpider), "Green Pumpkin", "Green Pumpkin Spider", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenSwirls), "Green Pumpkin", "Green Pumpkin Swirls", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenUO), "Green Pumpkin", "Green Pumpkin UO", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenWitch), "Green Pumpkin", "Green Pumpkin Witch", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenWitchB), "Green Pumpkin", "Green Pumpkin Witch Broom", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			index = AddCraft(typeof(PumpkinGreenZombie), "Green Pumpkin", "Green Pumpkin Zombie", 0.0, 0.0, typeof(PumpkinGreen), 1123239, 1, "You don't have a Green Pumpkin.");
			
			//Pub 98/101 Additions [cat/owl]/[rest]
			index = AddCraft(typeof(PumpkinSmallCat), "Small Pumpkin", "Small Pumpkin Cat", 0.0, 0.0, typeof(PumpkinSmall), 1123239, 1, "You don't have a Small Pumpkin.");
			index = AddCraft(typeof(PumpkinSmallOwl), "Small Pumpkin", "Small Pumpkin Owl", 0.0, 0.0, typeof(PumpkinSmall), 1123239, 1, "You don't have a Small Pumpkin.");
			index = AddCraft(typeof(PumpkinSmallSkull), "Small Pumpkin", "Small Pumpkin Skull", 0.0, 0.0, typeof(PumpkinSmall), 1123239, 1, "You don't have a Small Pumpkin.");
			index = AddCraft(typeof(PumpkinSmallTongue), "Small Pumpkin", "Small Pumpkin Tongue-Out", 0.0, 0.0, typeof(PumpkinSmall), 1123239, 1, "You don't have a Small Pumpkin.");
			index = AddCraft(typeof(PumpkinSmallTwoFace), "Small Pumpkin", "Small Pumpkin Two-Face", 0.0, 0.0, typeof(PumpkinSmall), 1123239, 1, "You don't have a Small Pumpkin.");
		}
	}
}