﻿// Decompiled with JetBrains decompiler
// Type: CloudinaryDotNet.Actions.GetFoldersResult
// Assembly: CloudinaryDotNet, Version=1.0.30.0, Culture=neutral, PublicKeyToken=c8234dc617ae7841
// MVID: 85795B22-FB3A-4216-BE8E-309002E93AB1
// Assembly location: C:\Users\Joel.TRANCON\AppData\Local\Temp\Mudimuk\dbdb731dac\lib\net40\CloudinaryDotNet.dll

using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CloudinaryDotNet.Actions
{
    [DataContract]
    public class GetFoldersResult : BaseResult
    {
        [DataMember(Name = "folders")]
        public List<Folder> Folders { get; set; }

        internal static Task<GetFoldersResult> Parse(HttpResponseMessage response)
        {
            return Parse<GetFoldersResult>(response);
        }
    }
}