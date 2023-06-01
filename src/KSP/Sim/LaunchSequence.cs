﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.LaunchSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class LaunchSequence : StagedSequence
  {
    private LaunchSequence.Stages Foo;
    private static float Duration;
    private static List<Tuple<LaunchSequence.Stages, float>> DefaultCues;
    private static List<Tuple<LaunchSequence.Stages, float>> cues;
    private LaunchSequence.Stages stage;

    public override string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Dictionary<Enum, object> events
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override Enum Events
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchSequence() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LaunchSequence() => throw null;

    public enum Stages
    {
      SoundSupression,
      WaterStart,
      BurnoffStart,
      EngineStart,
      DroppingIce,
      LiftingOff,
      KillWater,
      KillBurnoff,
      KillIce,
      Complete,
    }
  }
}
