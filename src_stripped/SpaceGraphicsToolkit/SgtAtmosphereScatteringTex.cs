﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereScatteringTex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [RequireComponent(typeof (SgtAtmosphere))]
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtAtmosphereScatteringTex")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Atmosphere ScatteringTex")]
  public class SgtAtmosphereScatteringTex : MonoBehaviour
  {
    public int Width;
    public TextureFormat Format;
    public SgtEase.Type SunsetEase;
    [Range(0.0f, 1f)]
    public float SunsetStart;
    [Range(0.0f, 1f)]
    public float SunsetEnd;
    public float SunsetSharpnessR;
    public float SunsetSharpnessG;
    public float SunsetSharpnessB;
    [NonSerialized]
    private Texture2D generatedTexture;
    [NonSerialized]
    private SgtAtmosphere cachedAtmosphere;
    [NonSerialized]
    private bool cachedAtmosphereSet;

    public Texture2D GeneratedTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ContextMenu("Update Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [ContextMenu("Apply Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTexture() => throw null;

    [ContextMenu("Remove Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WritePixel(float u, int x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtAtmosphereScatteringTex() => throw null;
  }
}
