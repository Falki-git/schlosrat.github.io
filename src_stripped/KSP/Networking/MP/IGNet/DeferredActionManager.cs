﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.DeferredActionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.IGNet
{
  public class DeferredActionManager
  {
    private List<DeferredActionEntry> _list;

    public int NumEntries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeferredActionManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDeferredAction(DeferredActionCallback callback, object voidObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeferredActionEntry GetNextDeferredActionEntryToProcess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessDeferredActionEntries() => throw null;
  }
}
