﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionSetViewStateAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MissionSetViewStateAction : MissionActionBase, IMissionAction
  {
    [JsonProperty]
    public UIView viewState;
    [JsonProperty]
    public bool restorePreviousView;
    [JsonIgnore]
    public string ParentMissionID;

    [JsonIgnore]
    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentMissionID(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IMissionAction DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionSetViewStateAction() => throw null;
  }
}
