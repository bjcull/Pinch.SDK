using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinch.SDK.Merchants
{
    public class IdentityVerification
    {
        public string Uri { get; set; }
        public DateTime Expiry { get; set; }
        public Guid Token { get; set; }
    }
}
