﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_SolarPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_SolarPanel : PartComponentModule_Deployable
  {
    private bool _requestActive;
    protected Data_SolarPanel dataSolarPanel;
    protected Data_Deployable dataDeployable;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateVesselSolarLOS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CalculateOcclusionPerStar(CelestialBodyComponent sunBody, out string blocker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_SolarPanel() => throw null;
  }
}
