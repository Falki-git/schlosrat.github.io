﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.InitializeGameInstanceFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Flow;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.StartupFlow
{
  public class InitializeGameInstanceFlowAction : FlowAction
  {
    private readonly Func<GameInstance> _game;
    private readonly GameStatesConfiguration _stateConfiguration;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitializeGameInstanceFlowAction(
      string name,
      Func<GameInstance> game,
      GameStatesConfiguration stateConfiguration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
