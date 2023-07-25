﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.AntiSpin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class AntiSpin
  {
    public AntiSpin.Settings settings;
    public float stateVehicleSpeed;
    public float stateAngularVelocityL;
    public float stateAngularVelocityR;

    public bool sensorEngaged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakeTorqueL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float sensorBrakeTorqueR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public AntiSpin.Override asrOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AntiSpin() => throw null;

    [Serializable]
    public class Settings
    {
      public bool enabled;
      public float maxSpeed;
      public float minRotationDiffRpm;
      public float maxRotationDiffRpm;
      public float maxBrakeTorque;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    public enum Override
    {
      None,
      ForceEnabled,
      ForceDisabled,
    }
  }
}
