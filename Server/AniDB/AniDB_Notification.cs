using System;

namespace Shoko.Models.Server
{
    public class AniDB_Notification : ICloneable
    {
        public int AniDB_NotificationID { get; set; }
        public int NotificationID { get; set; }
        public int RelatedTypeID { get; set; }
        public int NotificationType { get; set; }
        public int CountPending { get; set; }
        public DateTime Date { get; set; }
        public string RelatedTypeName { get; set; }
        public string FileIds { get; set; }

        public object Clone()
        {
            return new AniDB_Notification
            {
                AniDB_NotificationID = AniDB_NotificationID,
                NotificationID = NotificationID,
                RelatedTypeID = RelatedTypeID,
                NotificationType = NotificationType,
                CountPending = CountPending,
                Date = Date,
                RelatedTypeName = RelatedTypeName,
                FileIds = FileIds
            };
        }
    }
}
