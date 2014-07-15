﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinium.Mining.Pools.Statistics
{
    public interface IPerAlgorithmStats
    {
        string Name { get; }

        Int32 WorkerCount { get; set; }

        UInt64 Hashrate { get; set; }

        void Reset();
    }
}
