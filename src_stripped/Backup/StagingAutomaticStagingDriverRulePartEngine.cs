﻿// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriverRulePartEngine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.OAB;
using System.Runtime.CompilerServices;

public abstract class StagingAutomaticStagingDriverRulePartEngine : 
  StagingAutomaticStagingDriverRuleStageTypeFilter
{
  protected bool WasHandledByEngineRule
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected StagingAutomaticStagingDriverRulePartEngine(
    ContextListProperty<StageDataContext> stagingStack,
    AssemblyPartStageType stageType)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override bool TryGetSuggestedStageIndex(
    IObjectAssemblyPart part,
    ref int suggestedStageIndex)
  {
    throw null;
  }
}
