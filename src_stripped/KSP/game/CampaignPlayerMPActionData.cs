﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignPlayerMPActionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class CampaignPlayerMPActionData
  {
    public const string DEFAULT_PLAYER_GUID_STRING = "";
    public const CampaignPlayerMPAction DEFAULT_CAMPAIGN_PLAYER_MP_ACTION = CampaignPlayerMPAction.None;
    public const CampaignPlayerMPActionField DEFAULT_CAMPAIGN_PLAYER_MP_ACTION_FIELD = CampaignPlayerMPActionField.None;
    public const string DEFAULT_PLAYER_NAME_STRING = "";
    public const byte DEFAULT_PLAYER_ID = 0;
    public const GameState DEFAULT_STARTING_GAME_STATE = GameState.Invalid;
    public const GameState DEFAULT_HISTORICAL_GAME_STATE = GameState.Invalid;
    public const int DEFAULT_AGENCY_ID = 0;
    public const string DEFAULT_ACTIVE_LOCAL_SPACE_CB_STRING_OR_NULL = null;
    public const string DEFAULT_OBSERVED_SIM_OBJECT_GUID_STRING_OR_NULL = null;
    public const string DEFAULT_ACTIVE_VESSEL_NAME_STRING_OR_NULL = null;
    public const string DEFAULT_ACTIVE_VESSEL_GUID_STRING_OR_NULL = null;
    public const ActiveCameraGroup DEFAULT_ACTIVE_CAMERA_GROUP = ActiveCameraGroup.None;
    public const string DEFAULT_ACTIVE_CAMERA_INFO_STRING_OR_NULL = null;
    public const string DEFAULT_FLIGHT_CONTROL_STATE_STRING_OR_NULL = null;
    public const string DEFAULT_LAST_OAB_WORKSPACE_SNAPSHOT_STRING_OR_NULL = null;
    public const string DEFAULT_LAST_OAB_CONFIG_STRING_OR_NULL = null;
    public const string DEFAULT_COPY_LOCATION_STRING_OR_NULL = null;
    public const string DEFAULT_FAVORITED_PARTS_STRING_OR_NULL = null;
    public const string DEFAULT_PART_NAME_STRING_OR_NULL = null;
    public const bool DEFAULT_IS_FTUE_ENABLED = false;
    public const string DEFAULT_MISSIONS_SAVE_DATA_JSON_STRING_OR_NULL = null;
    public const string DEFAULT_COMPLETED_TUTORIALS_STRING_OR_NULL = null;
    public const string DEFAULT_COMPLETED_FTUES_STRING_OR_NULL = null;
    public static Color DEFAULT_PART_COLOR_BASE;
    public static Color DEFAULT_PART_COLOR_ACCENT;
    private string _playerGuidString;
    private CampaignPlayerMPAction _campaignPlayerMPAction;
    private CampaignPlayerMPActionField _campaignPlayerMPActionField;
    private string _playerNameString;
    private byte _playerId;
    private GameState _startingGameState;
    private GameState _historicalGameState;
    private int _agencyId;
    private string _activeLocalSpaceCBStringOrNull;
    private string _observedSimObjectGuidStringOrNull;
    private string _activeVesselNameStringOrNull;
    private string _activeVesselGuidStringOrNull;
    private ActiveCameraGroup _activeCameraGroup;
    private string _activeCameraInfoStringOrNull;
    private string _flightControlStateStringOrNull;
    private string _lastOABWorkspaceSnapshotStringOrNull;
    private string _lastOABConfigStringOrNull;
    private string _copyLocationStringOrNull;
    private string _favoritedPartsStringOrNull;
    private string _partNameStringOrNull;
    private bool _isFTUEEnabled;
    private string _missionsJsonStringOrNull;
    private string _completedTutorialsStringOrNull;
    private string _completedFTUEsStringOrNull;
    private Color _partColorBase;
    private Color _partColorAccent;

    public string PlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerGuidString(string playerGuidString) => throw null;

    public CampaignPlayerMPAction CampaignPlayerMPAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCampaignPlayerMPAction(CampaignPlayerMPAction campaignPlayerMPAction) => throw null;

    public CampaignPlayerMPActionField CampaignPlayerMPActionField
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCampaignPlayerMPActionField(
      CampaignPlayerMPActionField campaignPlayerMPActionField)
    {
      throw null;
    }

    public GameState StartingGameState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PlayerNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerNameString(string playerNameString) => throw null;

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStartingGameState(GameState startingGameState) => throw null;

    public GameState HistoricalGameState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHistoricalGameState(GameState historicalGameState) => throw null;

    public int AgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyId(int agencyId) => throw null;

    public string ActiveLocalSpaceCBStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveLocalSpaceCBStringOrNull(string activeLocalSpaceCBStringOrNull) => throw null;

    public string ObservedSimObjectGuidStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObservedSimObjectGuidStringOrNull(string observedSimObjectGuidStringOrNull) => throw null;

    public string ActiveVesselNameStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveVesselNameStringOrNull(string activeVesselNameStringOrNull) => throw null;

    public string ActiveVesselGuidStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveVesselGuidStringOrNull(string activeVesselGuidStringOrNull) => throw null;

    public ActiveCameraGroup ActiveCameraGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCameraGroup(ActiveCameraGroup activeCameraGroup) => throw null;

    public string ActiveCameraInfoStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCameraInfoStringOrNull(string activeCameraInfoStringOrNull) => throw null;

    public string FlightControlStateStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlightControlStateStringOrNull(string flightControlStateStringOrNull) => throw null;

    public string LastOABWorkspaceSnapshotStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLastOABWorkspaceSnapshotStringOrNull(string lastOABWorkspaceSnapshotStringOrNull) => throw null;

    public string LastOABConfigStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLastOABConfigStringOrNull(string lastOABConfigStringOrNull) => throw null;

    public string CopyLocationStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCopyLocationStringOrNull(string copyLocationStringOrNull) => throw null;

    public string FavoritedPartsStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFavoritedPartsStringOrNull(string favoritedPartsStringOrNull) => throw null;

    public string PartNameStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartNameStringOrNull(string partNameStringOrNull) => throw null;

    public bool IsFTUEEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsFTUEEnabled(bool isFTUEEnabled) => throw null;

    public string MissionsJsonStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionsJsonStringOrNull(string missionsJsonStringOrNull) => throw null;

    public string CompletedTutorials
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCompletedTutorialsStringOrNull(string completedTutorialOrNull) => throw null;

    public string CompletedFTUEs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCompletedFTUEsOrNull(string completedFTUEsOrNull) => throw null;

    public Color PartColorBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartColorBase(Color partColorBase) => throw null;

    public Color PartColorAccent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartColorAccent(Color partColorAccent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerMPActionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerMPActionData(
      string playerGuidString,
      CampaignPlayerMPAction campaignPlayerMPAction,
      CampaignPlayerMPActionField campaignPlayerMPActionField,
      string playerNameString,
      byte playerId,
      GameState startingGameState,
      GameState historicalGameState,
      int agencyId,
      string activeLocalSpaceCBStringOrNull,
      string observedSimObjectGuidStringOrNull,
      string activeVesselNameStringOrNull,
      string activeVesselGuidStringOrNull,
      ActiveCameraGroup activeCameraGroupValue,
      string activeCameraInfoStringOrNull,
      string flightControlStateStringOrNull,
      string lastOABWorkspaceSnapshotStringOrNull,
      string lastOABConfigStringOrNull,
      string copyLocationStringOrNull,
      string favoritedPartsStringOrNull,
      string partNameStringOrNull,
      bool isFTUEEnabled,
      string missionsJsonStringOrNull,
      string completedTutorialsOrNull,
      string completedFTUEsOrNull,
      Color partColorBase,
      Color partColorAccent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerMPActionData(CampaignPlayerMPActionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      string playerGuidString,
      CampaignPlayerMPAction campaignPlayerMPAction,
      CampaignPlayerMPActionField campaignPlayerMPActionField,
      string playerNameString,
      byte playerId,
      GameState startingGameState,
      GameState historicalGameState,
      int agencyId,
      string activeLocalSpaceCBStringOrNull,
      string observedSimObjectGuidStringOrNull,
      string activeVesselNameStringOrNull,
      string activeVesselGuidStringOrNull,
      ActiveCameraGroup activeCameraGroup,
      string activeCameraInfoStringOrNull,
      string flightControlStateStringOrNull,
      string lastOABWorkspaceSnapshotStringOrNull,
      string lastOABConfigStringOrNull,
      string copyLocationStringOrNull,
      string favoritedPartsStringOrNull,
      string partNameStringOrNull,
      bool isFTUEEnabled,
      string missionsJsonStringOrNull,
      string completedTutorialsStringOrNull,
      string completedFTUEsStringOrNull,
      Color partColorBase,
      Color partColorAccent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(CampaignPlayerMPActionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      string playerGuidString,
      CampaignPlayerMPAction campaignPlayerMPAction,
      CampaignPlayerMPActionField campaignPlayerMPActionField,
      string playerNameString,
      byte playerId,
      GameState startingGameState,
      GameState historicalGameState,
      int agencyId,
      string activeLocalSpaceCBStringOrNull,
      string observedSimObjectGuidStringOrNull,
      string activeVesselNameStringOrNull,
      string activeVesselGuidStringOrNull,
      ActiveCameraGroup activeCameraGroup,
      string activeCameraInfoStringOrNull,
      string flightControlStateStringOrNull,
      string lastOABWorkspaceSnapshotStringOrNull,
      string lastOABConfigStringOrNull,
      string copyLocationStringOrNull,
      string favoritedPartsStringOrNull,
      string partNameStringOrNull,
      bool isFTUEEnabled,
      string missionsJsonStringOrNull,
      string completedTutorialsStringOrNull,
      string completedFTUEsStringOrNull,
      Color partColorBase,
      Color partColorAccent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(CampaignPlayerMPActionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CampaignPlayerMPActionData() => throw null;
  }
}
