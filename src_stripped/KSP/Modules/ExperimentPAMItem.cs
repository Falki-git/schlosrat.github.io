﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ExperimentPAMItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using System;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public struct ExperimentPAMItem
  {
    [SerializeField]
    public ModuleAction RunExperiment;
    [SerializeField]
    public ModuleProperty<bool> CancelExperiment;
    [SerializeField]
    public ModuleProperty<bool> PauseExperiment;
    [SerializeField]
    public ModuleProperty<bool> ResumeExperiment;
    [SerializeField]
    public ModuleProperty<string> Status;
  }
}