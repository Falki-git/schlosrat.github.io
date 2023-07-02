﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereLightingTex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [RequireComponent(typeof (SgtAtmosphere))]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtAtmosphereLightingTex")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Atmosphere LightingTex")]
  public class SgtAtmosphereLightingTex : MonoBehaviour
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

    [ContextMenu("Update Textures")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTextures() => throw null;

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
    public SgtAtmosphereLightingTex() => throw null;
  }
}
