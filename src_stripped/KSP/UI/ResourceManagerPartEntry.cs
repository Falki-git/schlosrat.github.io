﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResourceManagerPartEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class ResourceManagerPartEntry : ApiDataContext
  {
    [DataProperty("PartName")]
    public Property<string> PartName;
    [DataProperty("PartFamily")]
    public Property<string> PartFamily;
    [DataProperty("GUID")]
    public PropertyReadonly<IGGuid> Guid;
    [DataProperty("IsHighlighted")]
    public Property<bool> IsHighlighted;
    [DataProperty("IsInTransferList")]
    public PropertyReadonly<bool> IsInTransferList;
    [DataProperty("PartIndex")]
    public PropertyReadonly<int> PartIndex;
    [DataList("ContainersList")]
    public ContextListProperty<ResourceManagerContainerEntry> Containers;
    private ResourceManagerUI _resourceManagerUI;
    private PartComponent _partComponent;
    private ResourceFlowRequestBroker _resourceFlowRequestBroker;
    private ResourceFlowRequestHandle _requestHandle;
    private List<ResourceFlowRequestCommandConfig> _requestCommandsList;

    public string GetPartFamily
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string GetPartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceManagerPartEntry(
      ResourceManagerUI resourceManagerUI,
      VesselComponent activeVessel,
      PartComponent part,
      int partIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LocalizePartsText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreFlowRequestsDone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitEntry(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Cleanup(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetResourceContainersToFlowState(
      ResourceDefinitionID resourceID,
      FlowState flowState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearFlowStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasFlowRequests() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFlowRequest(ResourceFlowRequestCommandConfig newRequestConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool StartResourceTransfer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopResourceTransfer() => throw null;
  }
}
