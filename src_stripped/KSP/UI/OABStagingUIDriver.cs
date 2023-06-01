﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.OABStagingUIDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class OABStagingUIDriver : StagingUIDriverBase
  {
    private List<IObjectAssemblyPartStageInfo> lastOABReportedState;

    public int TotalStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessChange(List<IObjectAssemblyPartStageInfo> current) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanEmptyStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMainAssemblyChanged(
      IObjectAssembly oldObjectAssembly,
      IObjectAssembly newObjectAssembly)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InformVABOfStagingChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasID(List<IObjectAssemblyPartStageInfo> info, IGGuid unique) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStageChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOmitStagingMessages(bool omitStagingMsgs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDeltaV() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EngineModeChanged(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABStagingUIDriver() => throw null;
  }
}
