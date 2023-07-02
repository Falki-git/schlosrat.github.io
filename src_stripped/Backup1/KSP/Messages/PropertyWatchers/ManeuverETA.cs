﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.ManeuverETA
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Maneuver/NormalizedManeuverTime", true, "Time to maneuver in seconds. Negative going to maneuver. Positive if past Maneuver. 9999 ", "")]
  public class ManeuverETA : ManeuverPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverETA() => throw null;
  }
}
