﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Izibiz.Response
{
    public class AuthResponse
    {
        public string accessToken { get; set; }
        public string validity { get; set; }
        public string customerType { get; set; }
        public string[] privileges { get; set; }
    }
}
