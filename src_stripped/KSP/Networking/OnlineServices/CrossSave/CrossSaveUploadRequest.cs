﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.CrossSave.CrossSaveUploadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.CrossSave
{
  public class CrossSaveUploadRequest
  {
    [JsonProperty("FileNames")]
    public string[] FileNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("Entity")]
    public Entity Entity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossSaveUploadRequest() => throw null;
  }
}
