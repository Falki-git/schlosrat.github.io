﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowInstructionCompilationExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class FlowInstructionCompilationExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<FlowInstructionConfig> CompileToInstructionConfigs(
      this ResourceFlowRequestConfig resourceFlowRequestConfig,
      ResourceDefinitionDatabase database,
      double basePriority = 0.0,
      IFlowNode target = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static FlowInstructionConfig _CompileInstructionDefinition(
      ResourceFlowRequestCommandConfig itemConfig,
      ResourceDefinitionData curResource,
      double curUnits,
      double targetUnits,
      IFlowNode target,
      double flowPriority,
      RequestFlowUpdateMode flowUpdateMode,
      double flowMinimumNormalized)
    {
      throw null;
    }
  }
}
