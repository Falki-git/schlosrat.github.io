﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SimulationObjectDefinitionContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;

namespace KSP.Sim.Definitions
{
  public struct SimulationObjectDefinitionContainer
  {
    public SimulationObjectDefinition? definition;
    public Dictionary<Type, object> componentDefinitions;
  }
}
