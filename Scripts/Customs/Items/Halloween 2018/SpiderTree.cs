using System;

namespace Server.Items
{
    public class SpiderTree : Item
    {
        [Constructable]
        public SpiderTree()
            : base(41456)
        {
        }

        public SpiderTree(Serial serial)
            : base(serial)
        {
        }
		
		public override string DefaultName
        {
            get
            {
                return "Spider Infested Sapling";
            }
        }

        public override double DefaultWeight
        {
            get
            {
                return 25;
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