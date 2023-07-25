﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelMotorSteering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
  public sealed class Data_WheelMotorSteering : ModuleData
  {
    [Tooltip("This is the steering torque")]
    [KSPDefinition]
    public float SteeringTorque;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/SteeringEnabled")]
    public ModuleProperty<bool> SteeringEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/SteeringDirection")]
    public ModuleProperty<bool> SteeringInverted;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSteeringEnabledString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSteeringInvertedString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelMotorSteering() => throw null;
  }
}
