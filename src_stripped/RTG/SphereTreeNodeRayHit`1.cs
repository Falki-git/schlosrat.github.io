﻿// Decompiled with JetBrains decompiler
// Type: RTG.SphereTreeNodeRayHit`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SphereTreeNodeRayHit<T>
  {
    private SphereTreeNode<T> _hitNode;
    private Vector3 _hitPoint;
    private float _hitEnter;

    public SphereTreeNode<T> HitNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 HitPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float HitEnter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNodeRayHit(Ray ray, SphereTreeNode<T> hitNode, float hitEnter) => throw null;
  }
}
