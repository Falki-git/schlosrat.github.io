﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [Serializable]
  public class PersistentVegetationCell
  {
    public int xIndex;
    public int yIndex;
    public List<PersistentVegetationInfo> PersistentVegetationInfoList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItemInstance(
      string vegetationItemID,
      Vector3 position,
      Vector3 scale,
      Quaternion rotation,
      byte vegetationSourceID,
      float distanceFalloff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstance(
      string vegetationItemID,
      Vector3 position,
      float minimumDistance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItemInstanceEx(
      string vegetationItemID,
      Vector3 position,
      Vector3 scale,
      Quaternion rotation,
      byte vegetationSourceID,
      float minimumDistance,
      float distanceFalloff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateClosestItemDistance(
      Vector3 position,
      List<PersistentVegetationItem> instanceList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCell() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationInfo GetPersistentVegetationInfo(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstances(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstances(string vegetationItemID, int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationCell() => throw null;
  }
}
