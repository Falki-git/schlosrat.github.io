﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IListEqualityComparerExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class IListEqualityComparerExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IList<T> list, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IList<T> list, T item, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IList<T> list, T item, int index, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IList<T> list, T item, IEqualityComparer<T> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(
      this IList<T> list,
      T item,
      int index,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(
      this IList<T> list,
      T item,
      int index,
      int count,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Remove<T>(this List<T> list, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Remove<T>(this List<T> list, T item, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Remove<T>(this List<T> list, T item, int index, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Remove<T>(this List<T> list, T item, IEqualityComparer<T> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Remove<T>(
      this List<T> list,
      T item,
      int index,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Remove<T>(
      this List<T> list,
      T item,
      int index,
      int count,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static int ExtendedIListIndexOf<T>(
      IList<T> list,
      T item,
      int index,
      int count,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static bool ExtendedIListRemove<T>(
      IList<T> list,
      T item,
      int index,
      int count,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }
  }
}
