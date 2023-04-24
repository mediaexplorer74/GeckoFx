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
// Generated by IDLImporter from file nsIFileStreams.idl
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
    /// An input stream that allows you to read from a file.
    /// </summary>
	[ComImport()]
	[Guid("e3d56a20-c7ec-11d3-8cda-0060b0fc14a3")]
	public interface nsIFileInputStream : nsIInputStream
	{
		
		/// <summary>
        /// @param file          file to read from
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_RDONLY).
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default value (0)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (see enumerations in the class)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
	}
	
	/// <summary>nsIFileInputStreamConsts </summary>
	public class nsIFileInputStreamConsts
	{
		
		// <summary>
        // If this is set, the file will be deleted by the time the stream is
        // closed.  It may be removed before the stream is closed if it is possible
        // to delete it and still read from it.
        //
        // If OPEN_ON_READ is defined, and the file was recreated after the first
        // delete, the file will be deleted again when it is closed again.
        // </summary>
		public const long DELETE_ON_CLOSE = 1<<1;
		
		// <summary>
        // If this is set, the file will close automatically when the end of the
        // file is reached.
        // </summary>
		public const long CLOSE_ON_EOF = 1<<2;
		
		// <summary>
        // If this is set, the file will be reopened whenever we reach the start of
        // the file, either by doing a Seek(0, NS_SEEK_CUR), or by doing a relative
        // seek that happen to reach the beginning of the file. If the file is
        // already open and the seek occurs, it will happen naturally.  (The file
        // will only be reopened if it is closed for some reason.)
        // </summary>
		public const long REOPEN_ON_REWIND = 1<<3;
		
		// <summary>
        // If this is set, the file will be opened (i.e., a call to
        // PR_Open done) only when we do an actual operation on the stream,
        // or more specifically, when one of the following is called:
        // - Seek
        // - Tell
        // - SetEOF
        // - Available
        // - Read
        // - ReadLine
        //
        // DEFER_OPEN is useful if we use the stream on a background
        // thread, so that the opening and possible |stat|ing of the file
        // happens there as well.
        //
        // @note Using this flag results in the file not being opened
        // during the call to Init.  This means that any errors that might
        // happen when this flag is not set would happen during the
        // first read.  Also, the file is not locked when Init is called,
        // so it might be deleted before we try to read from it.
        // </summary>
		public const long DEFER_OPEN = 1<<4;
		
		// <summary>
        // This flag has no effect and is totally ignored on any platform except
        // Windows since this is the default behavior on POSIX systems. On Windows
        // if this flag is set then the stream is opened in a special mode that
        // allows the OS to delete the file from disk just like POSIX.
        // </summary>
		public const long SHARE_DELETE = 1<<5;
	}
	
	/// <summary>
    /// An output stream that lets you stream to a file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e6f68040-c7ec-11d3-8cda-0060b0fc14a3")]
	public interface nsIFileOutputStream : nsIOutputStream
	{
		
		/// <summary>
        /// Close the stream. Forces the output stream to flush any buffered data.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// Flush the stream.
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if unable to flush without blocking
        /// the calling thread (non-blocking mode only)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Flush();
		
		/// <summary>
        /// Write data into the stream.
        ///
        /// @param aBuf the buffer containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);
		
		/// <summary>
        /// Writes data into the stream from an input stream.
        ///
        /// @param aFromStream the stream containing the data to be written
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only). This failure
        /// means no bytes were transferred.
        /// @throws <other-error> on failure
        ///
        /// NOTE: This method is defined by this interface in order to allow the
        /// output stream to efficiently copy the data from the input stream into
        /// its internal buffer (if any). If this method was provided as an external
        /// facility, a separate char* buffer would need to be used in order to call
        /// the output stream's other Write method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);
		
		/// <summary>
        /// Low-level write method that has access to the stream's underlying buffer.
        /// The reader function may be called multiple times for segmented buffers.
        /// WriteSegments is expected to keep calling the reader until either there
        /// is nothing left to write or the reader returns an error.  WriteSegments
        /// should not call the reader with zero bytes to provide.
        ///
        /// @param aReader the "provider" of the data to be written
        /// @param aClosure opaque parameter passed to reader
        /// @param aCount the maximum number of bytes to be written
        ///
        /// @return number of bytes written (may be less than aCount)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if writing to the output stream would
        /// block the calling thread (non-blocking mode only). This failure
        /// means no bytes were transferred.
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the stream has no underlying buffer
        /// @throws <other-error> on failure
        ///
        /// NOTE: this function may be unimplemented if a stream has no underlying
        /// buffer (e.g., socket output stream).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint WriteSegments(System.IntPtr aReader, System.IntPtr aClosure, uint aCount);
		
		/// <summary>
        /// @return true if stream is non-blocking
        ///
        /// NOTE: writing to a blocking output stream will block the calling thread
        /// until all given data can be consumed by the stream.
        ///
        /// NOTE: a non-blocking output stream may implement nsIAsyncOutputStream to
        /// provide consumers with a way to wait for the stream to accept more data
        /// once its write method is unable to accept any data without blocking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsNonBlocking();
		
		/// <summary>
        /// @param file          file to write to
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_WRONLY |
        /// PR_CREATE_FILE | PR_TRUNCATE)
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default permissions (0664)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (currently none supported)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
	}
	
	/// <summary>nsIFileOutputStreamConsts </summary>
	public class nsIFileOutputStreamConsts
	{
		
		// <summary>
        // See the same constant in nsIFileInputStream. The deferred open will
        // be performed when one of the following is called:
        // - Seek
        // - Tell
        // - SetEOF
        // - Write
        // - Flush
        //
        // @note Using this flag results in the file not being opened
        // during the call to Init.  This means that any errors that might
        // happen when this flag is not set would happen during the
        // first write, and if the file is to be created, then it will not
        // appear on the disk until the first write.
        // </summary>
		public const long DEFER_OPEN = 1<<0;
	}
	
	/// <summary>
    /// An input stream that allows you to read from a slice of a file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3ce03a2f-97f7-4375-b6bb-1788a60cad3b")]
	public interface nsIPartialFileInputStream
	{
		
		/// <summary>
        /// Initialize with a file and new start/end positions. Both start and
        /// start+length must be smaller than the size of the file. Not doing so
        /// will lead to undefined behavior.
        /// You must initialize the stream, and only initialize it once, before it
        /// can be used.
        ///
        /// @param file          file to read from
        /// @param start         start offset of slice to read. Must be smaller
        /// than the size of the file.
        /// @param length        length of slice to read. Must be small enough that
        /// start+length is smaller than the size of the file.
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_RDONLY).
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default value (0)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (see enumerations in nsIFileInputStream)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, ulong start, ulong length, int ioFlags, int perm, int behaviorFlags);
	}
	
	/// <summary>
    /// A stream that allows you to read from a file or stream to a file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("82cf605a-8393-4550-83ab-43cd5578e006")]
	public interface nsIFileStream
	{
		
		/// <summary>
        /// @param file          file to read from or stream to
        /// @param ioFlags       file open flags listed in prio.h (see
        /// PR_Open documentation) or -1 to open the
        /// file in default mode (PR_RDWR).
        /// @param perm          file mode bits listed in prio.h or -1 to
        /// use the default value (0)
        /// @param behaviorFlags flags specifying various behaviors of the class
        /// (see enumerations in the class)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
	}
	
	/// <summary>nsIFileStreamConsts </summary>
	public class nsIFileStreamConsts
	{
		
		// <summary>
        // See the same constant in nsIFileInputStream. The deferred open will
        // be performed when one of the following is called:
        // - Seek
        // - Tell
        // - SetEOF
        // - Available
        // - Read
        // - Flush
        // - Write
        // - GetSize
        // - GetLastModified
        //
        // @note Using this flag results in the file not being opened
        // during the call to Init.  This means that any errors that might
        // happen when this flag is not set would happen during the
        // first read or write. The file is not locked when Init is called,
        // so it might be deleted before we try to read from it and if the
        // file is to be created, then it will not appear on the disk until
        // the first write.
        // </summary>
		public const long DEFER_OPEN = 1<<0;
	}
	
	/// <summary>
    /// An interface that allows you to get some metadata like file size and
    /// file last modified time.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("07f679e4-9601-4bd1-b510-cd3852edb881")]
	public interface nsIFileMetadata
	{
		
		/// <summary>
        /// File size in bytes;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetSizeAttribute();
		
		/// <summary>
        /// File last modified time in milliseconds from midnight (00:00:00),
        /// January 1, 1970 Greenwich Mean Time (GMT).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedAttribute();
	}
}
