﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.TerrainSourceRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public struct TerrainSourceRule
  {
    public bool UseTerrainSourceID1;
    public bool UseTerrainSourceID2;
    public bool UseTerrainSourceID3;
    public bool UseTerrainSourceID4;
    public bool UseTerrainSourceID5;
    public bool UseTerrainSourceID6;
    public bool UseTerrainSourceID7;
    public bool UseTerrainSourceID8;

    public bool this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUseTerrainSource(int index, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UseTerrainSource(int index) => throw null;
  }
}
