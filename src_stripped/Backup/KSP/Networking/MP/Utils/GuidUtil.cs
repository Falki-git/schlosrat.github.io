﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.GuidUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public static class GuidUtil
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Guid GenerateNewGuid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateNewGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Guid GenerateZeroGuid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateZeroGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string MakeConfigureString(Guid guid, uint seed, uint bias, int counter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ExtractvaluesFromConfigureString(
      string configureString,
      out Guid guidOut,
      out uint seedOut,
      out uint biasOut,
      out int counterOut)
    {
      throw null;
    }
  }
}
