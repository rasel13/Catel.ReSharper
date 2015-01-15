﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Catel development team">
//   Copyright (c) 2008 - 2012 Catel development team. All rights reserved.
// </copyright>
// <summary>
//   AssemblyInfo.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Reflection;

using JetBrains.ActionManagement;
#if !R90
using JetBrains.Application.PluginSupport;
#endif

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Catel.ReSharper")]
[assembly: AssemblyDescription("ReSharper plugin for Catel")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Catel development team")]
[assembly: AssemblyProduct("Catel.ReSharper")]
[assembly: AssemblyCopyright("Copyright © Catel development team, 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("1.4.9.27")]
[assembly: AssemblyInformationalVersion("1.4.9.27")]
[assembly: ActionsXml("Catel.ReSharper.Actions.xml")]

#if !R90
// The following information is displayed by ReSharper in the Plugins dialog
[assembly: PluginTitle("Catel.ReSharper")]
[assembly: PluginDescription("ReSharper plugin for Catel")]
[assembly: PluginVendor("Catel development team")]
#endif