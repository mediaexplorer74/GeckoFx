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
// Generated by IDLImporter from file nsICookieAcceptDialog.idl
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
    ///This file contains some constants for the cookie accept dialog
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3F2F0D2C-BDEA-4B5A-AFC6-FCF18F66B97E")]
	public interface nsICookieAcceptDialog
	{
	}
	
	/// <summary>nsICookieAcceptDialogConsts </summary>
	public class nsICookieAcceptDialogConsts
	{
		
		// <summary>
        //This file contains some constants for the cookie accept dialog
        //
        // </summary>
		public const short ACCEPT_COOKIE = 0;
		
		// 
		public const short REMEMBER_DECISION = 1;
		
		// 
		public const short HOSTNAME = 2;
		
		// 
		public const short COOKIESFROMHOST = 3;
		
		// 
		public const short CHANGINGCOOKIE = 4;
	}
}
