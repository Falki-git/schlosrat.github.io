﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVPartExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.DeltaV
{
  public static class DeltaVPartExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ContainsPart(this List<DeltaVPartInfo> list, IDeltaVPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DeltaVPartInfo Get(this List<DeltaVPartInfo> list, IDeltaVPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DeltaVPartInfo Get(this List<DeltaVPartInfo> list, IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<IDeltaVPart> PartsInStage(this List<DeltaVPartInfo> list, int stage) => throw null;
  }
}
