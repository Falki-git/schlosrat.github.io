﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.CTIWindController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  public class CTIWindController : IWindController
  {
    private WindControllerSettings _windControllerSettings;
    public float WindSpeed;
    private readonly int _terrainLODWind;

    public string WindControlerID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public WindControllerSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CTIWindController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindControllerSettings CreateDefaultSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWind(WindZone windZone, float windSpeedFactor) => throw null;
  }
}
