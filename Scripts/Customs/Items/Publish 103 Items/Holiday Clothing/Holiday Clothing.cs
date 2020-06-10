using System;
using System.Collections.Generic;
using Server.Engines.Craft;
using Server.Network;

namespace Server.Items
{
    [Flipable(41615, 41616)]
    public class HolidayHat : BaseHat
    {
        [Constructable]
        public HolidayHat()
            : this(0)
        {
        }

        [Constructable]
        public HolidayHat(int hue)
            : base(41615, hue)
        {
            Name = "Santa Hat";
			LootType = LootType.Blessed;
			this.Weight = 1.0;
        }

        public HolidayHat(Serial serial)
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
	
	[Flipable(41613, 41614)]
    public class HolidayBoots : BaseShoes
    {
        [Constructable]
        public HolidayBoots()
            : this(0)
        {
        }

        [Constructable]
        public HolidayBoots(int hue)
            : base(41613, hue)
        {
            Name = "Santa Hat";
			LootType = LootType.Blessed;
			this.Weight = 1.0;
        }

        public HolidayBoots(Serial serial)
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