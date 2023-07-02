﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ActiveRadiator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class Data_ActiveRadiator : ModuleData
  {
    [KSPDefinition]
    [Tooltip("This is the axis direction we should use to calculate the area of the radiator for procedural radiators.\nWill not be used if the radiator is NOT procedural.")]
    public Data_LiftingSurface.TransformDir RadiatorDirection;
    [Tooltip("This is the amount of flux removed from the radiator calculated from the area of the radiator for procedural radiators.\nWill not be used if the radiator is NOT procedural.\nThis will be used to calculate the fluxRemoved value.")]
    [KSPDefinition]
    public float ProceduralRadiatorFluxPerAreaUnit;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ActiveRadiator() => throw null;
  }
}
