﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundMaterialManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Material Manager")]
  public class VPGroundMaterialManager : GroundMaterialManagerBase
  {
    public GroundMaterial[] groundMaterials;
    public GroundMaterial fallback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override GroundMaterial GetGroundMaterial(
      VehicleBase vehicle,
      GroundMaterialHit groundHit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundMaterialManager() => throw null;
  }
}
