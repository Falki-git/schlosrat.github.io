﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedKeplerOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim
{
  public struct SerializedKeplerOrbit
  {
    public string referenceBodyGuid;
    public double inclination;
    public double eccentricity;
    public double semiMajorAxis;
    public double longitudeOfAscendingNode;
    public double argumentOfPeriapsis;
    public double meanAnomalyAtEpoch;
    public double epoch;
  }
}
