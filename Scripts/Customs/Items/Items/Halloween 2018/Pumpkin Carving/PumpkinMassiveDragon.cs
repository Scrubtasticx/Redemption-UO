using System;

namespace Server.Items
{
    public class PumpkinMassiveDragon : BaseLight
    {
        [Constructable]
        public PumpkinMassiveDragon()
            : base(41368)
        {
            //this.Name = "Tall Pumpkin Spider";
            if (Burnout)
                this.Duration = TimeSpan.FromMinutes(20);
            else
                this.Duration = TimeSpan.Zero;

            this.Burning = false;
            this.Light = LightType.Circle150;
            this.Weight = 1.0;
        }

        public override int LabelNumber
        {
            get
            {
                return 1096942;
            }
        }// carved pumpkin

        public PumpkinMassiveDragon(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID
        {
            get
            {
                return 41369;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 41368;
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