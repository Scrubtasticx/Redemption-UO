using System; 
using Server.Mobiles; 

namespace Server.Items 
{ 
	public class EtherealPeacock : EtherealMount 
	{ 
		[Constructable] 
		public EtherealPeacock() : base( 16079, 0xA0C0 ) 
		{ 
			Name = "Ehereal Peacock";
			ItemID = 41152;
			MountedID = 16079;
			RegularID = 0xA0C0;
			LootType = LootType.Blessed;
		} 

		public EtherealPeacock( Serial serial ) : base( serial ) 
		{ 
		} 

		

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 

			if ( Name != "Ethereal Peacock" )
				Name = "Ethereal Peacock";
		} 
	}
}

