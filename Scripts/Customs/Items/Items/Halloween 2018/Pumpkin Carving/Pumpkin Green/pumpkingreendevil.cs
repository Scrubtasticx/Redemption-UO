using System;

namespace Server.Items
{
    public class PumpkinGreenDevil : BaseLight
    {
        [Constructable]
        public PumpkinGreenDevil()
            : base(41281)
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

        public PumpkinGreenDevil(Serial serial)
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
                return 41282;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 41281;
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