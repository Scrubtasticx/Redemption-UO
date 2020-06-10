using System;

namespace Server.Items
{
    public class ValentinesTable : BaseLight
    {
        [Constructable]
        public ValentinesTable() : base(40964)
        {
            this.Name = "Wireframe Table";
			this.Duration = TimeSpan.Zero; // Never burnt out
            this.Burning = false;
            this.Light = LightType.Circle300;
            this.Weight = 20.0;
			
		}

        public ValentinesTable(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID
        {
            get
            {
                return 40965;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 40964;
            }
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
        }
    }
	
	public class ValentinesTableHued : BaseLight
    {
        [Constructable]
        public ValentinesTableHued() : this( Utility.RandomDyedHue() )
		{
		}
		
		[Constructable]
        public ValentinesTableHued( int hue ) : base(40964)
        {
            this.Name = "Wireframe Table";
			this.Duration = TimeSpan.Zero; // Never burnt out
            this.Burning = false;
            this.Light = LightType.Circle300;
            this.Weight = 20.0;
			this.Hue = hue;
			
		}

        public ValentinesTableHued(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID
        {
            get
            {
                return 40965;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 40964;
            }
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
        }
    }
}