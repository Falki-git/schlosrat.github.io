﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SuspensionAnalysisChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class SuspensionAnalysisChart : PerformanceChart
  {
    private DataLogger.Channel m_contactDepth;
    private DataLogger.Channel m_contactSpeed;
    private DataLogger.Channel m_suspensionForce;
    private DataLogger.Channel m_damperForce;
    private DataLogger.Channel m_suspensionTravel;
    private int monitoredWheel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string Title() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ResetView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupChannels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RecordData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SuspensionAnalysisChart() => throw null;
  }
}
