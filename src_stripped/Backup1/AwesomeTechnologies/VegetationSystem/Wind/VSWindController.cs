﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.VSWindController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  public class VSWindController : IWindController
  {
    private WindControllerSettings _windControllerSettings;
    public Texture2D WindWaveTexture;
    public float WindWaveSize;
    public float WindSpeed;
    private readonly int _awDir;
    private readonly int _awWavesTex;

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
    public VSWindController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindControllerSettings CreateDefaultSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWind(WindZone windZone, float windSpeedFactor) => throw null;
  }
}
