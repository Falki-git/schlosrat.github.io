﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.CVar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public abstract class CVar
  {
    public event Action<CVar> onChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected CVar() => throw null;
  }
}
