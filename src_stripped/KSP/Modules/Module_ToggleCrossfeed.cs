﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ToggleCrossfeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ToggleCrossfeed : PartBehaviourModule
  {
    [SerializeField]
    protected Data_ToggleCrossFeed dataToggleCrossfeed;
    private Dictionary<ModuleProperty<bool>, Action<bool>> _valueChangeHandlers;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleCrossFeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableCrossFeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableCrossFeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ToggleCrossfeed() => throw null;
  }
}
