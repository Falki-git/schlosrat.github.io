﻿// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.MipMapTexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace PA.ParticleField.Samples
{
  public class MipMapTexture : MonoBehaviour
  {
    private const float MIN_BOKEH = -7f;
    private const float MAX_BOKEH = 2f;
    public Texture2D[] textures;
    public Material bokehMaterial;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBokeh(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D GenerateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MipMapTexture() => throw null;
  }
}
