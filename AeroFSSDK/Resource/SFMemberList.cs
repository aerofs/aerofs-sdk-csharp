﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AeroFSSDK
{
    public class SFMemberList
    {
        public IList<SFMember> SFMembers { get; set; }
        public string ETag { get; set; }
    }
}