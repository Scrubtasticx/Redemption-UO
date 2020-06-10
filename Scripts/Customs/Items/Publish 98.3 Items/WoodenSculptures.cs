using System;
using Server;

namespace Server.Items
{
	//Sword Sculpture
	public class SwordSculpture : BaseLight
	{
		public override int LitItemID { get { return 40576; } }
		public override int UnlitItemID { get { return 40430; } }

		[Constructable]
		public SwordSculpture()
			: base( 40430 )
		{
			Name = "Wooden Sword Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public SwordSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//AXE Sculpture
	public class AxeSculpture : BaseLight
	{
		public override int LitItemID { get { return 40577; } }
		public override int UnlitItemID { get { return 40434; } }

		[Constructable]
		public AxeSculpture()
			: base( 40434 )
		{
			Name = "Wooden Axe Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public AxeSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Ankh Sculpture
	public class AnkhSculpture : BaseLight
	{
		public override int LitItemID { get { return 40578; } }
		public override int UnlitItemID { get { return 40438; } }

		[Constructable]
		public AnkhSculpture()
			: base( 40438 )
		{
			Name = "Wooden Ankh Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public AnkhSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Mask Sculpture
	public class MaskSculpture : BaseLight
	{
		public override int LitItemID { get { return 40579; } }
		public override int UnlitItemID { get { return 40442; } }

		[Constructable]
		public MaskSculpture()
			: base( 40442 )
		{
			Name = "Wooden Masks Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public MaskSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Moon Sculpture
	public class MoonSculpture : BaseLight
	{
		public override int LitItemID { get { return 41057; } }
		public override int UnlitItemID { get { return 41056; } }

		[Constructable]
		public MoonSculpture()
			: base( 41056 )
		{
			Name = "Wooden Moon Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public MoonSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Goblet Sculpture
	public class GobletSculpture : BaseLight
	{
		public override int LitItemID { get { return 41062; } }
		public override int UnlitItemID { get { return 41061; } }

		[Constructable]
		public GobletSculpture()
			: base( 41061 )
		{
			Name = "Wooden Goblet Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public GobletSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Skull Sculpture
	public class SkullSculpture : BaseLight
	{
		public override int LitItemID { get { return 41067; } }
		public override int UnlitItemID { get { return 41066; } }

		[Constructable]
		public SkullSculpture()
			: base( 41066 )
		{
			Name = "Wooden Skull Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public SkullSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Seed Sculpture
	public class SeedSculpture : BaseLight
	{
		public override int LitItemID { get { return 41072; } }
		public override int UnlitItemID { get { return 41071; } }

		[Constructable]
		public SeedSculpture()
			: base( 41071 )
		{
			Name = "Wooden Seed Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public SeedSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
}