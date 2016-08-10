﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class updateTickers_response : BaseResponse
    {
        public object data;
        public List<Notification> notifications;
    }
}