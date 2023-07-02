﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.MapEnabled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Map/MapEnabled", true, "This value is 1/true if the player is currently in the map, and 0/false if in flight view instead. We need this for double-checking if the player is already in the map in steps where we ask them to go to the map.", "")]
  public class MapEnabled : MapPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool GetValueBool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapEnabled() => throw null;
  }
}
