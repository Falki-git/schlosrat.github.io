﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.WaypointAddedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Mission/WaypointAdded", true, "A waypoint has been added", "")]
  public class WaypointAddedMessage : MissionMessageBase
  {
    public IGGuid Guid;
    public WaypointComponent Waypoint;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaypointAddedMessage() => throw null;
  }
}
