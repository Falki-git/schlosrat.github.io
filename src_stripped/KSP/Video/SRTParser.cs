﻿// Decompiled with JetBrains decompiler
// Type: KSP.Video.SRTParser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Video
{
  public class SRTParser
  {
    private List<SubtitleBlock> _subtitles;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SRTParser(string textAssetResourcePath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SRTParser(TextAsset textAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SubtitleBlock> Load(TextAsset textAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubtitleBlock GetForTime(float time) => throw null;

    private enum eReadState
    {
      Index,
      Time,
      Text,
    }
  }
}
