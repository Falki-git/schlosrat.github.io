﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ChaseFrameRotationProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class ChaseFrameRotationProvider : IDynamicFrameRotationProvider
  {
    private IUniverseObserver _observer;
    private Rotation _prevObserverRotation;
    private float _rotationLerpSpeed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChaseFrameRotationProvider(IUniverseObserver observer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation GetRotation(double universeDeltaTime) => throw null;
  }
}
