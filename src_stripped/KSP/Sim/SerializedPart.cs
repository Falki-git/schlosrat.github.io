﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedPart
  {
    [Obsolete("Use PartGuid instead")]
    public string partGuid;
    public IGGuid PartGuid;
    public string partName;
    public PartState partState;
    public List<SerializedPartModule> PartModulesState;
    [Obsolete("This field is the old version where there was no hierarchy of PartModule->DataModules - pre v0.3 saves")]
    public List<SerializedModuleData> ModulesState;
    public List<SerializedLegacyModuleData> LegacyModulesState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConvertModulesToPartModule() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CombinePartModulesState(Type master, Type child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPart ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPart UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPart() => throw null;
  }
}
