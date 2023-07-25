﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ISimulationObjectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using UnityEngine;

namespace KSP.Sim
{
  public interface ISimulationObjectView
  {
    SimulationObjectModel Model { get; }

    IUniverseView Universe { get; }

    GameObject gameObject { get; }

    Transform transform { get; }

    Vector3 position { get; }

    Quaternion rotation { get; }

    bool PositionTrackSimObject { get; set; }

    CelestialBodyBehavior CelestialBody { get; }

    ColonyBehavior Colony { get; }

    CrewMemberBehavior CrewMember { get; }

    KerbalBehavior Kerbal { get; }

    PartBehavior Part { get; }

    PartOwnerBehavior PartOwner { get; }

    RigidbodyBehavior Rigidbody { get; }

    VesselBehavior Vessel { get; }

    ThermalBehavior ThermalBehavior { get; }

    T GetViewObjectComponent<T>() where T : ViewObjectComponent;

    bool TryGetViewObjectComponent<T>(out T viewObjectComponent);

    void Destroy();
  }
}
