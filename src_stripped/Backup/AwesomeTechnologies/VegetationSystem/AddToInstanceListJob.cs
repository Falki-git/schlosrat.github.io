﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.AddToInstanceListJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile]
  public struct AddToInstanceListJob : IJob
  {
    [DeallocateOnJobCompletion]
    public NativeArray<VegetationInstance> SourceInstanceArray;
    public NativeList<VegetationInstance> TargetInstanceList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
