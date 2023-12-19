// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace pyRevitLabs.MahAppsMetro.Automation.Peers
{
    /// <summary>
    /// The MetroHeaderAutomationPeer class exposes the <see cref="T:pyRevitLabs.MahAppsMetro.Controls.MetroHeader" /> type to UI Automation.
    /// </summary>
    public class MetroHeaderAutomationPeer : GroupBoxAutomationPeer
    {
        public MetroHeaderAutomationPeer(GroupBox owner)
            : base(owner)
        {
        }

        protected override string GetClassNameCore()
        {
            return "MetroHeader";
        }
    }
}