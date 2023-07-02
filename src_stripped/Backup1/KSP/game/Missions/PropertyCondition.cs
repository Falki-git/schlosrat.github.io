﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.PropertyCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Messages.PropertyWatchers;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Game.Missions
{
  public class PropertyCondition : Condition
  {
    [JsonProperty]
    public bool RequireCurrentValue;
    [JsonProperty]
    private bool valueMet;
    [JsonProperty]
    public string PropertyTypeAQN;
    [JsonIgnore]
    public PropertyWatcher property;
    [JsonProperty]
    public double TestWatchedValue;
    public string TestWatchedstring;
    public int TestWatchedInt;
    public bool TestWatchedBool;
    [JsonProperty]
    public PropertyOperator propOperator;
    [JsonProperty]
    public bool isInput;
    [JsonProperty]
    public string Inputstring;

    [JsonProperty]
    public string ConditionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public string PropertyTypeAQNAbbrev
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private string _parentMissionID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Evaluate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckCurrentValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Initialize(MissionData parentMission, IMissionConditionOwner owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string FriendlyPropOperatorString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDescriptionText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DumpStatus(StringBuilder sb, int indent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Condition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetDebugEvaluationString(bool includeResults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyCondition() => throw null;
  }
}
