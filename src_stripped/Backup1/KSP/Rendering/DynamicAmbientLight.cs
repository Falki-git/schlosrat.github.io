﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DynamicAmbientLight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class DynamicAmbientLight : MonoBehaviour
  {
    [Header("Galaxy Skybox")]
    public Material skyboxGalaxy;
    [Header("VAB Skybox")]
    public Material skyboxVab;
    [Header("VAB Ambient")]
    public Color fogColorVAB;
    public FogMode fogModeVAB;
    public float fogDensityVAB;
    [Header("Colonial VAB Ambient")]
    public Material skyboxColonialVAB;
    public Color fogColorColonialVAB;
    public FogMode fogModeColonialVAB;
    public float fogDensityColonialVAB;
    [Header("Galaxy Ambient")]
    public Color ambientColorGalaxy;
    [Range(0.0f, 8f)]
    public float flightAmbientIntensity;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnvironmentLightingProfile(EnvironmentLightingProfile profile) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EnvironmentLightingProfile GetEnvironmentLightingProfile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicAmbientLight() => throw null;
  }
}
