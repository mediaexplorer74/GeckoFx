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
// Generated by IDLImporter from file nsIRequest.idl
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
    /// nsIRequest
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ef6bfbd2-fd46-48d8-96b7-9f8f0fd387fe")]
	public interface nsIRequest
	{
		
		/// <summary>
        /// The name of the request.  Often this is the URI of the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Indicates whether the request is pending. nsIRequest::isPending is
        /// true when there is an outstanding asynchronous event that will make
        /// the request no longer be pending.  Requests do not necessarily start
        /// out pending; in some cases, requests have to be explicitly initiated
        /// (e.g. nsIChannel implementations are only pending once asyncOpen
        /// returns successfully).
        ///
        /// Requests can become pending multiple times during their lifetime.
        ///
        /// @return TRUE if the request has yet to reach completion.
        /// @return FALSE if the request has reached completion (e.g., after
        /// OnStopRequest has fired).
        /// @note Suspended requests are still considered pending.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPending();
		
		/// <summary>
        /// The error status associated with the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStatusAttribute();
		
		/// <summary>
        /// Cancels the current request.  This will close any open input or
        /// output streams and terminate any async requests.  Users should
        /// normally pass NS_BINDING_ABORTED, although other errors may also
        /// be passed.  The error passed in will become the value of the
        /// status attribute.
        ///
        /// Implementations must not send any notifications (e.g. via
        /// nsIRequestObserver) synchronously from this function. Similarly,
        /// removal from the load group (if any) must also happen asynchronously.
        ///
        /// Requests that use nsIStreamListener must not call onDataAvailable
        /// anymore after cancel has been called.
        ///
        /// @param aStatus the reason for canceling this request.
        ///
        /// NOTE: most nsIRequest implementations expect aStatus to be a
        /// failure code; however, some implementations may allow aStatus to
        /// be a success code such as NS_OK.  In general, aStatus should be
        /// a failure code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aStatus);
		
		/// <summary>
        /// Suspends the current request.  This may have the effect of closing
        /// any underlying transport (in order to free up resources), although
        /// any open streams remain logically opened and will continue delivering
        /// data when the transport is resumed.
        ///
        /// Calling cancel() on a suspended request must not send any
        /// notifications (such as onstopRequest) until the request is resumed.
        ///
        /// NOTE: some implementations are unable to immediately suspend, and
        /// may continue to deliver events already posted to an event queue. In
        /// general, callers should be capable of handling events even after
        /// suspending a request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suspend();
		
		/// <summary>
        /// Resumes the current request.  This may have the effect of re-opening
        /// any underlying transport and will resume the delivery of data to
        /// any open streams.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resume();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLoadFlagsAttribute();
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadFlagsAttribute(uint aLoadFlags);
	}
	
	/// <summary>nsIRequestConsts </summary>
	public class nsIRequestConsts
	{
		
		// <summary>
        // Mask defining the bits reserved for nsIRequest LoadFlags
        // </summary>
		public const ulong LOAD_REQUESTMASK = 0xFFFF;
		
		// <summary>
        // No special load flags:
        // </summary>
		public const ulong LOAD_NORMAL = 0;
		
		// <summary>
        // Do not deliver status notifications to the nsIProgressEventSink and
        // do not block the loadgroup from completing (should this load belong to one).
        // Note: Progress notifications will still be delivered.
        // </summary>
		public const ulong LOAD_BACKGROUND = 1<<0;
		
		// <summary>
        // This flag prevents loading of the request with an HTTP pipeline.
        // Generally this is because the resource is expected to take a
        // while to load and may cause head of line blocking problems.
        // </summary>
		public const ulong INHIBIT_PIPELINE = 1<<6;
		
		// <summary>
        // This flag prevents caching of any kind.  It does not, however, prevent
        // cached content from being used to satisfy this request.
        // </summary>
		public const ulong INHIBIT_CACHING = 1<<7;
		
		// <summary>
        // This flag prevents caching on disk (or other persistent media), which
        // may be needed to preserve privacy.  For HTTPS, this flag is set auto-
        // matically.
        // </summary>
		public const ulong INHIBIT_PERSISTENT_CACHING = 1<<8;
		
		// <summary>
        // Force an end-to-end download of content data from the origin server.
        // This flag is used for a shift-reload.
        // </summary>
		public const ulong LOAD_BYPASS_CACHE = 1<<9;
		
		// <summary>
        // Attempt to force a load from the cache, bypassing ALL validation logic
        // (note: this is stronger than VALIDATE_NEVER, which still validates for
        // certain conditions).
        //
        // If the resource is not present in cache, it will be loaded from the
        // network.  Combine this flag with LOAD_ONLY_FROM_CACHE if you wish to
        // perform cache-only loads without validation checks.
        //
        // This flag is used when browsing via history.  It is not recommended for
        // normal browsing as it may likely violate reasonable assumptions made by
        // the server and confuse users.
        // </summary>
		public const ulong LOAD_FROM_CACHE = 1<<10;
		
		// <summary>
        // The following flags control the frequency of cached content validation
        // when neither LOAD_BYPASS_CACHE or LOAD_FROM_CACHE are set.  By default,
        // cached content is automatically validated if necessary before reuse.
        //
        // VALIDATE_ALWAYS forces validation of any cached content independent of
        // its expiration time.
        //
        // VALIDATE_NEVER disables validation of cached content, unless it arrived
        // with the "Cache: no-store" header, or arrived via HTTPS with the
        // "Cache: no-cache" header.
        //
        // VALIDATE_ONCE_PER_SESSION disables validation of expired content,
        // provided it has already been validated (at least once) since the start
        // of this session.
        //
        // NOTE TO IMPLEMENTORS:
        // These flags are intended for normal browsing, and they should therefore
        // not apply to content that must be validated before each use.  Consider,
        // for example, a HTTP response with a "Cache-control: no-cache" header.
        // According to RFC2616, this response must be validated before it can
        // be taken from a cache.  Breaking this requirement could result in
        // incorrect and potentially undesirable side-effects.
        // </summary>
		public const ulong VALIDATE_ALWAYS = 1<<11;
		
		// 
		public const ulong VALIDATE_NEVER = 1<<12;
		
		// 
		public const ulong VALIDATE_ONCE_PER_SESSION = 1<<13;
		
		// <summary>
        // When set, this flag indicates that no user-specific data should be added
        // to the request when opened. This means that things like authorization
        // tokens or cookie headers should not be added.
        // </summary>
		public const ulong LOAD_ANONYMOUS = 1<<14;
		
		// <summary>
        // When set, this flag indicates that caches of network connections,
        // particularly HTTP persistent connections, should not be used.
        // </summary>
		public const ulong LOAD_FRESH_CONNECTION = 1<<15;
	}
}
