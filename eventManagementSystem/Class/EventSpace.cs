using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem
{
    public class EventSpace
    {
        public int venueId {  get; set; }
        public string eventSpaceName { get; set; }
        public int eventSpaceCapacity { get; set; }
        public string eventSpacePriceModel { get; set; }
        public int priceRate { get; set; }
        public string eventSpaceDescription { get; set; }

        public EventSpace(int VenueId, string EventSpaceName, int EventSpaceCapacity, string EventSpacePriceModel,int priceRate, string description)
        {
            this.venueId = VenueId;
            this.eventSpaceName = EventSpaceName;
            this.eventSpaceCapacity = EventSpaceCapacity;
            this.eventSpacePriceModel = EventSpacePriceModel;
            this.priceRate = priceRate;
            this.eventSpaceDescription = description;
        }
    }
}
