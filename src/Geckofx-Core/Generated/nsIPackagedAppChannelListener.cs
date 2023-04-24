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
// Generated by IDLImporter from file nsIPackagedAppChannelListener.idl
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
    /// nsIPackagedAppChannelListener
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("27caf7d0-3c0e-11e5-b970-0800200c9a66")]
	public interface nsIPackagedAppChannelListener
	{
		
		/// <summary>
        /// @param aPackageId
        /// the package identifier of the signed package that we are going
        /// to load. The identifier will be defined in the manifest of the
        /// package.
        ///
        /// This callback is to notify a signed package is about to load. Some
        /// component else will be in charge of responding to this fact properly.
        /// The procotol layer should have no idea what to do with this.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartSignedPackageRequest([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPackageId);
	}
}
