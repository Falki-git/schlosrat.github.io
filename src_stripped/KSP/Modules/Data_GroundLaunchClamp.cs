﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_GroundLaunchClamp
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
  public sealed class Data_GroundLaunchClamp : ModuleData, IMassModifier
  {
    [KSPDefinition]
    public string ReleasePlaybackMultiplierName;
    [KSPDefinition]
    public string AnimatorPitchAngleName;
    [KSPDefinition]
    public float InitialHeight;
    [KSPDefinition]
    public float MaxHeight;
    [KSPDefinition]
    public Vector3 RotationAxis;
    [KSPDefinition]
    public float ArmLength;
    [KSPDefinition]
    public float AngleMultiplier;
    [KSPState]
    public float ScaleFactor;
    [KSPState]
    public float Height;
    [KSPState]
    public float RepeaterMass;
    [HideInInspector]
    [KSPState]
    public bool isReleased;
    [KSPDefinition]
    public float DefaultMassScaleModifier;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MassModifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_GroundLaunchClamp() => throw null;
  }
}
