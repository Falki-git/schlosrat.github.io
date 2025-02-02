﻿// Decompiled with JetBrains decompiler
// Type: RTG.MeshTree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MeshTree
  {
    private RTMesh _mesh;
    private SphereTree<MeshTriangle> _tree;
    private List<SphereTreeNode<MeshTriangle>> _nodeBuffer;
    private List<SphereTreeNodeRayHit<MeshTriangle>> _nodeHitBuffer;
    private HashSet<int> _vertexIndexSet;
    private bool _isBuilt;

    public bool IsBuilt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshTree(RTMesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Build() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapVerts(OBB obb, MeshTransform meshTransform, List<Vector3> verts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshRayHit RaycastClosest(Ray ray, Matrix4x4 meshTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugDraw() => throw null;
  }
}
