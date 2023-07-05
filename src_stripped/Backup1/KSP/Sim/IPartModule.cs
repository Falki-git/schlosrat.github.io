﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPartModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IPartModule
  {
    ITransformModel transform { get; }

    VesselBehavior vessel { get; }

    PartBehavior part { get; set; }

    ISimulationObjectView simulationObject { get; set; }

    bool stagingEnabled { get; }

    bool moduleIsEnabled { get; }

    ModuleAction executedAction { get; set; }

    void Init();

    void OnActive();

    string GetModuleDisplayName();

    string GetInfo();

    bool IsStageable();
  }
}