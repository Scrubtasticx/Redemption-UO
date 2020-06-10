using System;

namespace Server.Items
{
    [Furniture]
    [Flipable(41052, 41053, 41054, 41055)]
    public class ValentinesChair : Item
    {
        [Constructable]
        public ValentinesChair() : base(41052)
        {
            Name = "Wireframe Chair";
			this.Weight = 10.0;
        }

        public ValentinesChair(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (this.Weight == 6.0)
                this.Weight = 10.0;
        }
    }
	
	[Furniture]
    [Flipable(41052, 41053, 41054, 41055)]
    public class ValentinesChairHued : Item
    {
        [Constructable]
		public ValentinesChairHued() : this( Utility.RandomDyedHue() )
		{
		}
		
		[Constructable]
        public ValentinesChairHued( int hue ) : base(41052)
        {
            Name = "Wireframe Chair";
			this.Weight = 10.0;
			Hue = hue;
        }

        public ValentinesChairHued(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (this.Weight == 6.0)
                this.Weight = 10.0;
        }
    }
}