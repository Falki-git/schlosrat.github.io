﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_WheelMotor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
