﻿// Decompiled with JetBrains decompiler
// Type: UtilScripts.PoolsStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UtilScripts
{
  public class PoolsStatus
  {
    public static readonly Dictionary<Type, PoolsStatus> poolsInfo;
    public int maxSize;
    public int allocated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PoolsStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PoolsStatus() => throw null;
  }
}
