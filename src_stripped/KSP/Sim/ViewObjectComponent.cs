﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewObjectComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public abstract class ViewObjectComponent : KerbalMonoBehaviour
  {
    protected SimulationObjectView _viewObject;

    public SimulationObjectView ViewObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SyncTo(ObjectComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ViewObjectComponent() => throw null;
  }
}
