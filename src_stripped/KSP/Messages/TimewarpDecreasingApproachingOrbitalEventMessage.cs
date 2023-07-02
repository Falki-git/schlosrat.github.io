﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.TimewarpDecreasingApproachingOrbitalEventMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/TimewarpDecreasingApproachingOrbitalEventMessage", true, "Player is approaching the end of the burn and decreasing time warp.", "")]
  public class TimewarpDecreasingApproachingOrbitalEventMessage : MessageCenterMessage
  {
    public PatchTransitionType PatchEndTransition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimewarpDecreasingApproachingOrbitalEventMessage() => throw null;
  }
}
