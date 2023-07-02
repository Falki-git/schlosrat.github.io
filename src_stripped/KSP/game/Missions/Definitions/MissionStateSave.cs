﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionStateSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.State;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KSP.Game.Missions.Definitions
{
  public struct MissionStateSave
  {
    [JsonProperty]
    public string ID;
    [JsonProperty]
    public MissionState state;
    [JsonProperty]
    public List<MissionDataStageSave> missionStageSave;
    [JsonProperty]
    public int currentStage;
  }
}
