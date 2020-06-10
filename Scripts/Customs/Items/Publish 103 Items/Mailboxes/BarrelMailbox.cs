using System;

namespace Server.Items
{
    [Furniture]
    [FlipableAttribute(41463, 41465)] // 41461 & 41464 have the "you got mail" flag up.
    public class BarrelMailbox : LockableContainer
    {
        public override int DefaultGumpID { get { return 0x6D5; } }

        [Constructable]
        public BarrelMailbox()
            : base(41463)
        {
            Name = "Barrel Mailbox";
			Weight = 5.0;
        }

        public override void OnItemAdded(Item item)
        {
            base.OnItemAdded(item);

            if (ItemID == 41463)
                ItemID = 41461;
            else if (ItemID == 41465)
                ItemID = 41464;
        }

        public override void OnItemRemoved(Item item)
        {
            base.OnItemRemoved(item);

            if (Items.Count == 0)
            {
                if (ItemID == 41461)
                    ItemID = 41463;
                else if (ItemID == 41464)
                    ItemID = 41465;
            }
        }

        public BarrelMailbox(Serial serial)
            : base(serial)
        {
        }
		
		public void Flip()
		{
			switch ( this.ItemID )
			{
				case 41461: 
					this.ItemID = 41464; 
					break;//unlit
				case 41463: 
					this.ItemID = 41465; 
					break;//lit

				case 41464: 
					this.ItemID = 41461; 
					break;//unlit
				case 41465: 
					this.ItemID = 41463; 
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
