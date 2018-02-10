using System;

namespace DShop.Messages.Events.Identity
{
    public class SignInRejected : IRejectedEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        public string Reason { get; }

        public string Code { get; }

        protected SignInRejected()
        {
        }

        public SignInRejected(Guid requestId, Guid userId,
            string reason, string code)
        {
            RequestId = requestId;
            UserId = userId;
            Reason = reason;
            Code = code;
        }
    }
}