﻿// Decompiled with JetBrains decompiler
// Type: StreakBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StreakBase
{
  private static StreakBase m_Instance;
  internal List<StreakObject> streakRenderers;

  public static StreakBase instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnAddStreakObject(StreakObject r) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnRemoveStreakObject(StreakObject r) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public StreakBase() => throw null;
}
