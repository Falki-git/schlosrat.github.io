﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationRenderSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class VegetationRenderSettings
  {
    public bool DisableInstancedIndirectWindows;
    public bool DisableInstncedIndirectOsx;
    public bool DisableInstancedIndirectLinux;
    public bool DisableInstancedIndirectIos;
    public bool DisableInstancedIndirectAndroid;
    public bool DisableInstancedIndirectTvOs;
    public bool DisableInstancedIndirectXboxOne;
    public bool DisableInstancedIndirectPs4;
    public bool DisableInstancedIndirectWsa;
    public bool EnableInstancedRenderingLayers;
    public int RenderingLayerMask;
    public float CrossFadeDistance;
    public bool ShowLODDebug;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UseInstancedIndirect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationRenderSettings() => throw null;
  }
}
