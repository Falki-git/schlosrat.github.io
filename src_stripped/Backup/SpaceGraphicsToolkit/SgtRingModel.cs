﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("")]
  [RequireComponent(typeof (MeshRenderer))]
  [RequireComponent(typeof (MeshFilter))]
  [ExecuteInEditMode]
  public class SgtRingModel : MonoBehaviour
  {
    public SgtRing Ring;
    [NonSerialized]
    private MeshFilter cachedMeshFilter;
    [NonSerialized]
    private bool cachedMeshFilterSet;
    [NonSerialized]
    private MeshRenderer cachedMeshRenderer;
    [NonSerialized]
    private bool cachedMeshRendererSet;
    [NonSerialized]
    private Transform cachedTransform;
    [NonSerialized]
    private bool cachedTransformSet;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMesh(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaterial(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotation(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtRingModel Create(SgtRing ring) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Pool(SgtRingModel segment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MarkForDestruction(SgtRingModel segment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRingModel() => throw null;
  }
}
