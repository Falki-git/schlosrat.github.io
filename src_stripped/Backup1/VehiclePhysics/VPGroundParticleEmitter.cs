﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [RequireComponent(typeof (ParticleSystem))]
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Particle Emitter")]
  public class VPGroundParticleEmitter : MonoBehaviour
  {
    public VPGroundParticleEmitter.Mode mode;
    public float emissionRate;
    [Range(0.0f, 1f)]
    public float emissionShuffle;
    public float maxLifetime;
    public float minVelocity;
    public float maxVelocity;
    [Range(0.0f, 1f)]
    public float wheelVelocityRatio;
    [Range(0.0f, 1f)]
    public float tireVelocityRatio;
    public Color Color1;
    public Color Color2;
    public bool randomColor;
    private ParticleSystem m_particles;
    private ParticleSystem.EmitParams m_emitParams;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float EmitParticle(
      Vector3 position,
      Vector3 wheelVelocity,
      Vector3 tireVelocity,
      float pressureRatio,
      float intensityRatio,
      float lastParticleTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundParticleEmitter() => throw null;

    public enum Mode
    {
      PressureAndSkid,
      PressureAndVelocity,
    }
  }
}
