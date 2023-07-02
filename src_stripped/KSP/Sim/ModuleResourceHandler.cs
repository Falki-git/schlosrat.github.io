﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ModuleResourceHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class ModuleResourceHandler
  {
    private TimeWarp timeWarp;
    public List<ModuleResource> inputResources;
    public List<ModuleResource> outputResources;
    public bool moduleResourceBasedPrimaryIsInput;
    public IPartModule partModule;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAwake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAverageInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleResourceHandler() => throw null;
  }
}
