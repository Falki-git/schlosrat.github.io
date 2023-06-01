﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedAssembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedAssembly
  {
    public const string PLAYER_GUID_STRING_NONE = "";
    public const byte PLAYER_ID_NONE = 0;
    public const string DEFAULT_OWNER_PLAYER_GUID_STRING = "";
    public const byte DEFAULT_OWNER_PLAYER_ID = 0;
    public const byte DEFAULT_AUTHORITY_PLAYER_ID = 0;
    public static readonly string CURRENT_VERSION;
    public string Version;
    public IGGuid Guid;
    public string OwnerPlayerGuidString;
    public byte OwnerPlayerId;
    public byte AuthorityPlayerId;
    public AssemblyOABConfig AssemblyOABConfig;
    public AssemblyDefinition AssemblyDefinition;
    public StagingState stagingState;
    public PartOwnerState partOwnerState;
    public ManeuverPlanState maneuverPlanState;
    public VesselState vesselState;
    public KerbalState kerbalState;
    public bool IsDebris;
    public List<SymmetrySetData> SymmetrySets;
    public SerializedLocation location;
    public List<SerializedPart> parts;
    public GimbalState CameraGimbalSate;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateGuids(
      DictionaryValueList<IGGuid, IGGuid> partIdsToChange)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SerializedAssembly() => throw null;
  }
}
