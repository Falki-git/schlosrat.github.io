﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IViewController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;

namespace KSP.Sim
{
  public interface IViewController
  {
    IKeyboardInputDriver keyboardInput { get; }

    FlightInputHandler flightInputHandler { get; }

    EVAInputHandler evaInputHandler { get; }

    IInputLockManager inputLockManager { get; }

    CutsceneTools cutsceneTools { get; }

    UniverseModel Universe { get; }

    TimeWarp TimeWarp { get; }

    bool IsPaused { get; }

    void SetPause(bool newPauseState);

    double universalTime { get; }

    bool ready { get; }

    bool patchedConicsAttached { get; set; }

    bool CreatePlayerColony(
      string optionalGuid,
      LegacySerializedColony colony,
      SerializedLocation location,
      Action<IVehicle> creationCallback);

    bool TryGetActiveVehicle(out IVehicle activeVehicle, bool requireValidInSim = true);

    bool TryGetActiveSimVessel(out VesselComponent activeSimVessel, bool requireValidInSim = true);

    IVehicle GetActiveVehicle(bool requireValidInSim = true);

    VesselComponent GetActiveSimVessel(bool requireValidInSim = true);

    bool HaveActiveVehicle(bool requireValidInSim = true);

    bool SetActiveVehicle(
      VesselComponent simVesselComponent,
      bool observeVessel,
      bool forceVesselActive);

    event Action OnViewControllerLoaded;

    event Action OnViewControllerUnloaded;

    void SyncToView(UniverseView view, Action finishedCallback);

    void Shutdown();

    void SetActiveInternalSpace(PartComponent visiblePart);

    CelestialBodyComponent GetBodyByName(string bodyName);

    CelestialBodyBehavior GetBehaviorIfLoaded(CelestialBodyComponent celestialBody);

    VesselBehavior GetBehaviorIfLoaded(VesselComponent vessel);

    CrewMemberBehavior GetBehaviorIfLoaded(CrewMemberComponent crew);

    ISimulationObjectView GetSimulationViewIfLoaded(SimulationObjectModel model);
  }
}
