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
// Generated by IDLImporter from file nsISHEntry.idl
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
    /// The interface to nsISHentry. Each document or subframe in
    /// Session History will have a nsISHEntry associated with it which will
    /// hold all information required to recreate the document from history
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3a5e5fa0-5364-4fbb-a87a-3f12a6b51903")]
	public interface nsISHEntry
	{
		
		/// <summary>
        /// A readonly property that returns the URI
        /// of the current entry. The object returned is
        /// of type nsIURI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// A readonly property that returns the original URI of the current entry.
        /// If an entry is the result of a redirect this attribute holds original
        /// URI. The object returned is of type nsIURI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetOriginalURIAttribute();
		
		/// <summary>
        /// A readonly property that returns the original URI of the current entry.
        /// If an entry is the result of a redirect this attribute holds original
        /// URI. The object returned is of type nsIURI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);
		
		/// <summary>
        /// This flag remembers whether channel has LOAD_REPLACE set.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLoadReplaceAttribute();
		
		/// <summary>
        /// This flag remembers whether channel has LOAD_REPLACE set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadReplaceAttribute([MarshalAs(UnmanagedType.U1)] bool aLoadReplace);
		
		/// <summary>
        /// A readonly property that returns the title
        /// of the current entry.  The object returned
        /// is a encoded string
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitleAttribute();
		
		/// <summary>
        /// A readonly property that returns a boolean
        /// flag which indicates if the entry was created as a
        /// result of a subframe navigation. This flag will be
        /// 'false' when a frameset page is visited for
        /// the first time. This flag will be 'true' for all
        /// history entries created as a result of a subframe
        /// navigation.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSubFrameAttribute();
		
		/// <summary>
        ///URI for the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        ///Referrer URI </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferrerURIAttribute();
		
		/// <summary>
        ///Referrer URI </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI);
		
		/// <summary>
        ///Referrer policy, holding one of the values (REFERRER_POLICY_*)
        /// defined in nsIHttpChannel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetReferrerPolicyAttribute();
		
		/// <summary>
        ///Referrer policy, holding one of the values (REFERRER_POLICY_*)
        /// defined in nsIHttpChannel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerPolicyAttribute(uint aReferrerPolicy);
		
		/// <summary>
        ///Content viewer, for fast restoration of presentation </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentViewer GetContentViewerAttribute();
		
		/// <summary>
        ///Content viewer, for fast restoration of presentation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentViewerAttribute([MarshalAs(UnmanagedType.Interface)] nsIContentViewer aContentViewer);
		
		/// <summary>
        ///Whether the content viewer is marked "sticky" </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStickyAttribute();
		
		/// <summary>
        ///Whether the content viewer is marked "sticky" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStickyAttribute([MarshalAs(UnmanagedType.U1)] bool aSticky);
		
		/// <summary>
        ///Saved state of the global window object </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetWindowStateAttribute();
		
		/// <summary>
        ///Saved state of the global window object </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowStateAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aWindowState);
		
		/// <summary>
        /// Saved position and dimensions of the content viewer; we must adjust the
        /// root view's widget accordingly if this has changed when the presentation
        /// is restored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetViewerBounds([MarshalAs(UnmanagedType.Interface)] nsIntRect bounds);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetViewerBounds([MarshalAs(UnmanagedType.Interface)] nsIntRect bounds);
		
		/// <summary>
        ///Append a child shell to the end of our list. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChildShell([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem shell);
		
		/// <summary>
        /// Get the child shell at |index|; returns null if |index| is out of bounds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem ChildShellAt(int index);
		
		/// <summary>
        /// Clear the child shell list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearChildShells();
		
		/// <summary>
        ///Saved refresh URI list for the content viewer </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetRefreshURIListAttribute();
		
		/// <summary>
        ///Saved refresh URI list for the content viewer </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRefreshURIListAttribute([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aRefreshURIList);
		
		/// <summary>
        /// Ensure that the cached presentation members are self-consistent.
        /// If either |contentViewer| or |windowState| are null, then all of the
        /// following members are cleared/reset:
        /// contentViewer, sticky, windowState, viewerBounds, childShells,
        /// refreshURIList.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SyncPresentationState();
		
		/// <summary>
        ///Title for the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);
		
		/// <summary>
        ///Post Data for the document </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetPostDataAttribute();
		
		/// <summary>
        ///Post Data for the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPostDataAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData);
		
		/// <summary>
        ///LayoutHistoryState for scroll position and form values </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLayoutHistoryStateAttribute();
		
		/// <summary>
        ///LayoutHistoryState for scroll position and form values </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLayoutHistoryStateAttribute(System.IntPtr aLayoutHistoryState);
		
		/// <summary>
        ///parent of this entry </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry GetParentAttribute();
		
		/// <summary>
        ///parent of this entry </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aParent);
		
		/// <summary>
        /// The loadType for this entry. This is typically loadHistory except
        /// when reload is pressed, it has the appropriate reload flag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLoadTypeAttribute();
		
		/// <summary>
        /// The loadType for this entry. This is typically loadHistory except
        /// when reload is pressed, it has the appropriate reload flag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(uint aLoadType);
		
		/// <summary>
        /// An ID to help identify this entry from others during
        /// subframe navigation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIDAttribute();
		
		/// <summary>
        /// An ID to help identify this entry from others during
        /// subframe navigation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIDAttribute(uint aID);
		
		/// <summary>
        ///attribute to set and get the cache key for the entry </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCacheKeyAttribute();
		
		/// <summary>
        ///attribute to set and get the cache key for the entry </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheKeyAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey);
		
		/// <summary>
        ///attribute to indicate whether layoutHistoryState should be saved </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSaveLayoutStateFlagAttribute();
		
		/// <summary>
        ///attribute to indicate whether layoutHistoryState should be saved </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSaveLayoutStateFlagAttribute([MarshalAs(UnmanagedType.U1)] bool aSaveLayoutStateFlag);
		
		/// <summary>
        ///attribute to indicate whether the page is already expired in cache </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetExpirationStatusAttribute();
		
		/// <summary>
        ///attribute to indicate whether the page is already expired in cache </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetExpirationStatusAttribute([MarshalAs(UnmanagedType.U1)] bool aExpirationStatus);
		
		/// <summary>
        /// attribute to indicate the content-type of the document that this
        /// is a session history entry for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);
		
		/// <summary>
        /// attribute to indicate the content-type of the document that this
        /// is a session history entry for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);
		
		/// <summary>
        /// If we created this SHEntry via history.pushState or modified it via
        /// history.replaceState, and if we changed the SHEntry's URI via the
        /// push/replaceState call, and if the SHEntry's new URI differs from its
        /// old URI by more than just the hash, then we set this field to true.
        ///
        /// Additionally, if this SHEntry was created by calling pushState from a
        /// SHEntry whose URI was modified, this SHEntry's URIWasModified field is
        /// true.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetURIWasModifiedAttribute();
		
		/// <summary>
        /// If we created this SHEntry via history.pushState or modified it via
        /// history.replaceState, and if we changed the SHEntry's URI via the
        /// push/replaceState call, and if the SHEntry's new URI differs from its
        /// old URI by more than just the hash, then we set this field to true.
        ///
        /// Additionally, if this SHEntry was created by calling pushState from a
        /// SHEntry whose URI was modified, this SHEntry's URIWasModified field is
        /// true.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURIWasModifiedAttribute([MarshalAs(UnmanagedType.U1)] bool aURIWasModified);
		
		/// <summary>
        ///Set/Get scrollers' positon in anchored pages </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollPosition(int x, int y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrollPosition(ref int x, ref int y);
		
		/// <summary>
        ///Additional ways to create an entry </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create([MarshalAs(UnmanagedType.Interface)] nsIURI URI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.Interface)] nsIInputStream inputStream, System.IntPtr layoutHistoryState, [MarshalAs(UnmanagedType.Interface)] nsISupports cacheKey, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase contentType, [MarshalAs(UnmanagedType.Interface)] nsISupports owner, ulong docshellID, [MarshalAs(UnmanagedType.U1)] bool dynamicCreation);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry Clone();
		
		/// <summary>
        ///Attribute that indicates if this entry is for a subframe navigation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsSubFrame([MarshalAs(UnmanagedType.U1)] bool aFlag);
		
		/// <summary>
        ///Return any content viewer present in or below this node in the
        ///        nsSHEntry tree.  This will differ from contentViewer in the case
        ///        where a child nsSHEntry has the content viewer for this tree. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentViewer GetAnyContentViewer([MarshalAs(UnmanagedType.Interface)] ref nsISHEntry ownerEntry);
		
		/// <summary>
        /// Get the owner, if any, that was associated with the channel
        /// that the document that was loaded to create this history entry
        /// came from.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetOwnerAttribute();
		
		/// <summary>
        /// Get the owner, if any, that was associated with the channel
        /// that the document that was loaded to create this history entry
        /// came from.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);
		
		/// <summary>
        /// Get/set data associated with this history state via a pushState() call,
        /// serialized using structured clone.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStructuredCloneContainer GetStateDataAttribute();
		
		/// <summary>
        /// Get/set data associated with this history state via a pushState() call,
        /// serialized using structured clone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStateDataAttribute([MarshalAs(UnmanagedType.Interface)] nsIStructuredCloneContainer aStateData);
		
		/// <summary>
        /// Gets the owning pointer to the editor data assosicated with
        /// this shistory entry. This forgets its pointer, so free it when
        /// you're done.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr ForgetEditorData();
		
		/// <summary>
        /// Sets the owning pointer to the editor data assosicated with
        /// this shistory entry. Unless forgetEditorData() is called, this
        /// shentry will destroy the editor data when it's destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEditorData(System.IntPtr aData);
		
		/// <summary>
        ///Returns true if this shistory entry is storing a detached editor. </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasDetachedEditor();
		
		/// <summary>
        /// Returns true if the related docshell was added because of
        /// dynamic addition of an iframe/frame.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDynamicallyAdded();
		
		/// <summary>
        /// Returns true if any of the child entries returns true
        /// when isDynamicallyAdded is called on it.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasDynamicallyAddedChild();
		
		/// <summary>
        /// The history ID of the docshell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDocshellIDAttribute();
		
		/// <summary>
        /// The history ID of the docshell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocshellIDAttribute(ulong aDocshellID);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIBFCacheEntry GetBFCacheEntryAttribute();
		
		/// <summary>
        /// Does this SHEntry point to the given BFCache entry?  If so, evicting
        /// the BFCache entry will evict the SHEntry, since the two entries
        /// correspond to the same document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasBFCacheEntry([MarshalAs(UnmanagedType.Interface)] nsIBFCacheEntry aEntry);
		
		/// <summary>
        /// Adopt aEntry's BFCacheEntry, so now both this and aEntry point to
        /// aEntry's BFCacheEntry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AdoptBFCacheEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry);
		
		/// <summary>
        /// Create a new BFCache entry and drop our reference to our old one.  This
        /// call unlinks this SHEntry from any other SHEntries for its document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AbandonBFCacheEntry();
		
		/// <summary>
        /// Does this SHEntry correspond to the same document as aEntry?  This is
        /// true iff the two SHEntries have the same BFCacheEntry.  So in
        /// particular, sharesDocumentWith(aEntry) is guaranteed to return true if
        /// it's preceeded by a call to adoptBFCacheEntry(aEntry).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SharesDocumentWith([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry);
		
		/// <summary>
        /// True if this SHEntry corresponds to a document created by a srcdoc iframe.
        /// Set when a value is assigned to  srcdocData.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSrcdocEntryAttribute();
		
		/// <summary>
        /// Contents of the srcdoc attribute in a srcdoc iframe to be loaded instead
        /// of the URI.  Similar to a Data URI, this information is needed to
        /// recreate the document at a later stage.
        /// Setting this sets isSrcdocEntry to true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);
		
		/// <summary>
        /// Contents of the srcdoc attribute in a srcdoc iframe to be loaded instead
        /// of the URI.  Similar to a Data URI, this information is needed to
        /// recreate the document at a later stage.
        /// Setting this sets isSrcdocEntry to true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);
		
		/// <summary>
        /// When isSrcdocEntry is true, this contains the baseURI of the srcdoc
        /// document for use in situations where it cannot otherwise be determined,
        /// for example with view-source.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBaseURIAttribute();
		
		/// <summary>
        /// When isSrcdocEntry is true, this contains the baseURI of the srcdoc
        /// document for use in situations where it cannot otherwise be determined,
        /// for example with view-source.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
	}
	
	/// <summary>nsISHEntryInternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bb66ac35-253b-471f-a317-3ece940f04c5")]
	public interface nsISHEntryInternal
	{
		
		/// <summary>Member RemoveFromBFCacheAsync </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFromBFCacheAsync();
		
		/// <summary>Member RemoveFromBFCacheSync </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFromBFCacheSync();
		
		/// <summary>
        /// A number that is assigned by the sHistory when the entry is activated
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLastTouchedAttribute();
		
		/// <summary>
        /// A number that is assigned by the sHistory when the entry is activated
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastTouchedAttribute(uint aLastTouched);
		
		/// <summary>
        /// Some state, particularly that related to the back/forward cache, is
        /// shared between SHEntries which correspond to the same document.  This
        /// method gets a pointer to that shared state.
        ///
        /// This shared state is the SHEntry's BFCacheEntry.  So
        /// hasBFCacheEntry(getSharedState()) is guaranteed to return true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSharedState();
	}
}