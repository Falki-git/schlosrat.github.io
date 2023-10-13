﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IDynamicOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IDynamicOrbit : IOrbit
  {
    void UpdateFromOrbitAtUT(IOrbit orbit, double UT, CelestialBodyComponent toBody);

    void UpdateFromStateVectors(
      Position pos,
      Velocity vel,
      CelestialBodyComponent refBody,
      double UT);
  }
}
