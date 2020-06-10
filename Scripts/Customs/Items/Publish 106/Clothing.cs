using System;
using System.Collections.Generic;
using Server.Engines.Craft;
using Server.Network;

namespace Server.Items
{
    public class JackOLanturnMask : BaseHat
    {
        [Constructable]
        public JackOLanturnMask()
            : this(0)
        {
        }

        [Constructable]
        public JackOLanturnMask(int hue)
            : base(41962, hue)
        {
            Name = "Jack-O-Lanturn Mask";
			//LootType = LootType.Blessed;
			this.Weight = 1.0;
        }

        public JackOLanturnMask(Serial serial)
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
	
	public class BakeKitsuneHat : BaseHat
    {
        [Constructable]
        public BakeKitsuneHat()
            : this(0)
        {
        }

        [Constructable]
        public BakeKitsuneHat(int hue)
            : base(42027, hue)
        {
            Name = "Bake Kitsune Pelt Hat";
			//LootType = LootType.Blessed;
			this.Weight = 1.0;
        }

        public BakeKitsuneHat(Serial serial)
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
	
	public class CaptainsHeartyAleShield : BaseShield
    {
        [Constructable]
        public CaptainsHeartyAleShield()
            : base(41995)
        {
            Name = "Captain's Hearty Ale";
			Layer = Layer.TwoHanded;
			this.Weight = 1.0;
        }

        public CaptainsHeartyAleShield(Serial serial)
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
	
	public class BeadNecklace : BaseNecklace
    {
        [Constructable]
        public BeadNecklace()
            : base(42025)
        {
            Name = "Triangular Bead Necklace";
			//LootType = LootType.Blessed;
			this.Weight = 1.0;
        }

        public BeadNecklace(Serial serial)
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
	
	public class FancyBeadNecklace : BaseNecklace
    {
        [Constructable]
        public FancyBeadNecklace()
            : base(42026)
        {
            Name = "Fancy Triangular Bead Necklace";
			//LootType = LootType.Blessed;
			this.Weight = 1.0;
        }

        public FancyBeadNecklace(Serial serial)
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