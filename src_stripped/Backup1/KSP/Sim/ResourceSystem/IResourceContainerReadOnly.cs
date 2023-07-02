﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerReadOnly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IResourceContainerReadOnly : 
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    bool IsResourceContained(ResourceDefinitionID resourceID);

    int GetResourcesContainedCount();

    ContainedResourceData GetResourceContainedData(ResourceDefinitionID resourceID);

    double GetResourceStoredUnits(ResourceDefinitionID resourceID);

    double GetResourcePreProcessedUnits(ResourceDefinitionID resourceID);

    double GetResourceCapacityUnits(ResourceDefinitionID resourceID);

    double GetResourceEmptyUnits(ResourceDefinitionID resourceId);

    double GetResourceFillRatio(ResourceDefinitionID resourceID);
  }
}
