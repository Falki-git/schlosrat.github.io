﻿// Decompiled with JetBrains decompiler
// Type: RTG.GizmoScalerHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoScalerHandle
  {
    private int _handleId;
    private List<int> _scaleDragAxisIndices;

    public int HandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<int> ScaleDragAxisIndices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex) => throw null;
  }
}
