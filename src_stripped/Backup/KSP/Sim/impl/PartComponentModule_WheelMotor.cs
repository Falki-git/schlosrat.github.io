﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_WheelMotor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_WheelMotor : PartComponentModule_WheelSubmodule
  {
    protected Data_WheelMotor dataWheelMotor;
    protected FlowRequestResolutionState _returnedRequestResolutionState;
    protected bool _requestOutstanding;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckMotorState(
      double fixedDeltaTime,
      float driveInput,
      out double rOutput,
      float torqueScalar)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_WheelMotor() => throw null;
  }
}
