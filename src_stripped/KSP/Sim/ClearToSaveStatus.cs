﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ClearToSaveStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim
{
  public enum ClearToSaveStatus
  {
    CLEAR,
    NOT_IN_ATMOSPHERE,
    NOT_UNDER_ACCELERATION,
    NOT_WHILE_MOVING_OVER_SURFACE,
    NOT_WHILE_ABOUT_TO_CRASH,
    NOT_WHILE_ON_A_LADDER,
    NOT_WHILE_THROTTLED_UP,
    ORBIT_EVENT_IMMINENT,
  }
}
