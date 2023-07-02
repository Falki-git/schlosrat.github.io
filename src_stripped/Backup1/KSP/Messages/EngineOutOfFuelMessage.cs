﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.EngineOutOfFuelMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Staging/EngineOutOfFuelMessage", false, "Player's active stage engine is out of fuel", "")]
  public class EngineOutOfFuelMessage : StagingMessageBase
  {
    public Guid EnginePartId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineOutOfFuelMessage() => throw null;
  }
}
