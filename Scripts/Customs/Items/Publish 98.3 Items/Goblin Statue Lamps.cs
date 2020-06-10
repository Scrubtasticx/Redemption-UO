using System;

namespace Server.Items
{
    public class GreenGoblinStatueLamp : BaseLight
    {
        [Constructable]
        public GreenGoblinStatueLamp() : base(41109)
        {
            this.Name = "Green Goblin Statue Lamp";
			this.Duration = TimeSpan.Zero; // Never burnt out
            this.Burning = false;
            this.Light = LightType.Circle300;
            this.Weight = 20.0;
			
		}

        public GreenGoblinStatueLamp(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID
        {
            get
            {
                return 41110;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 41109;
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
	
	public class GreyGoblinStatueLamp : BaseLight
    {
        [Constructable]
        public GreyGoblinStatueLamp() : base(41111)
        {
            this.Name = "Grey Goblin Statue Lamp";
			this.Duration = TimeSpan.Zero; // Never burnt out
            this.Burning = false;
            this.Light = LightType.Circle300;
            this.Weight = 20.0;
			
		}

        public GreyGoblinStatueLamp(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID
        {
            get
            {
                return 41112;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 41111;
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