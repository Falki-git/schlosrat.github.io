﻿// Decompiled with JetBrains decompiler
// Type: RTG.MeshVertexChunkCollectionDb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MeshVertexChunkCollectionDb : Singleton<MeshVertexChunkCollectionDb>
  {
    private Dictionary<Mesh, MeshVertexChunkCollection> _meshToVChunkCollection;

    public MeshVertexChunkCollection this[Mesh mesh]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMeshDirty(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasChunkCollectionForMesh(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CreateMeshVertChunkCollection(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshVertexChunkCollectionDb() => throw null;
  }
}
