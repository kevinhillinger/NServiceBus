﻿namespace NServiceBus.Core.Tests.Fakes
{
    using System;
    using Unicast.Transport.Transactional;

    public class FakeReceiver : IDequeueMessages
    {
        public void FakeMessageReceived()
        {
            var tm = new TransportMessage();

            if (TryProcessMessage(tm))
                NumMessagesReceived++;
        }

        public void Init(Address address, TransactionSettings transactionSettings, Func<TransportMessage, bool> tryProcessMessage)
        {
            TryProcessMessage = tryProcessMessage;
        }

        public void Start(int maximumConcurrencyLevel)
        {
            
        }

        public void Stop()
        {
           
        }

        Func<TransportMessage, bool> TryProcessMessage;
        public int NumMessagesReceived;
    }
}