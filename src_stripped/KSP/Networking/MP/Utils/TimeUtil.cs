﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.TimeUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public static class TimeUtil
  {
    private static readonly DateTime gUnixStartTime;
    private static long gTicks;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long GetTicks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long GetMS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long ToUnixTimestamp(this DateTime dateTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetTimeZoneOffsetMinutes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTimeZoneString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTimeZoneStringAbbrev() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTimeStringLocal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTimeStringUTC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDateTimeStringUTC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDHMSMSString(long ms, bool useLongFormat, bool includeMilliseconds = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TimeUtil() => throw null;
  }
}
