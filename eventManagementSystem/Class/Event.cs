using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.Class
{
    public class Event
    {
        public string eventName { get; set; }
        public string displayName { get; set; }
        public string eventType { get; set; }
        public DateTime eventDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool ispublic { get; set; }
        public bool needTicketing { get; set; }
        public bool needConfirmation { get; set; }
        public bool needLocation { get; set; }
        public int participantCount { get; set; }
        public int maxParticipantCount { get; set; }
        public int ticketCount { get; set; }
        public int ticketValue { get; set; }
        public bool isActive { get; set; }
        public int eventBudget { get; set; }
        public int maxBudget { get; set; }
        public byte[] imageData { get; set; }
        public int userId { get; set; }
        public string userRole { get; set; }

        public Event(string EventName, string DisplayName, string EventType, DateTime EventDate, DateTime StartTime, DateTime EndTime, bool IsPublic, bool NeedTicketing, bool NeedConfirmation, bool NeedLocation, int ParticipantCount, int MaxParticipantCount, int TicketCount, int TicketValue, bool IsActive,int EventBudget, int MaxBudget, byte[] imgData,int UserId,string UserRole)
        {
            this.eventName = EventName;
            this.displayName = DisplayName;
            this.eventType = EventType;
            this.eventDate = EventDate;
            this.startTime = StartTime;
            this.endTime = EndTime;
            this.ispublic = IsPublic;
            this.needTicketing = NeedTicketing;
            this.needConfirmation = NeedConfirmation;
            this.needLocation = NeedLocation;
            this.participantCount = ParticipantCount;
            this.maxParticipantCount = MaxParticipantCount;
            this.ticketCount = TicketCount;
            this.ticketValue = TicketValue;
            this.isActive = IsActive;
            this.eventBudget = EventBudget;
            this.maxBudget = MaxBudget;
            this.imageData = imgData;
            this.userId = UserId;
            this.userRole = UserRole;
        }
    }
}
