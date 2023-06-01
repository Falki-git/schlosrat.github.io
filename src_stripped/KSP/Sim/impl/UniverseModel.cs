﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UniverseModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class UniverseModel : IUniverseModel, ISimulationModelMap, IFixedUpdate, IPriorityOverride
  {
    private ModelLookup _modelLookup;
    private List<SimulationObjectModel> scratchSimulationObjects;
    private List<SimulationObjectModel> _tempStorageAlLDebris;
    private Comparison<SimulationObjectModel> _simObjectCreationTimeComparison;
    private const byte PLAYER_ID_NONE = 0;
    private const byte MAX_PLAYER_COUNT = 1;
    private const ushort MAX_SIM_OBJECT_COUNT_PER_PLAYER = 2048;
    private readonly DictionaryValueList<IGGuid, VesselComponent> _allVessels;
    private readonly Dictionary<ulong, VesselComponent>[] _playerOwnedVessels;
    private readonly Dictionary<IGGuid, PartComponent> _allParts;
    private readonly Dictionary<ulong, PartComponent>[] _playerOwnedParts;
    private readonly List<CelestialBodyComponent> _allCelestialBodies;
    private readonly Dictionary<IGGuid, ColonyComponent> _allColonies;
    private readonly Dictionary<ulong, ColonyComponent>[] _playerOwnedColonies;
    private readonly Dictionary<IGGuid, KerbalComponent> _allKerbals;
    private readonly Dictionary<IGGuid, FlagComponent> _allFlags;
    private readonly Dictionary<ulong, KerbalComponent>[] _playerOwnedKerbals;
    private TransformModel _galacticOrigin;
    private bool _isSimObjectCountDirty;

    public ModelLookup ModelLookup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumModels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double UniversalTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double UniversalTimeDelta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ILateUpdateDriver lateUpdateDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string ViewPrefabAssetKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IEnumerable<SimulationObjectModel> SimulationObjects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent HomeWorld
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int CelestialBodiesCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public QuaternionD Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double InverseRotAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CelestialFrame Zup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public event Action<SimulationObjectModel> onSimulationObjectAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<SimulationObjectModel> onSimulationObjectRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<CelestialBodyComponent> onCelestialBodyAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<CelestialBodyComponent> onCelestialBodyRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<VesselComponent> onVesselAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<VesselComponent> onVesselRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<PartComponent> onPartAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<PartComponent> onPartRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<UniverseState> onUniverseStateUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public InertialFrame inertialReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseModel(
      double universalTime,
      InertialFrame inertialReferenceFrame,
      ILateUpdateDriver lateUpdateDriver)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~UniverseModel() => throw null;

    public bool IsSimObjectCountDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesGlobalIdExist(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesGlobalNameKeyExist(string globalNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesObjectIdExist(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckModelGuidPrerequisuites(SimulationObjectModel model, out string errorStringOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddSimulationObject(SimulationObjectModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSimulationObject(SimulationObjectModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckDebrisBudget(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddColony(ColonyComponent colony) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveColony(ColonyComponent colony) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddKerbal(KerbalComponent kerbal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveKerbal(KerbalComponent kerbal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddFlag(FlagComponent flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveFlag(FlagComponent flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddPart(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePart(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddCelestialBody(CelestialBodyComponent celestialBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCelestialBody(CelestialBodyComponent celestialBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SimulationObjectModel ISimulationModelMap.FromGlobalNameKey(string globalNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SimulationObjectModel ISimulationModelMap.FromUniqueString(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SimulationObjectModel ISimulationModelMap.FromGlobalId(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<SimulationObjectModel> GetAllSimObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<SimulationObjectModel> GetAllSimObjectsForPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObject(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObjectByNameKey(string globalNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObjectByString(string globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObject(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<VesselComponent> GetAllVessels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<VesselComponent> GetAllOwnedVessels(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAllOwnedVessels(byte playerId, ref List<VesselComponent> results) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselComponent FindVesselComponent(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyComponent FindColonyComponent(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalComponent FindKerbalComponent(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlagComponent FindFlagComponent(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselComponent FindVesselComponent(byte playerId, ushort objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyComponent FindColonyComponent(byte playerId, ushort objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalComponent FindKerbalComponent(byte playerId, ushort objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<PartComponent> GetAllParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<PartComponent> GetAllParts(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent FindPartComponent(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent FindPartComponent(byte playerId, ushort objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<VesselComponent> GetAllVesselsInRange(Position position, double radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetAllVesselsInRange(
      Position position,
      double radius,
      ref List<VesselComponent> results,
      Func<Position, VesselComponent, bool> funcFilter = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetAllPartsInRange(
      Position position,
      double radius,
      ref List<PartComponent> results)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent FindCelestialBodyByName(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ColonyComponent> GetAllColonies(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAllColonies(byte playerId, ref List<ColonyComponent> results) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<CelestialBodyComponent> GetAllCelestialBodies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUniversalTime(double time) => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IFixedUpdate.OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AdvanceUniversalTime(double fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FixedUpdateSimObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSimObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LateUpdateSimObjects() => throw null;

    public TransformModel GalacticOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCBs(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryFindTransform(string name, out ITransformModel result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryFindTransform(ITransformModel root, string name, out ITransformModel result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCBsRecursive(CelestialBodyComponent cb, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ZupAtUT(double UT, CelestialBodyComponent body, ref CelestialFrame tempZup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetStar(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetStar(ICoordinateSystem coordinateSystem, Vector3d refPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetMainBody(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetMainBody(ICoordinateSystem coordinateSystem, Vector3d refPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetGeeForceAtPosition(
      ICoordinateSystem coordinateSystem,
      Vector3d pos,
      CelestialBodyComponent mainBody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetGeeForceAtPosition(Position pos, CelestialBodyComponent mainBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStaticPressure(double altitude, CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStaticPressure(ICoordinateSystem coordinateSystem, Vector3d position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStaticPressure(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStaticPressure(Position position, CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStaticPressure(
      ICoordinateSystem coordinateSystem,
      Vector3d position,
      CelestialBodyComponent body)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAtmDensity(double pressure, double temperature, CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeAtPos(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeAtPos(ICoordinateSystem coordinateSystem, Vector3d position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeAtPos(Position position, CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeAtPos(
      ICoordinateSystem referenceFrame,
      Vector3d position,
      CelestialBodyComponent body)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetUpAxis(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetUpAxis(CelestialBodyComponent body, Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector GetUpAxis(
      CelestialBodyComponent body,
      ICoordinateSystem coordinateSystem,
      Vector3d position)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CelestialBodyComponent GetSphereOfInfluence(
      ICoordinateSystem coordinateSystem,
      Vector3d pos,
      CelestialBodyComponent body)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateState(UniverseState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetDebris(byte authorizingPlayerId, ref List<SimulationObjectModel> allDebris) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareCreationTimeNewestToOldest(
      SimulationObjectModel x,
      SimulationObjectModel y)
    {
      throw null;
    }
  }
}
