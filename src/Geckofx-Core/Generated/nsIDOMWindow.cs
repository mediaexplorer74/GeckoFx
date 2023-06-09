// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMWindow.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;


    /// <summary>
    /// Empty interface for compatibility with older versions.
    /// @deprecated Use WebIDL for script visible features,
    /// nsPIDOMWindow for C++ callers.
    /// </summary>
    [ComImport()]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("b8343993-0383-4add-9930-ad176b189240")]
    public interface nsIDOMWindow
    {
        nsIDOMDocument GetDocumentAttribute();
    }

    /// <summary>
    /// Empty interface for compatibility with older versions.
    /// @deprecated Use nsIDOMWindow instead
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8c589e65-3237-4cd1-8bad-c5c47135e79b")]
	public interface nsIDOMWindowInternal : nsIDOMWindow
	{
	}
}
