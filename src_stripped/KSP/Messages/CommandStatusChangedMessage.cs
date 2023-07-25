﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CommandStatusChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Parts/CommandStatusChanged", true, "The command status has changed", "")]
  public class CommandStatusChangedMessage : PartModuleMessageBase
  {
    public CommandControlState NewState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CommandStatusChangedMessage() => throw null;
  }
}
