// <copyright file="FileUpload.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;

namespace Azi.Tools
{
    /// <summary>
    /// Information about file to upload
    /// </summary>
    internal class FileUpload
    {
        /// <summary>
        /// Gets or sets file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets form name
        /// </summary>
        public string FormName { get; set; }

        /// <summary>
        /// Gets or sets multipart parameters
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets Stream creator func with content to upload. Can be requested multiple time in case of retry.
        /// </summary>
        public Func<Stream> StreamOpener { get; set; }

        /// <summary>
        /// Gets or sets upload timeout
        /// </summary>
        public int Timeout { get; set; } = 30000;
    }
}