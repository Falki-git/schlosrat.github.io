﻿// Decompiled with JetBrains decompiler
// Type: fx_particle_culling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
