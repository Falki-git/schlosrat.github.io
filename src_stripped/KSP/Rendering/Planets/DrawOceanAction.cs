﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.DrawOceanAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.Planets
{
  public class DrawOceanAction : ILateUpdate, IPriorityOverride
  {
    public Action OnDrawOceanAction;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawOceanAction(PrevisGameInstance previsGameInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;
  }
}
