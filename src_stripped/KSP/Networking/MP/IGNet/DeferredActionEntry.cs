﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.DeferredActionEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.IGNet
{
  public class DeferredActionEntry
  {
    public const DeferredActionCallback DEFAULT_CALLBACK = null;
    public const object DEFAULT_OBJECT = null;
    private DeferredActionCallback _callback;
    private object _object;

    public DeferredActionCallback Callback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCallback(DeferredActionCallback callback) => throw null;

    public object Object
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObject(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeferredActionEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeferredActionEntry(DeferredActionCallback callback, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllDataValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(DeferredActionCallback callback, object obj) => throw null;
  }
}
