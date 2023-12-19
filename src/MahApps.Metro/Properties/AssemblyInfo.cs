﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]

[assembly: SuppressMessage("Microsoft.Performance", "CA1824:MarkAssembliesWithNeutralResourcesLanguage")]
[assembly: System.Resources.NeutralResourcesLanguage("en", System.Resources.UltimateResourceFallbackLocation.MainAssembly)]

[assembly: XmlnsPrefix(@"http://metro.mahapps.com/winfx/xaml/controls", "mah")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Behaviors")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Theming")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Automation.Peers")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Accessibility")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.ValueBoxes")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Actions")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Converters")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Markup")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Controls")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/controls", "pyRevitLabs.MahAppsMetro.Controls.Dialogs")]

[assembly: XmlnsPrefix(@"http://metro.mahapps.com/winfx/xaml/shared", "mah")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/shared", "pyRevitLabs.MahAppsMetro.Behaviors")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/shared", "pyRevitLabs.MahAppsMetro.Actions")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/shared", "pyRevitLabs.MahAppsMetro.Converters")]
[assembly: XmlnsDefinition(@"http://metro.mahapps.com/winfx/xaml/shared", "pyRevitLabs.MahAppsMetro.Markup")]

[assembly: SuppressMessage("WpfAnalyzers.DependencyProperty", "WPF0005:Name of PropertyChangedCallback should match registered name.")]
[assembly: SuppressMessage("WpfAnalyzers.DependencyProperty", "WPF0006:Name of CoerceValueCallback should match registered name.")]
[assembly: SuppressMessage("WpfAnalyzers.DependencyProperty", "WPF0007:Name of ValidateValueCallback should match registered name.")]
[assembly: SuppressMessage("WpfAnalyzers.DependencyProperty", "WPF0036:Avoid side effects in CLR accessors.")]
[assembly: SuppressMessage("WpfAnalyzers.DependencyProperty", "WPF0041:Set mutable dependency properties using SetCurrentValue.")]