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
// Generated by IDLImporter from file nsITextInputProcessorCallback.idl
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
    /// nsITextInputProcessorNotification stores the type of notification to IME and
    /// its detail.  See each explanation of attribute for the detail.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c0ce1add-82bb-45ab-b99a-42cfba7fd5d7")]
	public interface nsITextInputProcessorNotification
	{
		
		/// <summary>
        /// type attribute represents what's notified or requested.  Value must be
        /// one of following values:
        ///
        /// "request-to-commit"  (required to be handled)
        /// This is requested when Gecko believes that active composition should be
        /// committed.  nsITextInputProcessorCallback::onNotify() has to handle this
        /// notification.
        ///
        /// "request-to-cancel" (required to be handled)
        /// This is requested when Gecko believes that active composition should be
        /// canceled.  I.e., composition should be committed with empty string.
        /// nsITextInputProcessorCallback::onNotify() has to handle this
        /// notification.
        ///
        /// "notify-end-input-transaction" (optional)
        /// This is notified when the callback is detached from
        /// nsITextInputProcessor.  I.e., the TextInputProcessor lost the rights
        /// to input text and needs to call .beginInputTransaction() before next
        /// input.
        ///
        /// "notify-focus" (optional)
        /// This is notified when an editable editor gets focus and Gecko starts
        /// to observe changes in the content. E.g., selection changes.
        /// IME shouldn't change DOM tree, focus nor something when this is notified.
        ///
        /// "notify-blur" (optional)
        /// This is notified when an editable editor loses focus and Gecko stops
        /// observing the changes in the content.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);
	}
	
	/// <summary>
    /// nsITextInputProcessorCallback is a callback interface for JS to implement
    /// IME.  IME implemented by JS can implement onNotify() function and must send
    /// it to nsITextInputProcessor at initializing.  Then, onNotify() will be
    /// called with nsITextInputProcessorNotification instance.
    /// The reason why onNotify() uses string simply is that if we will support
    /// other notifications such as text changes and selection changes, we need to
    /// notify IME of some other information.  Then, only changing
    /// nsITextInputProcessorNotification interface is better for compatibility.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("23d5f242-adb5-46f1-8766-90d1bf0383df")]
	public interface nsITextInputProcessorCallback
	{
		
		/// <summary>
        /// When Gecko notifies IME of something or requests something to IME,
        /// this is called.
        ///
        /// @param aTextInputProcessor Reference to the nsITextInputProcessor service
        /// which is the original receiver of the request
        /// or notification.
        /// @param aNotification       Stores type of notifications and additional
        /// information.
        /// @return                    Return true if it succeeded or does nothing.
        /// Otherwise, return false.
        ///
        /// Example #1 The simplest implementation of nsITextInputProcessorCallback is:
        ///
        /// function simpleCallback(aTIP, aNotification)
        /// {
        /// try {
        /// switch (aNotification.type) {
        /// case "request-to-commit":
        /// aTIP.commitComposition();
        /// break;
        /// case "request-to-cancel":
        /// aTIP.cancelComposition();
        /// break;
        /// }
        /// } catch (e) {
        /// return false;
        /// }
        /// return true;
        /// }
        ///
        /// var TIP = Components.classes["@mozilla.org/text-input-processor;1"].
        /// createInstance(Components.interfaces.nsITextInputProcessor);
        /// if (!TIP.init(window, simpleCallback)) {
        /// return;
        /// }
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnNotify([MarshalAs(UnmanagedType.Interface)] nsITextInputProcessor aTextInputProcessor, [MarshalAs(UnmanagedType.Interface)] nsITextInputProcessorNotification aNotification);
	}
}
