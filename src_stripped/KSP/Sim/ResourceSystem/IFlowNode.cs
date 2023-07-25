﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IFlowNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;

namespace KSP.Sim.ResourceSystem
{
  public interface IFlowNode
  {
    string Name { get; }

    IResourceContainer[] Containers { get; }

    bool IsCompound { get; }

    IGGuid GlobalId { get; }
  }
}
