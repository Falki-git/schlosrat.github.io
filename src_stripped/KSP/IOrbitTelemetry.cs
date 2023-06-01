﻿// Decompiled with JetBrains decompiler
// Type: KSP.IOrbitTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP
{
  public interface IOrbitTelemetry : IFlightTelemetry, IVehicleTelemetry
  {
    Vector OrbitPrograde { get; }

    Vector OrbitRetrograde { get; }

    Vector OrbitNormal { get; }

    Vector OrbitAntiNormal { get; }

    Vector OrbitRadialIn { get; }

    Vector OrbitRadialOut { get; }

    Vector OrbitalVelocity { get; }

    double OrbitalSpeed { get; }

    IOrbit Orbit { get; }
  }
}
