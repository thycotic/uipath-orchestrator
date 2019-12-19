﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretServer.SecureStore
{
    public class SecretServerContext
    {
        public string SecretServerUrl { get; set; }
        public string RuleName { get; set; }
        public string RuleKey { get; set; }
        public string ResetToken { get; set; }
        public string UsernameField { get; set; }
        public string PasswordField { get; set; }   
        public string SdkConfigDirectory { get; set; }   
    }
}
