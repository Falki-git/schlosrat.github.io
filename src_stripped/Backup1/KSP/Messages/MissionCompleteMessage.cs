﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MissionCompleteMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Mission/MissionCompleteMessage", true, "Mission Completed & Award(s) Granted (if applicable).", "")]
  public class MissionCompleteMessage : MissionMessageBase
  {
    public MissionData MissionData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionCompleteMessage() => throw null;
  }
}
