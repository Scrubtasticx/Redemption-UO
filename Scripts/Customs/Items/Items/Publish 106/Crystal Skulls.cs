using System;

namespace Server.Items
{
   
    [Flipable(0x9A1A, 0x9A1B)]
    public class CrystalSkull : Item
    {
        [Constructable]
        public CrystalSkull()
            : base(0x9A1A)
        {
            this.Weight = 2.0;
        }
        
        public override int LabelNumber{ get{return 1123474;} }// Crystal Skull

        public CrystalSkull(Serial serial)
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

        }
    }

    [Flipable(0x9A1C, 0x9A1D)]
    public class JadeOrcSkull : Item
    {
        [Constructable]
        public JadeOrcSkull()
            : base(0x9A1C)
        {
            this.Weight = 2.0;
        }
        
        public override int LabelNumber{ get{return 1123476;} }// Jade Skull

        public JadeOrcSkull(Serial serial)
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

        }
    }
	
	[Flipable(0x9A1E, 0x9A1F)]
    public class GargoyleOnyxSkull : Item
    {
        [Constructable]
        public GargoyleOnyxSkull()
            : base(0x9A1E)
        {
            this.Weight = 2.0;
        }
        
        public override int LabelNumber{ get{return 1123478;} }// Obsidian Skull

        public GargoyleOnyxSkull(Serial serial)
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

        }
    }
	
	[Flipable(41336, 41335)]
    public class SabertoothSkull : Item
    {
        [Constructable]
        public SabertoothSkull()
            : base(41336)
        {
            this.Name = "Sabertooth Skull";
			this.Weight = 2.0;
        }
        
        //public override int LabelNumber{ get{return 1123478;} }// Obsidian Skull

        public SabertoothSkull(Serial serial)
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

        }
    }
	
	[Flipable(41337, 41338)]
    public class TRexSkull : Item
    {
        [Constructable]
        public TRexSkull()
            : base(41337)
        {
            this.Name = "TRex Skull";
			this.Weight = 2.0;
        }
        
        //public override int LabelNumber{ get{return 1123478;} }// Obsidian Skull

        public TRexSkull(Serial serial)
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

        }
    }
	
	[Flipable(41890, 41891)]
    public class RubySkull : Item
    {
        [Constructable]
        public RubySkull()
            : base(41890)
        {
            this.Name = "Ruby Skull";
			this.Weight = 2.0;
        }
        
        //public override int LabelNumber{ get{return 1123478;} }// Obsidian Skull

        public RubySkull(Serial serial)
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

        }
    }
	
	[Flipable(41892, 41893)]
    public class AmethystSkull : Item
    {
        [Constructable]
        public AmethystSkull()
            : base(41892)
        {
            this.Name = "Amethyst Skull";
			this.Weight = 2.0;
        }
        
        //public override int LabelNumber{ get{return 1123478;} }// Obsidian Skull

        public AmethystSkull(Serial serial)
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

        }
    }
}