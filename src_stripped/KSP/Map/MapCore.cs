﻿// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.UserInterface;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  [PrefabName("MapView.prefab")]
  public class MapCore : UIModule
  {
    [Header("Links to map components")]
    public MapUI mapUI;
    [HideInInspector]
    public Map3DView map3D;
    private List<MapItem> mapItems;
    private Dictionary<IGGuid, MapItem> guidLookup;
    private Dictionary<IGGuid, bool> _objectPickerHierarchy;
    private SubscriptionHandle _handleMapItemInteracted;
    private MapItem lastFocused;
    private MapItem focusedInternal;
    private bool _resetZoomOnFocus;
    private Position _observerPositionForSorting;
    private UniverseModel _universeModelForSorting;
    private readonly Dictionary<MapItem, double> _distanceToObserverForSorting;

    public IGGuid HomeworldGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IGGuid KSCGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MapMode Mode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MapItem Focused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapItemInteracted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMapMode(MapMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselAdded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MapItem ConstructMapItemFromVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CompareProximityToObserver(MapItem x, MapItem y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableFlightMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableFlightTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectCelestialBodies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectVehicles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MapItem DetermineInitialSelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveIndexBy(int toMove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Next() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Prev() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeALT() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeVEL() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFocus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraReset(MessageCenterMessage camResetMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Add(MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Remove(MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapItem Get(IGGuid simGUID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCore() => throw null;
  }
}
