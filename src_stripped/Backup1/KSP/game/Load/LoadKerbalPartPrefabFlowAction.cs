﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadKerbalPartPrefabFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  public class LoadKerbalPartPrefabFlowAction : SaveLoadGameFlowActionBase
  {
    private const string EVA_PART_NAME = "eva_kerbal";
    private const string EVA_PART_PREFAB = "eva_kerbal.prefab";
    private const string EVA_ASSEMBLY_NAME = "EVA Kerbal-1";
    private SerializedAssembly _kerbalAssembly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadKerbalPartPrefabFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateKerbalAssemblyFromPrefab(GameObject prefabObject) => throw null;
  }
}
