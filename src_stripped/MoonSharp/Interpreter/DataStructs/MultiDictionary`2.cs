﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.MultiDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.DataStructs
{
  internal class MultiDictionary<K, V>
  {
    private Dictionary<K, List<V>> m_Map;
    private V[] m_DefaultRet;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiDictionary(IEqualityComparer<K> eqComparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Add(K key, V value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<V> Find(K key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsKey(K key) => throw null;

    public IEnumerable<K> Keys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(K key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveValue(K key, V value) => throw null;
  }
}
