﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.GenericFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Flow
{
  public class GenericFlowAction : FlowAction
  {
    private Action<Action, Action<string>> _work;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GenericFlowAction(string name, Action<Action, Action<string>> work) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
