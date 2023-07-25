﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AmbientOcclusionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class AmbientOcclusionModel : PostProcessingModel
  {
    [SerializeField]
    private AmbientOcclusionModel.Settings m_Settings;

    public AmbientOcclusionModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmbientOcclusionModel() => throw null;

    public enum SampleCount
    {
      Lowest = 3,
      Low = 6,
      Medium = 10, // 0x0000000A
      High = 16, // 0x00000010
    }

    [Serializable]
    public struct Settings
    {
      [Tooltip("Degree of darkness produced by the effect.")]
      [Range(0.0f, 4f)]
      public float intensity;
      [Min(0.0001f)]
      [Tooltip("Radius of sample points, which affects extent of darkened areas.")]
      public float radius;
      [Tooltip("Number of sample points, which affects quality and performance.")]
      public AmbientOcclusionModel.SampleCount sampleCount;
      [Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
      public bool downsampling;
      [Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
      public bool forceForwardCompatibility;
      [Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
      public bool ambientOnly;
      [Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
      public bool highPrecision;

      public static AmbientOcclusionModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
