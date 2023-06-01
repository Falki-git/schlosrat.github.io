﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IKeplerOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;

namespace KSP.Sim
{
  public interface IKeplerOrbit : IOrbit
  {
    double inclination { get; }

    double eccentricity { get; }

    double semiMajorAxis { get; }

    double longitudeOfAscendingNode { get; }

    double argumentOfPeriapsis { get; }

    double meanAnomalyAtEpoch { get; }

    double epoch { get; }

    double period { get; }

    double MeanAnomaly { get; }

    double TrueAnomaly { get; }

    double EccentricAnomaly { get; }

    double SemiMinorAxis { get; }

    double SemiLatusRectum { get; }

    double radius { get; }

    double altitude { get; }

    double ObT { get; }

    Vector3d eccVec { get; }

    Vector3d an { get; }

    Vector3d GetRelativeOrbitNormal();

    Vector3d GetRelativeEccVector();

    Vector3d GetRelativePositionAtObT(double T);

    Vector3d GetRelativePositionFromTrueAnomaly(double tA);

    Vector3d GetRelativePositionFromTrueAnomalyZup(double tA);

    Vector3d GetRelativePositionFromEccAnomalyWithSemiMinorAxis(double E, double semiMinorAxis);

    double TrueAnomalyAtUT(double UT);

    double GetUTforTrueAnomaly(double tA, double wrapAfterSeconds);

    double RadiusAtTrueAnomaly(double tA);

    double GetDTforTrueAnomaly(double tA, double wrapAfterSeconds);

    double GetTrueAnomaly(double E);

    double GetEccentricAnomaly(double tA);

    double EccentricAnomalyAtUT(double UT);

    double TrueAnomalyAtRadius(double R);

    bool PeApIntersects(IKeplerOrbit secondary, double threshold);

    int FindClosestPoints(
      IKeplerOrbit s,
      ref double CD,
      ref double CCD,
      ref double FFp,
      ref double FFs,
      ref double SFp,
      ref double SFs,
      double epsilon,
      int maxIterations,
      ref int iterationCount);

    double GetTrueAnomalyOfZupVector(Vector3d vector);

    double GetOrbitalSpeedAtDistance(double d);

    KeplerOrbitState GetState();
  }
}
