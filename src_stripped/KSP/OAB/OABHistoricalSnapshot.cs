﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABHistoricalSnapshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class OABHistoricalSnapshot
  {
    public static readonly string CURRENT_SNAPSHOT_VERSION;
    public OABSavedWorkspaceMetaInfo Metadata;
    public OABActionType ActionType;
    public OABOrientation oabOrientation;
    public List<OABPlacedAssembly> Assemblies;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABHistoricalSnapshot(
      OABActionType type,
      List<OABPlacedAssembly> data,
      int numberofparts,
      int numberofstages,
      float mass,
      OABOrientation oabOrientation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OABHistoricalSnapshot() => throw null;
  }
}
