﻿// Decompiled with JetBrains decompiler
// Type: PrevisCameraModes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP;
using KSP.Rendering.Planets;
using KSP.Tools;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PrevisCameraModes : MonoBehaviour
{
  public PQS pqs;
  public PQSRenderer pqsRenderer;
  public Transform pqsTransform;
  public Transform scaledPlanet;
  public string scaledPrefabPath;
  public CoreCelestialBodyData coreCelestialBodyData;
  private Transform camTransform;
  private bool lateStarted;
  private PQSFreeCam freeCam;
  private bool updateReady;

  public PQSFreeCam FreeCam
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSFreeCam CreatePQSCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Transform GetCamTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetCamera(Transform parent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CollectGameObjectsInScene() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static T[] FindObjectHierarchyRootsByLayer<T>(int layer, bool includeInactive = false) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PrevisCameraModes() => throw null;
}
