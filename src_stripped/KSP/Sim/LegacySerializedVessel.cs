﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.LegacySerializedVessel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using KSP.Sim.State;
using System;
using System.Collections.Generic;

namespace KSP.Sim
{
  [Obsolete("Please use SerializedAssembly instead")]
  public struct LegacySerializedVessel
  {
    public AssemblyDefinition vesselDefinition;
    public StagingState? stagingState;
    public PartOwnerState? partOwnerState;
    public IEnumerable<PartDefinitionContainer> partDefinitions;
  }
}
