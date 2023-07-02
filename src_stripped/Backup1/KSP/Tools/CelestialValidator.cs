﻿// Decompiled with JetBrains decompiler
// Type: KSP.Tools.CelestialValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Tools
{
  public class CelestialValidator : MonoBehaviour
  {
    private UniverseView universeView;
    private static readonly string logTag;
    [SerializeField]
    [FormerlySerializedAs("widgetPrefab")]
    private CelestialValidatorWidget celestialWidgetPrefab;
    [SerializeField]
    private VesselValidatorWidget vesselWidgetPrefab;
    [SerializeField]
    private PartValidatorWidget partWidgetPrefab;
    [SerializeField]
    private float scaledColorFactor;
    private Dictionary<CelestialBodyComponent, CelestialValidatorWidget> CelestialWidgets;
    private Dictionary<VesselComponent, VesselValidatorWidget> VesselWidgets;
    private Dictionary<PartComponent, PartValidatorWidget> PartWidgets;

    private bool IsConnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private UniverseModel UniverseModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IScaledSpaceProvider ScaledSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWidgetLifetimes<TComponent, TWidget>(
      IEnumerable<TComponent> inUniverse,
      Dictionary<TComponent, TWidget> widgetMap,
      TWidget widgetPrefab)
      where TComponent : ObjectComponent
      where TWidget : SimObjectValidatorWidget
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWidgetPositions<TComponent, TWidget>(
      Dictionary<TComponent, TWidget> dictionary)
      where TComponent : ObjectComponent
      where TWidget : SimObjectValidatorWidget
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckUniverseConnection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialValidator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CelestialValidator() => throw null;
  }
}
