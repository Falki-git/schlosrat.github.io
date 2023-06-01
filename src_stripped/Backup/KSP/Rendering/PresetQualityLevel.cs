﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PresetQualityLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [CreateAssetMenu(fileName = "New Quality Preset", menuName = "KSP/Quality Preset")]
  public class PresetQualityLevel : ScriptableObject
  {
    [SerializeField]
    public bool vSync;
    [SerializeField]
    public QualityLevel antiAliasing;
    [SerializeField]
    public bool anistropicFiltering;
    [SerializeField]
    public TextureQualityLevel textureQuality;
    [SerializeField]
    public QualityLevel shadowQuality;
    [SerializeField]
    public QualityLevel shadowResolution;
    [SerializeField]
    public bool enableCloud;
    [SerializeField]
    public QualityLevel cloudQuality;
    [SerializeField]
    public QualityLevel waterQuality;
    [SerializeField]
    public QualityLevel ringFXQuality;
    [SerializeField]
    public bool reflectionsEnabled;
    [SerializeField]
    public QualityLevel refelectionsQuality;
    [SerializeField]
    public QualityLevel envPropDensity;
    [SerializeField]
    public QualityLevel envPropDrawDistance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PresetQualityLevel() => throw null;
  }
}
