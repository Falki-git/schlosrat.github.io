﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.AccelerationsChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class AccelerationsChart : PerformanceChart
  {
    private DataLogger.Channel m_speed;
    private DataLogger.Channel m_throttle;
    private DataLogger.Channel m_brake;
    private DataLogger.Channel m_clutch;
    private DataLogger.Channel m_steering;
    private DataLogger.Channel m_longitudinalG;
    private DataLogger.Channel m_lateralG;

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
    public AccelerationsChart() => throw null;
  }
}
