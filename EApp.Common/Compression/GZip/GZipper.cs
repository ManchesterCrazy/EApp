﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace EApp.Common.Compression.GZip
{
    public class GZipper : ICompression
    {
        public byte[] Zip(object obj)
        {
            return null;
        }

        public void ZipFile(string sourceFilePath, string targetFilePath)
        {
            throw new NotImplementedException();
        }

        public object Unzip(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void UnzipFile(string sourceFilePath, string targetFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
