﻿using System;
using System.Collections.Generic;

namespace Microsoft.DotNet.UpgradeAssistant.Reporting
{
    public record Section(string Header)
        : Content
    {
        public IReadOnlyCollection<Content> Content { get; init; } = Array.Empty<Content>();
    }
}