﻿/*  Copyright (C) 2008-2018 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Alphaleonis.Win32.Filesystem;
using PortableDeviceApiLib;

namespace Alphaleonis.Win32.Device
{
   public static partial class Local
   {
      /// <summary>[AlphaFS] Returns an enumerable collection of file- and directory names from the root of the device.</summary>
      /// <returns>An enumerable collection of file-system entries from the root of the device.</returns>
      /// <param name="portableDeviceInfo">The <see cref="T:PortableDeviceInfo"/> instance of the Portable Device.</param>
      [SecurityCritical]
      public static IEnumerable<PortableDeviceFileSystemInfo> EnumerateFileSystemEntries(PortableDeviceInfo portableDeviceInfo)
      {
         return PortableDeviceInfo.EnumerateFileSystemEntryInfoCore(portableDeviceInfo, null, null, false, null);
      }


      /// <summary>[AlphaFS] Returns an enumerable collection of file- and directory names from the root of the device.</summary>
      /// <returns>An enumerable collection of file-system entries from the root of the device.</returns>
      /// <param name="portableDeviceInfo">The <see cref="T:PortableDeviceInfo"/> instance of the Portable Device.</param>
      /// <param name="recurse"></param>
      [SecurityCritical]
      public static IEnumerable<PortableDeviceFileSystemInfo> EnumerateFileSystemEntries(PortableDeviceInfo portableDeviceInfo, bool recurse)
      {
         return PortableDeviceInfo.EnumerateFileSystemEntryInfoCore(portableDeviceInfo, null, null, recurse, null);
      }


      /// <summary>[AlphaFS] Returns an enumerable collection of file- and directory instances in a specified path.</summary>
      /// <returns>An enumerable collection of file-system entries in the directory specified by <paramref name="objectId"/>.</returns>
      /// <param name="portableDeviceInfo">The <see cref="T:PortableDeviceInfo"/> instance of the Portable Device.</param>
      /// <param name="objectId">The ID of the directory to search.</param>
      /// <param name="recurse"></param>
      [SecurityCritical]
      public static IEnumerable<PortableDeviceFileSystemInfo> EnumerateFileSystemEntries(PortableDeviceInfo portableDeviceInfo, string objectId, bool recurse)
      {
         return PortableDeviceInfo.EnumerateFileSystemEntryInfoCore(portableDeviceInfo, null, objectId, recurse, null);
      }
   }
}
