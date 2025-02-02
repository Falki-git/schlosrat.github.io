﻿// Decompiled with JetBrains decompiler
// Type: KerbalFSM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class KerbalFSM
{
  protected List<KFSMState> States;
  protected KFSMState currentState;
  protected KFSMEvent lastEvent;
  protected KFSMState lastState;
  protected bool fsmStarted;
  public string currentStateName;
  public string lastEventName;
  public bool DebugBreakOnStateChange;
  public Callback<KFSMState, KFSMState, KFSMEvent> OnStateChange;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KerbalFSM() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddState(KFSMState st) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddEvent(KFSMEvent ev, params KFSMState[] toStates) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddEventExcluding(KFSMEvent ev, params KFSMState[] excStates) => throw null;

  public KFSMState CurrentState
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public KFSMEvent LastEvent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public KFSMState LastState
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool Started
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public double TimeAtCurrentState
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public int FramesInCurrentState
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RunEvent(KFSMEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartFSM(string initialStateName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartFSM(KFSMState initialState) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateFSM() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FixedUpdateFSM() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void LateUpdateFSM() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void updateFSM(KFSMUpdateMode mode) => throw null;
}
