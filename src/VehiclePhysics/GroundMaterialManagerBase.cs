﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterialManagerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public abstract class GroundMaterialManagerBase : MonoBehaviour
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract GroundMaterial GetGroundMaterial(
      VehicleBase vehicle,
      GroundMaterialHit groundHit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void GetGroundMaterialCached(
      VehicleBase vehicle,
      GroundMaterialHit groundHit,
      ref GroundMaterialHit cachedGroundHit,
      ref GroundMaterial groundMaterial)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected GroundMaterialManagerBase() => throw null;
  }
}
