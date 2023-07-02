﻿// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXInstanceAggregator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  public class FXInstanceAggregator
  {
    public Dictionary<string, AggregationSet> InstanceSets;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextualFxSystem CFXSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAggregatable(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSetKey(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAddNode(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectEvents(ref List<SpatialBubbleDatabaseNode> nodes, bool all) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXInstanceAggregator() => throw null;
  }
}
