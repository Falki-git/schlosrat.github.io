﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [CreateAssetMenu(fileName = "pqs_settings", menuName = "KSP/Settings/PQS Settings")]
  public class PQSGlobalSettings : ScriptableObject
  {
    public PQSGlobalSettings.SubdivisionInfo subdivisionInfo;
    public float colliderCullingDistance;
    public GameObject colliderPrefab;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSGlobalSettings() => throw null;

    [Serializable]
    public class SubdivData
    {
      [Tooltip("Minimum subdivision level (quad depth)")]
      public int minLevel;
      [Tooltip("Maximum subdivision level (quad depth)")]
      public int maxLevel;
      [Tooltip("The multiple of the planet radius where the tesselation level is set to minLevel")]
      public int minDetailMultiplier;
      [Tooltip("The altitude radius multiplier in which we stop trying to perform quad subdivision")]
      public float disableSubdivRadiusMultiplier;
      [Tooltip("A multiplier for each of the subdivision threshold calculations")]
      public float subdivisionThreshold;
      [Header("Terrain Tesselation Settings")]
      [Tooltip("Surface altitude to use the surface settings at")]
      public float surfaceSettingsAltitude;
      [Tooltip("Surface - distance cone altitude falloff")]
      public float surfaceTesselationAltitudeFalloff;
      [Tooltip("Surface - distance in the camera forward direction to extend terrain tesselation out to")]
      public float surfaceTesselationDistance;
      [Tooltip("Orbit altitude to use the orbit settings at")]
      public float orbitSettingsAltitude;
      [Tooltip("Orbit - distance cone altitude falloff")]
      public float orbitTesselationAltitudeFalloff;
      [Tooltip("Orbit - distance in the camera forward direction to extend terrain tesselation out to")]
      public float orbitTesselationDistance;
      [Tooltip("The number of steps to use for tesselation calculations in front of the camera")]
      public int numTesselationSteps;
      [Range(0.0f, 60f)]
      [Tooltip("The frustum cone angle to use for the tesselation frustum")]
      public float tesselationFrustumAngle;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubdivData() => throw null;
    }

    [Serializable]
    public class SubdivisionInfo
    {
      public PQSGlobalSettings.SubdivData subdivData;
      public double collapseSeaLevelValue;
      public double collapseAltitudeValue;
      public double collapseAltitudeMax;
      public double visRadSeaLevelValue;
      public double visRadAltitudeValue;
      public double visRadAltitudeMax;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Setup(PQS pqs, PQData d, PQSGlobalSettings.SubdivData sd) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubdivisionInfo() => throw null;
    }
  }
}
