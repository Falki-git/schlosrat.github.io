﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.VesselControlState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Sim.Definitions
{
  public enum VesselControlState : byte
  {
    [Description("PartModules/Command/VesselControlState/NoControl")] NoControl,
    [Description("PartModules/Command/VesselControlState/NoCommNet")] NoCommNet,
    [Description("PartModules/Command/VesselControlState/FullControlHibernation")] FullControlHibernation,
    [Description("PartModules/Command/VesselControlState/FullControl")] FullControl,
  }
}
