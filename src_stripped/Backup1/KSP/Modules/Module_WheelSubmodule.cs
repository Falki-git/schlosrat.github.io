﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelSubmodule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  public abstract class Module_WheelSubmodule : PartBehaviourModule
  {
    protected Module_WheelBase WheelBase;
    protected Data_WheelBase DataWheelBase;
    internal KSPWheelController wheel;
    protected bool BaseSetup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetWheelBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnWheelInit(KSPWheelController w) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnSubsystemsModified(WheelSubsystems s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Module_WheelSubmodule() => throw null;
  }
}
