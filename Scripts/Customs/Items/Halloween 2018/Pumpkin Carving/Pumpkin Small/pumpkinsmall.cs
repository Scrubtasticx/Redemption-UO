using System;

namespace Server.Items
{
    public class PumpkinSmall : Item
    {
        [Constructable]
        public PumpkinSmall()
            : base(0x9F51)
        {
            //this.Name = "Carveable Pumpkin";
        }

        public PumpkinSmall(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1123239;
            }
        }// carvable pumpkin

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