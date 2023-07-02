﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleLongitudePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleLongitude", false, "Active Vessel Longitude Coordinate value.", "Checks the Active Sim VesselComponent.Longitude which is it's telemetry TelemetryComponent Longitude value.")]
  public class VehicleLongitudePropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleLongitudePropertyWatcher() => throw null;
  }
}
