﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationStudio.QualityManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationStudio
{
  [Serializable]
  public class QualityManager : MonoBehaviour
  {
    [SerializeField]
    public List<VegetationSystemProDensitySetting> DensityQualityLevelList;
    [SerializeField]
    public List<VegetationSystemProDrawDistanceSetting> DrawDistanceQualityLevelList;
    [SerializeField]
    private VegetationSystemProDensitySetting activeDensitySettings;
    [SerializeField]
    private VegetationSystemProDrawDistanceSetting activeDrawDistanceSettings;
    public VegetationSystemPro VegetationSystemPro;
    public bool MultiPlayer;
    public int QualityLevelIndex;
    private bool _initialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDensityQualityLevel(int index, bool forceRefresh = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDrawDistanceQualityLevel(int index, bool forceRefresh = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetQualityLevel(bool forceRefresh = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetDrawDistanceMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetDensityMultiplier(VegetationType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QualityManager() => throw null;
  }
}
