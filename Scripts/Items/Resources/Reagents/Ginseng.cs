using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Ginseng : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public Ginseng() : this( 1 )
		{
		}

		[Constructable]
		public Ginseng( int amount ) : base( 0xF85, amount )
		{
		}

		public Ginseng( Serial serial ) : base( serial )
		{
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}