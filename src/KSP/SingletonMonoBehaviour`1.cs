﻿// Decompiled with JetBrains decompiler
// Type: KSP.SingletonMonoBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
  public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
  {
    private static T fetch;

    [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
    public static T Fetch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SingletonMonoBehaviour() => throw null;
  }
}
