﻿// Decompiled with JetBrains decompiler
// Type: CloudinaryDotNet.Actions.SpriteParams
// Assembly: CloudinaryDotNet, Version=1.0.30.0, Culture=neutral, PublicKeyToken=c8234dc617ae7841
// MVID: 85795B22-FB3A-4216-BE8E-309002E93AB1
// Assembly location: C:\Users\Joel.TRANCON\AppData\Local\Temp\Mudimuk\dbdb731dac\lib\net40\CloudinaryDotNet.dll

using System;
using System.Collections.Generic;

namespace CloudinaryDotNet.Actions
{
  public class SpriteParams : BaseParams
  {
    public string Tag { get; set; }

    public Transformation Transformation { get; set; }

    public string NotificationUrl { get; set; }

    public bool Async { get; set; }

    public SpriteParams(string tag)
    {
      this.Tag = tag;
    }

    public override void Check()
    {
      if (string.IsNullOrEmpty(this.Tag))
        throw new ArgumentException("Tag must be set!");
    }

    public override SortedDictionary<string, object> ToParamsDictionary()
    {
      SortedDictionary<string, object> paramsDictionary = base.ToParamsDictionary();
      this.AddParam(paramsDictionary, "tag", this.Tag);
      this.AddParam(paramsDictionary, "notification_url", this.NotificationUrl);
      this.AddParam(paramsDictionary, "async", this.Async);
      if (this.Transformation != null)
        this.AddParam(paramsDictionary, "transformation", this.Transformation.Generate());
      return paramsDictionary;
    }
  }
}
