﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.StringBuilderPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Networking.MP.Utils
{
  public class StringBuilderPool
  {
    private const int INITIAL_AVAILABLE_COUNT = 16;
    private static object gLockObject;
    private static Pool<StringBuilder> gPool;
    private static Bootstrap gBootstrap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static StringBuilder Acquire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Pool<StringBuilder>.ReturnableHandle AcquireHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Return(ref StringBuilder stringBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Flush() => throw null;

    public static int AvailableCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringBuilderPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static StringBuilderPool() => throw null;
  }
}
