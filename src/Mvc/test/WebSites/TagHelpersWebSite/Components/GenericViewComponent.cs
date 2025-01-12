﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TagHelpersWebSite.Components
{
    public class GenericViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Dictionary<string, List<string>> items)
        {
            return View(items);
        }
    }
}
