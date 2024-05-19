using System;

namespace Shoko.Models.Server
{
    public class AniDB_Message : ICloneable
    {
        public int AniDB_MessageID { get; set; }
        public int MessageID { get; set; }
        public int FromUserId { get; set; }
        public string FromUserName { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public object Clone()
        {
            return new AniDB_Message
            {
                AniDB_MessageID = AniDB_MessageID,
                MessageID = MessageID,
                FromUserId = FromUserId,
                FromUserName = FromUserName,
                Date = Date,
                Type = Type,
                Title = Title,
                Body = Body
            };
        }
    }
}
