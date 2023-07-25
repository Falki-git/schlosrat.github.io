﻿// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXPartContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public struct FXPartContextData
  {
    public bool IsPressurized;
    public string FuelType;
    public float FuelQuantity;
    public Vector3 AttachNodePosition;
    public float AttachNodeSize;
    public float ExplosionPotential;
    public float PartTemperature;
    public float ExposedSurfaceArea;
    public Vector3 PartVelocity;
    public float PartSurfaceDistance;
    public Vector3 PartSurfaceVector;
    public Vector3 PartSurfaceVectorReflected;
    public float RaycastDistance;
    public float DeviationFromVertical;
    public float PartRelativeVelocity;
  }
}
