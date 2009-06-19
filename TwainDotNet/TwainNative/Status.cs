﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TwainDotNet.TwainNative
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public class Status
    {
        public short ConditionCode;
        public short Reserved;
    }
}