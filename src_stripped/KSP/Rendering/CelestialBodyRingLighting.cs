﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyRingLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [ExecuteInEditMode]
  public class CelestialBodyRingLighting
  {
    private CelestialBodyRingGroup _cachedGroup;
    [NonSerialized]
    private Texture2D generatedTexture;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(CelestialBodyRingGroup group) => throw null;

    [ContextMenu("Update Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WritePixel(float u, int x) => throw null;

    [ContextMenu("Apply Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTexture() => throw null;

    [ContextMenu("Remove Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingLighting() => throw null;
  }
}
