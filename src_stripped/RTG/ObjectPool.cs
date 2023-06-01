﻿// Decompiled with JetBrains decompiler
// Type: RTG.ObjectPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class ObjectPool
  {
    private GameObject _sourceObject;
    private ObjectPool.GrowMode _growMode;
    private int _growAmount;
    private List<GameObject> _pooledObjects;
    private Transform _pooledParent;

    public ObjectPool.GrowMode PoolGrowMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int GrowAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectPool(GameObject sourceObject, int numPooled, ObjectPool.GrowMode growMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPooledObjectsParent(Transform parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetPooledObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAsUnused(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAllAsUnused() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Grow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject CreatePooledObject() => throw null;

    public enum GrowMode
    {
      None,
      Increment,
      ByAmount,
    }
  }
}
