using System;

namespace Server.Items
{
    public class HoodedBritanniaRobe : BaseOuterTorso
	{
		[Constructable]
        public HoodedBritanniaRobe() : base(41131)
        {
            this.Name = "Hooded Britannia Robe";
			this.LootType = LootType.Blessed;
            this.Weight = 3.0;
			
			#region ItemID Chance
			double chance = Utility.RandomDouble() * 100;

            if (chance <= 30)
                this.ItemID = 41131;
				
			else if (chance < 45)
				this.ItemID = 41132;
				
			else if (chance < 60)
				this.ItemID = 41133;
				
			else if (chance < 75)
				this.ItemID = 41134;
				
            else if (chance < 90)
				this.ItemID = 41135;
			#endregion
        }

        public HoodedBritanniaRobe(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}