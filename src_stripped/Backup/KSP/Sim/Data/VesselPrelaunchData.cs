﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Data.VesselPrelaunchData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Data
{
  public class VesselPrelaunchData
  {
    public BoundingSphere VesselBoundingSphere;
    public int FirstStageWithAnEngine;
    public List<VesselPrelaunchData.EngineStageData> EngineStageDataList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselPrelaunchData() => throw null;

    public class EngineStageData
    {
      public int Count;
      public List<EngineType> FuelTypes;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineStageData(int c, List<EngineType> ft) => throw null;
    }
  }
}
