using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBrowser.Controller.Authentication
{
    public enum AuthentificatenStatus
    {
        FAILED = 0,
        WRONG_CREDENTIALS = 1,
        DISABLED = 2,
        LOCAL_NETWORK_ONLY = 3,
        TWO_FACTOR_REQUIRED = 4,        
        SUCCESS = 5
    }
}
