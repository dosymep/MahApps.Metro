﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using pyRevitLabs.MahAppsMetro.Controls;

namespace Caliburn.Metro.Demo.ViewModels.Flyouts
{
    public class Flyout1ViewModel : FlyoutBaseViewModel
    {
        public Flyout1ViewModel()
        {
            this.Header = "settings";
            this.Position = Position.Right;
        }
    }
}