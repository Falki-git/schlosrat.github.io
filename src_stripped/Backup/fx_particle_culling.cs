﻿// Decompiled with JetBrains decompiler
// Type: fx_particle_culling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class fx_particle_culling : MonoBehaviour
{
  private ParticleSystem.Particle[] _parParticleList;
  public AnimationCurve _amcParticleLifeTime;
  public bool _bUseVariableFadeOut;
  public AnimationCurve _amcParticleFadeOutTime;
  public float _fParticleFadeOutRate;
  protected ParticleSystem _parTargetParticleSystem;

  protected ParticleSystem TargetParticleSystem
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public fx_particle_culling() => throw null;
}
