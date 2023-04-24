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
// Generated by IDLImporter from file mozIStorageRow.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    /// vim: sw=2 ts=2 sts=2 expandtab
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("62d1b6bd-cbfe-4f9b-aee1-0ead4af4e6dc")]
	public interface mozIStorageRow : mozIStorageValueArray
	{
		
		/// <summary>
        /// numEntries
        ///
        /// number of entries in the array (each corresponding to a column
        /// in the database row)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetNumEntriesAttribute();
		
		/// <summary>
        /// Returns the type of the value at the given column index;
        /// one of VALUE_TYPE_NULL, VALUE_TYPE_INTEGER, VALUE_TYPE_FLOAT,
        /// VALUE_TYPE_TEXT, VALUE_TYPE_BLOB.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetTypeOfIndex(uint aIndex);
		
		/// <summary>
        /// Obtain a value for the given entry (column) index.
        /// Due to SQLite's type conversion rules, any of these are valid
        /// for any column regardless of the column's data type.  However,
        /// if the specific type matters, getTypeOfIndex should be used
        /// first to identify the column type, and then the appropriate
        /// get method should be called.
        ///
        /// If you ask for a string value for a NULL column, you will get an empty
        /// string with IsVoid set to distinguish it from an explicitly set empty
        /// string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetInt32(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetInt64(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetDouble(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetString(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// data will be NULL if dataSize = 0
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBlob(uint aIndex, ref uint aDataSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref byte[] aData);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBlobAsString(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBlobAsUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsNull(uint aIndex);
		
		/// <summary>
        /// Returns a shared string pointer
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetSharedUTF8String(uint aIndex, ref uint aLength);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetSharedString(uint aIndex, ref uint aLength);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetSharedBlob(uint aIndex, ref uint aLength);
		
		/// <summary>
        /// Obtains the result of a given column specified by aIndex.
        ///
        /// @param aIndex
        /// Zero-based index of the result to get from the tuple.
        /// @returns the result of the specified column.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetResultByIndex(uint aIndex);
		
		/// <summary>
        /// Obtains the result of a given column specified by aName.
        ///
        /// @param aName
        /// Name of the result to get from the tuple.
        /// @returns the result of the specified column.
        /// @note The name of a result column is the value of the "AS" clause for that
        /// column.  If there is no AS clause then the name of the column is
        /// unspecified and may change from one release to the next.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetResultByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
	}
}
