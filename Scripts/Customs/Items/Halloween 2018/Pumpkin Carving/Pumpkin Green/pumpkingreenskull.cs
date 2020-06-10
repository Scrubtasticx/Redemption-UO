using System;

namespace Server.Items
{
    public class PumpkinGreenSkull : BaseLight
    {
        [Constructable]
        public PumpkinGreenSkull()
            : base(41297)
        {
            //this.Name = "Tall Pumpkin Bat";
            if (Burnout)
                this.Duration = TimeSpan.FromMinutes(20);
            else
                this.Duration = TimeSpan.Zero;

            this.Burning = false;
            this.Light = LightType.Circle150;
            this.Weight = 1.0;
        }

        public PumpkinGreenSkull(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1096938;
            }
        }// carved pumpkin

        public override int LitItemID
        {
            get
            {
                return 41298;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 41297;
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