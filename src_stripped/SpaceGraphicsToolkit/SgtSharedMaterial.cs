﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtSharedMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Shared Material")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtSharedMaterial")]
  [ExecuteInEditMode]
  public class SgtSharedMaterial : MonoBehaviour
  {
    [SerializeField]
    private Material material;
    [SerializeField]
    private List<Renderer> renderers;

    public Material Material
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int RendererCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRenderer(Renderer renderer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRenderer(Renderer renderer) => throw null;

    [ContextMenu("Remove Null Renderers")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNullRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtSharedMaterial() => throw null;
  }
}
