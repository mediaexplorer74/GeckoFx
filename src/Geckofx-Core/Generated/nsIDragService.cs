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
// Generated by IDLImporter from file nsIDragService.idl
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
    ///-*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ebd6b3a2-af16-43af-a698-3091a087dd62")]
	public interface nsIDragService
	{
		
		/// <summary>
        /// Starts a modal drag session with an array of transaferables
        ///
        /// @param  aTransferables - an array of transferables to be dragged
        /// @param  aRegion - a region containing rectangles for cursor feedback,
        /// in window coordinates.
        /// @param  aActionType - specified which of copy/move/link are allowed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvokeDragSession([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDOMNode, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aTransferables, [MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion, uint aActionType);
		
		/// <summary>
        /// Starts a modal drag session using an image. The first four arguments are
        /// the same as invokeDragSession.
        ///
        /// A custom image may be specified using the aImage argument. If this is
        /// supplied, the aImageX and aImageY arguments specify the offset within
        /// the image where the cursor would be positioned. That is, when the image
        /// is drawn, it is offset up and left the amount so that the cursor appears
        /// at that location within the image.
        ///
        /// If aImage is null, aImageX and aImageY are not used and the image is instead
        /// determined from the source node aDOMNode, and the offset calculated so that
        /// the initial location for the image appears in the same screen position as
        /// where the element is located. The node must be within a document.
        ///
        /// Currently, supported images are all DOM nodes. If this is an HTML <image> or
        /// <canvas>, the drag image is taken from the image data. If the element is in
        /// a document, it will be rendered at its displayed size, othewise, it will be
        /// rendered at its real size. For other types of elements, the element is
        /// rendered into an offscreen buffer in the same manner as it is currently
        /// displayed. The document selection is hidden while drawing.
        ///
        /// The aDragEvent must be supplied as the current screen coordinates of the
        /// event are needed to calculate the image location.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvokeDragSessionWithImage([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDOMNode, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aTransferableArray, [MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion, uint aActionType, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aImage, int aImageX, int aImageY, [MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aDragEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer aDataTransfer);
		
		/// <summary>
        /// Start a modal drag session using the selection as the drag image.
        /// The aDragEvent must be supplied as the current screen coordinates of the
        /// event are needed to calculate the image location.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvokeDragSessionWithSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aTransferableArray, uint aActionType, [MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aDragEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer aDataTransfer);
		
		/// <summary>
        /// Returns the current Drag Session
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDragSession GetCurrentSession();
		
		/// <summary>
        /// Tells the Drag Service to start a drag session. This is called when
        /// an external drag occurs
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartDragSession();
		
		/// <summary>
        /// Tells the Drag Service to end a drag session. This is called when
        /// an external drag occurs
        ///
        /// If aDoneDrag is true, the drag has finished, otherwise the drag has
        /// just left the window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndDragSession([MarshalAs(UnmanagedType.U1)] bool aDoneDrag);
		
		/// <summary>
        /// Fire a drag event at the source of the drag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FireDragEventAtSource(System.IntPtr aEventMessage);
		
		/// <summary>
        /// Increase/decrease dragging suppress level by one.
        /// If level is greater than one, dragging is disabled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suppress();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unsuppress();
		
		/// <summary>
        /// aX and aY are in LayoutDevice pixels.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DragMoved(int aX, int aY);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MaybeAddChildProcess(System.IntPtr aChild);
	}
	
	/// <summary>nsIDragServiceConsts </summary>
	public class nsIDragServiceConsts
	{
		
		// <summary>
        //-*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        //
        // This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const long DRAGDROP_ACTION_NONE = 0;
		
		// 
		public const long DRAGDROP_ACTION_COPY = 1;
		
		// 
		public const long DRAGDROP_ACTION_MOVE = 2;
		
		// 
		public const long DRAGDROP_ACTION_LINK = 4;
		
		// 
		public const long DRAGDROP_ACTION_UNINITIALIZED = 64;
	}
}
