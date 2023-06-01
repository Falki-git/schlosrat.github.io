﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ObjectUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EdyCommonTools
{
  public static class ObjectUtility
  {
    private static Dictionary<Type, Delegate> _cachedIL;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T CloneObject<T>(T source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T CloneObjectFast<T>(T myObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyObjectOverwrite<T>(T source, ref T target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] GetBytesFromStruct<T>(T str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetStructFromBytes<T>(byte[] arr) where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddSorted<T>(List<T> list, T item) where T : IComparable<T> => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ArraysEqual<T>(T[] a1, T[] a2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectUtility() => throw null;

    public delegate TResult Func<T1, TResult>(T1 arg1);
  }
}
