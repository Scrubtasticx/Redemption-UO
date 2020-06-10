using System;

namespace Server.Items
{
    [Furniture]
    [FlipableAttribute(41475, 41477)] // 41474 & 41476 have the "you got mail" flag up.
    public class DolphinMailbox : LockableContainer
    {
        public override int DefaultGumpID { get { return 0x6D3; } }

        [Constructable]
        public DolphinMailbox()
            : base(41475)
        {
            Name = "Dolphin Mailbox";
			Weight = 5.0;
        }

        public override void OnItemAdded(Item item)
        {
            base.OnItemAdded(item);

            if (ItemID == 41475)
                ItemID = 41474;
            else if (ItemID == 41477)
                ItemID = 41476;
        }

        public override void OnItemRemoved(Item item)
        {
            base.OnItemRemoved(item);

            if (Items.Count == 0)
            {
                if (ItemID == 41474)
                    ItemID = 41475;
                else if (ItemID == 41476)
                    ItemID = 41477;
            }
        }

        public DolphinMailbox(Serial serial)
            : base(serial)
        {
        }
		
		public void Flip()
		{
			switch ( this.ItemID )
			{
				case 41475: 
					this.ItemID = 41477; 
					break;//unlit
				case 41474: 
					this.ItemID = 41476; 
					break;//lit

				case 41477: 
					this.ItemID = 41475; 
					break;//unlit
				case 41476: 
					this.ItemID = 41474; 
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
