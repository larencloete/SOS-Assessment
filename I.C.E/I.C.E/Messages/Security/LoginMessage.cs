using I.C.E.Models.Security;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace I.C.E.Messages.Security
{
    public class LoginMessage : PubSubEvent<UserProfile>
    {
    }
}