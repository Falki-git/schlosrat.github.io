﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtComponentPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public static class SgtComponentPool<T> where T : Component
  {
    private static SgtPoolComponent pool;

    public static int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Add(T entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Add(T element, Action<T> onAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Cache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop(Transform parent, string name, int layer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop(Predicate<T> match) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UpdateComponent(bool allowCreation) => throw null;
  }
}
