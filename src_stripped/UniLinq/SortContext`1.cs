﻿// Decompiled with JetBrains decompiler
// Type: UniLinq.SortContext`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  internal abstract class SortContext<TElement> : IComparer<int>
  {
    protected SortDirection direction;
    protected SortContext<TElement> child_context;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SortContext(SortDirection direction, SortContext<TElement> child_context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Initialize(TElement[] elements) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract int Compare(int first_index, int second_index) => throw null;
  }
}
