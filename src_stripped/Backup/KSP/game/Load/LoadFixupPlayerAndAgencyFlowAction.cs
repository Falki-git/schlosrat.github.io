﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadFixupPlayerAndAgencyFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class LoadFixupPlayerAndAgencyFlowAction : SaveLoadGameFlowActionBase
  {
    private LoadOrSaveCampaignTicket _loadOrSaveCampaignTicket;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadFixupPlayerAndAgencyFlowAction(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TakeOverPlayer(CampaignPlayerEntry campaignPlayerEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeVesselOwners(
      string oldPlayerNameString,
      string oldPlayerGuidString,
      byte oldPlayerId,
      string newPlayerNameString,
      string newPlayerGuidString,
      byte newPlayerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MakeAllVesselsBeOwnedByThisPlayer(
      string playerNameString,
      string playerGuidString,
      byte playerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
