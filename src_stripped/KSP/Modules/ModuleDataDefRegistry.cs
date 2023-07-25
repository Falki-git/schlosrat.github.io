﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ModuleDataDefRegistry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  public class ModuleDataDefRegistry
  {
    private static ModuleDataDefRegistry gInstance;
    public const int MODULE_DATA_DEF_LOOKUP_ID_NONE = 0;
    private List<ModuleData> _moduleDataList;

    public static ModuleDataDefRegistry Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumRegisteredModules
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleDataDefRegistry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ModuleDataDefRegistry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleData FindModuleDataByIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleData FindModuleDataBySystemType(Type systemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleData FindModuleDataBySystemTypeString(string systemTypeString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterModule(ModuleData moduleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterModule(ModuleData moduleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterModule(Type systemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterModule(string systemTypeString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoopThroughAllRegisteredModules(
      ModuleDataDefRegistry.LoopThroughModulesCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetModuleDataDefLookupId(ModuleData moduleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleData FindModuleDataDefByModuleDataLookupId(int moduleDataLookupId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetFormatString(bool multiline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ModuleDataDefRegistry() => throw null;

    public delegate void LoopThroughModulesCallback(ModuleData moduleData, int moduleDataIndex);
  }
}
