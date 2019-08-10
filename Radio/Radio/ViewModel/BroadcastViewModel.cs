using Radio.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radio.ViewModel
{
    public class BroadcastViewModel
    {
        public List<Broadcast> Broadcasts { get; set; }

        public BroadcastViewModel()
        {
            Broadcasts = new Broadcast().GetBroadcasts();
        }
    }
}
