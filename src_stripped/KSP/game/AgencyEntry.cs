﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Networking.MP.Utils;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class AgencyEntry
  {
    public const AgencyManager DEFAULT_AGENCY_MANAGER = null;
    public const int DEFAULT_AGENCY_ID = 0;
    public const string DEFAULT_AGENCY_NAME = "Kerbal Space Agency";
    public static Color DEFAULT_COLOR_BASE;
    public static Color DEFAULT_COLOR_ACCENT;
    public static string DEFAULT_FLAG_SPRITE_LOCATION;
    private AgencyManager _agencyManager;
    private int _agencyId;
    private string _agencyName;
    private Color _colorBase;
    private Color _colorAccent;
    private string _flagSpriteLocation;
    private SpriteLoader _spriteLoader;
    private AgencyEntry.LoadAgencyFlagCompletedCallback _loadAgencyFlagCompletedCallback;
    private List<KSP.Game.Missions.Definitions.MissionSaveData> _missionSaveData;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AgencyManager AgencyManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry GetPrev() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry GetNext() => throw null;

    public int AgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAgencyId() => throw null;

    public string AgencyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetAgencyName(string agencyName) => throw null;

    public Color ColorBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetColorBase(Color colorBase) => throw null;

    public Color ColorAccent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetColorAccent(Color colorAccent) => throw null;

    public string FlagSpriteLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetFlagSpriteLocation(string flagSpritelocation) => throw null;

    public Sprite AgencyFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool AgencyFlagIsLoadInProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAgencyFlag(AgencyEntry.LoadAgencyFlagCompletedCallback cb = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CancelAgencyFlagLoad() => throw null;

    public List<KSP.Game.Missions.Definitions.MissionSaveData> MissionSaveData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissions(List<KSP.Game.Missions.Definitions.MissionSaveData> src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry(
      AgencyManager agencyManager,
      int agencyId,
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      List<KSP.Game.Missions.Definitions.MissionSaveData> missionSaveData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~AgencyEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      AgencyManager agencyManager,
      int agencyId,
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      List<KSP.Game.Missions.Definitions.MissionSaveData> missionSaveData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFieldChanged(AgencyMPActionField agencyMPActionField) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLookupInfo(int agencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugAgencyIdAndNameString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AgencyEntry() => throw null;

    public delegate void LoadAgencyFlagCompletedCallback(AgencyEntry agencyEntry, bool success);
  }
}
