﻿// Decompiled with JetBrains decompiler
// Type: I2.Loc.BaseSpecializationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class BaseSpecializationManager
  {
    public string[] mSpecializations;
    public Dictionary<string, string> mSpecializationsFallbacks;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void InitializeSpecializations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetCurrentSpecialization() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetFallbackSpecialization(string specialization) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseSpecializationManager() => throw null;
  }
}
