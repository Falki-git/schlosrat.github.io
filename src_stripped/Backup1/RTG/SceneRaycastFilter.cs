﻿// Decompiled with JetBrains decompiler
// Type: RTG.SceneRaycastFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SceneRaycastFilter
  {
    private List<GameObjectType> _allowedObjectTypes;
    private List<GameObject> _ignoreObjects;
    private int _layerMask;

    public List<GameObjectType> AllowedObjectTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<GameObject> IgnoreObjects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int LayerMask
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FilterHits(List<GameObjectRayHit> hits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneRaycastFilter() => throw null;
  }
}
