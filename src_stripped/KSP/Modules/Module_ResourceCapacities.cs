﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ResourceCapacities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ResourceCapacities : PartBehaviourModule
  {
    [SerializeField]
    [FormerlySerializedAs("data")]
    protected Data_ResourceCapacities dataResourceCapacities;
    private Dictionary<ModuleProperty<float>, Action<float>> _valueChangeHandlers;
    private const string _moduleDisplayName = "PartModules/ResourceCapacities/Name";
    private const int RESOURCE_CONTAINER_SIGNIFICANT_DIGITS = 3;
    private const double RESOURCE_CONTAINER_SLIDER_STEPS = 10.0;
    private Dictionary<IResourceContainer, int> _lookupContainerIndex;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResourceCapacityChanged(
      IResourceContainer container,
      ResourceDefinitionID resourceId,
      float newValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCapacityStringTons(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCapacityStringUnits(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RoundToSignificantFigures(float toRound, int numDigits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnContainerChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ResourceCapacities() => throw null;
  }
}
