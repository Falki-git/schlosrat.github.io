﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.impl.ActivatePartViewAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ViewActions.impl
{
  public class ActivatePartViewAction : IViewAction
  {
    private PartComponent partModel;
    private PartBehavior partView;

    public bool IsFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActivatePartViewAction(PartComponent partModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ResolveDependencies(IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Begin(IUniverseView universeView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(double universalTime, double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FinalizeDependencies(IModelViewMap modelViewMap) => throw null;
  }
}
