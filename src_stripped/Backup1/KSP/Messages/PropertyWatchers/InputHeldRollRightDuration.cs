﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.InputHeldRollRightDuration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Flight/InputHeldRollRightDuration", true, "Returns a double value representing how many seconds the player has been holding an input for rolling right (clockwise), value resets to 0 if the input is released.", "")]
  public class InputHeldRollRightDuration : FlightPropertyWatcher
  {
    private double _startedHoldingInputTime;
    private bool _hasTimerStarted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputHeldRollRightDuration() => throw null;
  }
}