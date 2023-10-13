﻿// Decompiled with JetBrains decompiler
// Type: PlanetRingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlanetRingManager : MonoBehaviour
{
  [SerializeField]
  private float distanceFromRing;
  [SerializeField]
  private float distanceFromCenter;
  [Header("Ring Particle Field Prefab")]
  public GameObject particleFieldPrefab;
  private GameObject cameraEffect;
  private GameObject ringGroup;
  private Collider ringCollider;
  private Renderer topRingRenderer;
  private Renderer bottomRingRenderer;
  [SerializeField]
  [Header("Ring GameObjects")]
  private GameObject topNear;
  [SerializeField]
  private GameObject topFar;
  [SerializeField]
  private GameObject bottomNear;
  [SerializeField]
  private GameObject bottomFar;
  private Renderer topNearRenderer;
  private Renderer topFarRenderer;
  private Renderer bottomNearRenderer;
  private Renderer bottomFarRenderer;
  private int planetAngleID;
  private int lightAngleID;
  private int planetPositionID;
  private int starPositionID;

  private CelestialBodyComponent parentPlanet
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IScaledSpaceProvider scaledSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IPhysicsSpaceProvider physicsSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IUniverseObserver observer
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private Transform celestialTransform
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InjectDependencies(
    CelestialBodyComponent body,
    IScaledSpaceProvider scaledSpace,
    IPhysicsSpaceProvider physicsSpace,
    IUniverseObserver universeObserver,
    Transform celestialTransform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float ClampAngles(float angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PlanetRingManager() => throw null;
}
