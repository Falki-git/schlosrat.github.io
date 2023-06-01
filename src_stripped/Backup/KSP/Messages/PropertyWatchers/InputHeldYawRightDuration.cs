﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.InputHeldYawRightDuration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Flight/InputHeldYawRightDuration", true, "Returns a double value representing how many seconds the player has been holding an input for yawing right, value resets to 0 if the input is released.", "")]
  public class InputHeldYawRightDuration : FlightPropertyWatcher
  {
    private double _startedHoldingInputTime;
    private bool _hasTimerStarted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputHeldYawRightDuration() => throw null;
  }
}
