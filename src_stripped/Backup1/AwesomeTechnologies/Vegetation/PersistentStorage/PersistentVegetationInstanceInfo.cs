﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationInstanceInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [Serializable]
  public class PersistentVegetationInstanceInfo
  {
    public string VegetationItemID;
    public int Count;
    public List<SourceCount> SourceCountList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSourceCountList(List<SourceCount> sourceCountList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSourceCount(SourceCount sourceCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SourceCount GetSourceCount(int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationInstanceInfo() => throw null;
  }
}
