﻿// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CurlNoiseGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  [Serializable]
  public class CurlNoiseGenerator : ITextureGenerator
  {
    public PerlinNoiseGenerator perlin;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float noise(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color Sample(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color Sample(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CurlNoiseGenerator() => throw null;
  }
}
