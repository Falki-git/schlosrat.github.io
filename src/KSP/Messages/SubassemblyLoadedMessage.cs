﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SubassemblyLoadedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/SubassemblyLoadedMessage", true, "Player has loaded a subassembly", "Currently both this and VesselLoadedMessages are fired from the same code path")]
  public class SubassemblyLoadedMessage : OABMessageBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubassemblyLoadedMessage() => throw null;
  }
}
