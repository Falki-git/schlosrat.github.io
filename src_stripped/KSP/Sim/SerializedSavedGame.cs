﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSavedGame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Game.Missions.Definitions;
using KSP.Sim.Definitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedSavedGame
  {
    public const string DEFAULT_GALAXY_DEFINITION_KEY = "GalaxyDefinition_Default";
    public SerializedSaveGameMetadata Metadata;
    public SerializedSavedGameProperties Properties;
    public string GalaxyDefinitionKey;
    [JsonProperty("SessionManager")]
    public SerializedSessionManager SerializedSessionManager;
    [JsonProperty("SessionGuid")]
    public string SessionGuidString;
    [JsonProperty("Agencies")]
    public SerializedAgencyEntry[] Agencies;
    [JsonProperty("CampaignPlayers")]
    public SerializedCampaignPlayerEntry[] CampaignPlayers;
    public SerializedAssembly[] Vessels;
    public List<MissionData> missionData;
    public SerializedColonyData ColonyData;
    public SerializedKerbalRoster KerbalData;
    public SerializedFlag[] PlantedFlags;
    public SerializedTravelLog TravelLogData;

    [OnDeserialized]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void OnDeserializingMethod(StreamingContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCampaignPlayerEntry FindSerializedCampaignPlayerEntryByPlayerGuidString(
      string playerGuidString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSavedGame() => throw null;
  }
}
