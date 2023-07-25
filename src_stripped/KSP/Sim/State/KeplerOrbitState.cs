﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.KeplerOrbitState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Converters;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct KeplerOrbitState
  {
    [TypeConverterIgnore]
    public string referenceBodyGuid;
    public double inclination;
    public double eccentricity;
    public double semiMajorAxis;
    public double longitudeOfAscendingNode;
    public double argumentOfPeriapsis;
    public double meanAnomalyAtEpoch;
    public double epoch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FromOrbitComponent(IOrbit orbit, out KeplerOrbitState definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KeplerOrbitState FromSerialized(SerializedKeplerOrbit serializedOrbit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KeplerOrbitState FromSerializedOrbitProperties(
      SerializedOrbitProperties serializedOrbitProperties)
    {
      throw null;
    }
  }
}
