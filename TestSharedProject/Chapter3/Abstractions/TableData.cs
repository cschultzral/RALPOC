﻿using System;

namespace TaskList3.Abstractions
{
    public abstract class TableData
    {
        public string Id { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public string Version { get; set; }
    }
}
