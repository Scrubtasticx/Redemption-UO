using System;

namespace Server.Items
{
    public class ZombiePainting : Item
    {
        [Constructable]
        public ZombiePainting()
            : base(Utility.RandomBool() ? 41438 : 41439)
        {
        }

        public ZombiePainting(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "Monster Painting: Zombie";
            }
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
	
	public class SkeletonPainting : Item
    {
        [Constructable]
        public SkeletonPainting()
            : base(Utility.RandomBool() ? 41440 : 41441)
        {
        }

        public SkeletonPainting(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "Monster Painting: Skeleton";
            }
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
	
	public class LichPainting : Item
    {
        [Constructable]
        public LichPainting()
            : base(Utility.RandomBool() ? 41442 : 41443)
        {
        }

        public LichPainting(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "Monster Painting: Lich";
            }
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