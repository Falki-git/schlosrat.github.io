﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.EventDrivenFX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  public class EventDrivenFX : MonoBehaviour, IEventListener
  {
    public GameObject FxPrefab;
    public PlaceholderEventEmitters.Emitters EmitterType;
    public LaunchSequence.Stages EventType;
    public LaunchSequence.Stages KillEvent;
    public string AudioEvent;
    public string AudioKillEvent;
    private EngagedContract fireContract;
    private EngagedContract killContract;
    private IEventEmitter emitter;
    private FXGroup fx;

    public Action<Enum> Fire
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Engage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Disengage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleEvent(Enum eventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KillFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LaunchFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EventDrivenFX() => throw null;
  }
}
