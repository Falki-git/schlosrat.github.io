﻿// Decompiled with JetBrains decompiler
// Type: FXModuleBoundsModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof (ParticleSystem))]
public class FXModuleBoundsModifier : MonoBehaviour
{
  public bool ModifyEmissionOn;
  public float Emission_BurstMultiplier;
  public float Emission_RateOverTimeMultiplier;
  public bool ModifyShapeOn;
  public string ShapeScaleBoundsMapping;
  public Vector3 Shape_ScaleMultiplier;
  public bool applyToChildren;
  private ParticleSystem[] _particleSystems;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Modify(Bounds bounds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ModifyShape(Vector3 modifier, ParticleSystem _particleSystem) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ModifyEmission(
    float rateOverTimeMultiplier,
    float burstMultiplier,
    ParticleSystem _particleSystem)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FXModuleBoundsModifier() => throw null;
}
