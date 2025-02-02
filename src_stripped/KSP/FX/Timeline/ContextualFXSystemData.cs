﻿// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.VFX;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace KSP.FX.Timeline
{
  [Serializable]
  public class ContextualFXSystemData : PlayableAsset, ITimelineClipAsset
  {
    public ContextualFXSystemBehavior CFXSData;
    public FXType fxType;
    public string GroupID;
    public string WwiseStartEventName;
    public string WwiseStopEventName;
    public VFXEventType VfxEventType;
    public SFXEventType SfxEventType;
    public GameObject FXPrefabOverride;
    public SelectedDiscoverableMessage StartMessage;
    public SelectedDiscoverableMessage StopMessage;

    public ClipCaps clipCaps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualFXSystemData() => throw null;
  }
}
