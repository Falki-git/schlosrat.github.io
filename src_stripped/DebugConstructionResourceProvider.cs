﻿// Decompiled with JetBrains decompiler
// Type: DebugConstructionResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DebugConstructionResourceProvider : IConstructionResourceProvider
{
  private static DebugConstructionResourceProvider _instance;
  private Dictionary<ResourceDefinitionID, double> _resources;
  private ResourceDefinitionDatabase _resourceDatabase;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugConstructionResourceProvider() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static DebugConstructionResourceProvider GetInstance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool CanAffordCost(
    IReadOnlyDictionary<ResourceDefinitionID, double> cost)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool DeductCost(
    IReadOnlyDictionary<ResourceDefinitionID, double> cost)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Dictionary<ResourceDefinitionID, double> GetCurrentResources() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddResources(string resourceName, double amount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddResources(ResourceDefinitionID resource, double amount) => throw null;
}
