﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public class ModuleAction : DelegateAction, IModuleAction, IAction, IModuleDataContext
  {
    public string ContextKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool ActionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetContextKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleAction(Delegate action) => throw null;
  }
}