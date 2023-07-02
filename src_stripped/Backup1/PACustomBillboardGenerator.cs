﻿// Decompiled with JetBrains decompiler
// Type: PACustomBillboardGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PACustomBillboardGenerator : PABillboardParticle, PAICustomParticleGenerator
{
  public List<PACustomParticle> particles;
  [HideInInspector]
  [SerializeField]
  private Mesh particleMesh;
  private Vector2[] particleUVs;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateCache(PAParticleField settings) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override int SetParticleCapacity(int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnValidate() => throw null;

  [ContextMenu("Apply Particles")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyParticles() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetOriginDirection(int particleIndex, Vector3 direction) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSpeed(int particleIndex, float speed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSpinSpeed(int particleIndex, float spinSpeed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetColor(int particleIndex, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetUV(int particleIndex, Rect uv) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSize(int particleIndex, float size) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetIndex(int particleIndex, float normalizedIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomBillboardGenerator() => throw null;
}
