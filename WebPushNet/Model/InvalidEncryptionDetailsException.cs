﻿namespace WebPushNet.Model
{
    public class InvalidEncryptionDetailsException : Exception
    {
        public InvalidEncryptionDetailsException(string message, PushSubscription pushSubscription)
            : base(message)
        {
            PushSubscription = pushSubscription;
        }

        public PushSubscription PushSubscription { get; }
    }
}
