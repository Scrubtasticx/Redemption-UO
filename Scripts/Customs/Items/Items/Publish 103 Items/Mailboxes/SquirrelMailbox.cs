using System;

namespace Server.Items
{
    [Furniture]
    [FlipableAttribute(41479, 41481)] // 41478 & 41480 have the "you got mail" flag up.
    public class SquirrelMailbox : LockableContainer
    {
        public override int DefaultGumpID { get { return 0x6D4; } }

        [Constructable]
        public SquirrelMailbox()
            : base(41479)
        {
            Name = "Squirrel Mailbox";
			Weight = 5.0;
        }

        public override void OnItemAdded(Item item)
        {
            base.OnItemAdded(item);

            if (ItemID == 41479)
                ItemID = 41478;
            else if (ItemID == 41481)
                ItemID = 41480;
        }

        public override void OnItemRemoved(Item item)
        {
            base.OnItemRemoved(item);

            if (Items.Count == 0)
            {
                if (ItemID == 41478)
                    ItemID = 41479;
                else if (ItemID == 41480)
                    ItemID = 41481;
            }
        }

        public SquirrelMailbox(Serial serial)
            : base(serial)
        {
        }
		
		public void Flip()
		{
			switch ( this.ItemID )
			{
				case 41479: 
					this.ItemID = 41481; 
					break;//unlit
				case 41478: 
					this.ItemID = 41480; 
					break;//lit

				case 41481: 
					this.ItemID = 41479; 
					break;//unlit
				case 41480: 
					this.ItemID = 41478; 
					break;//lit
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
