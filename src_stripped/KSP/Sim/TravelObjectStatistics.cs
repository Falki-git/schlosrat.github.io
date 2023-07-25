﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectStatistics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Sim
{
  [Serializable]
  public struct TravelObjectStatistics
  {
    public double DistanceTravelled;
    public double GroundDistanceTravelled;
    public double MaxAltitude;
    public double MaxGeeForce;
    public double MaxSpeed;
    public double MaxSpeedOverGround;
    public double MaxGroundSpeed;
  }
}
