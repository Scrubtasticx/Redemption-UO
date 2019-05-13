// Engine r143
using System;
using System.Collections;
using System.IO;
using Server;
using Server.Commands; 
using Server.Gumps;
using Server.Items;
using Server.Mobiles; 
using Server.Network;

namespace Server.Commands 
{
	public class CreateWorld
	{
		public CreateWorld()
		{
		}

		public static void Initialize() 
		{ 
			CommandSystem.Register( "Createworld", AccessLevel.Administrator, new CommandEventHandler( Create_OnCommand ) ); 
		} 

		[Usage( "[CreateWorld" )]
		[Description( "Generates world decorations, doors, signs and moongates with a menu." )]
		private static void Create_OnCommand( CommandEventArgs e )
		{
			e.Mobile.SendGump( new CreateWorldGump( e ) );
		}
	}
}

namespace Server.Gumps
{
	public class CreateWorldGump : Gump
	{
		private CommandEventArgs m_CommandEventArgs;

        public CreateWorldGump( CommandEventArgs e ) : base( 70, 70 )
        {
            this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;

	//NOTE: generic button format (x, y, ItemID, ItemID pressed, ButtonID )

			AddPage(1);

	//Background (x, y, largura, altura, item)
			AddBackground(449, 379, 455, 243, 9200);
			
	//Titles
			AddLabel(625, 385, 0, @"CREATE WORLD");
	//Options
			AddButton(465, 584, 4005, 4006, 1, GumpButtonType.Reply, 0);
			AddHtml( 500, 450, 350, 81, @"Will Generate world for you.", (bool)true, (bool)true);
        }
		
		public static void DoThis( Mobile from, string command)
		{
			string prefix = Server.Commands.CommandSystem.Prefix;
			CommandSystem.Handle( from, String.Format( "{0}{1}", prefix, command ) );
		}
		
		public static void DoBegin( Mobile from )
		{
			DoThis( from, "Decorate" );
			DoThis( from, "DecorateMag" );
			DoThis( from, "Moongen" );
			DoThis( from, "DoorGen" );
			DoThis( from, "SignGen" ); 
			DoThis( from, "TelGen" );
			DoThis( from, "SHtelgen" );
			DoThis( from, "GenLeverPuzzle");
			DoThis( from, "GenGauntlet" );
			DoThis( from, "GenKhaldun" );
			DoThis( from, "GenerateFactions" );
			DoThis( from, "GenStealArties" );
			DoThis( from, "SecretLocGen" );
		}

		public static void DoEnd( Mobile from )
		{
			DoThis( from, "UOAMVendors" );
			DoThis( from, "XmlLoad Spawns.xml" );
		}
		
		public override void OnResponse( NetState sender, RelayInfo info ) 
		{ 
			Mobile from = sender.Mobile; 

			switch( info.ButtonID ) 
			{ 
				case 0: // Closed or Canceled
				{
					break;
				}
				
				case 1:
				{
					DoBegin( from );
					
					DoEnd( from );
					break;
				}
			} 
		}
	}
}
