﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ChaseFrameRotationProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
