﻿namespace Newbe.Mahua.MPQ.EventFuns
{
    ///<summary>
    ///收到来自好友的财付通转账
    ///</summary>
    public class EventFunHandler80001 : IEventFunHandler
    {
        public int EventFun { get; } = 80001;

        public void Handle(EventFunInput eventFunInput)
        {
            //todo not supported
        }
    }
}
