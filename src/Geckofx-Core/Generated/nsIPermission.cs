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
// Generated by IDLImporter from file nsIPermission.idl
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
    /// This interface defines a "permission" object,
    /// used to specify allowed/blocked objects from
    /// user-specified sites (cookies, images etc).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bb409a51-2371-4fea-9dc9-b7286a458b8c")]
	public interface nsIPermission
	{
		
		/// <summary>
        /// The principal for which this permission applies.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetPrincipalAttribute();
		
		/// <summary>
        /// a case-sensitive ASCII string, indicating the type of permission
        /// (e.g., "cookie", "image", etc).
        /// This string is specified by the consumer when adding a permission
        /// via nsIPermissionManager.
        /// @see nsIPermissionManager
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);
		
		/// <summary>
        /// The permission (see nsIPermissionManager.idl for allowed values)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCapabilityAttribute();
		
		/// <summary>
        /// The expiration type of the permission (session, time-based or none).
        /// Constants are EXPIRE_*, defined in nsIPermissionManager.
        /// @see nsIPermissionManager
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetExpireTypeAttribute();
		
		/// <summary>
        /// The expiration time of the permission (milliseconds since Jan 1 1970
        /// 0:00:00).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetExpireTimeAttribute();
		
		/// <summary>
        /// Test whether a principal would be affected by this permission.
        ///
        /// @param principal  the principal to test
        /// @param exactHost  If true, only the specific host will be matched,
        /// @see nsIPermissionManager::testExactPermission.
        /// If false, subdomains will also be searched,
        /// @see nsIPermissionManager::testPermission.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Matches([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.U1)] bool exactHost);
		
		/// <summary>
        /// Test whether a URI would be affected by this permission.
        /// This performs a matches with a NO_APP_ID identifier.
        ///
        /// @param uri        the uri to test
        /// @param exactHost  If true, only the specific host will be matched,
        /// @see nsIPermissionManager::testExactPermission.
        /// If false, subdomains will also be searched,
        /// @see nsIPermissionManager::testPermission.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MatchesURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.U1)] bool exactHost);
	}
}
