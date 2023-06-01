﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AntialiasingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class AntialiasingModel : PostProcessingModel
  {
    [SerializeField]
    private AntialiasingModel.Settings m_Settings;

    public AntialiasingModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AntialiasingModel() => throw null;

    public enum Method
    {
      Fxaa,
      Taa,
    }

    public enum FxaaPreset
    {
      ExtremePerformance,
      Performance,
      Default,
      Quality,
      ExtremeQuality,
    }

    [Serializable]
    public struct FxaaQualitySettings
    {
      [Range(0.0f, 1f)]
      [Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
      public float subpixelAliasingRemovalAmount;
      [Range(0.063f, 0.333f)]
      [Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
      public float edgeDetectionThreshold;
      [Range(0.0f, 0.0833f)]
      [Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
      public float minimumRequiredLuminance;
      public static AntialiasingModel.FxaaQualitySettings[] presets;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static FxaaQualitySettings() => throw null;
    }

    [Serializable]
    public struct FxaaConsoleSettings
    {
      [Range(0.33f, 0.5f)]
      [Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
      public float subpixelSpreadAmount;
      [Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
      [Range(2f, 8f)]
      public float edgeSharpnessAmount;
      [Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
      [Range(0.125f, 0.25f)]
      public float edgeDetectionThreshold;
      [Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
      [Range(0.04f, 0.06f)]
      public float minimumRequiredLuminance;
      public static AntialiasingModel.FxaaConsoleSettings[] presets;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static FxaaConsoleSettings() => throw null;
    }

    [Serializable]
    public struct FxaaSettings
    {
      public AntialiasingModel.FxaaPreset preset;

      public static AntialiasingModel.FxaaSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct TaaSettings
    {
      [Range(0.1f, 1f)]
      [Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
      public float jitterSpread;
      [Range(0.0f, 3f)]
      [Tooltip("Controls the amount of sharpening applied to the color buffer.")]
      public float sharpen;
      [Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
      [Range(0.0f, 0.99f)]
      public float stationaryBlending;
      [Range(0.0f, 0.99f)]
      [Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
      public float motionBlending;

      public static AntialiasingModel.TaaSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct Settings
    {
      public AntialiasingModel.Method method;
      public AntialiasingModel.FxaaSettings fxaaSettings;
      public AntialiasingModel.TaaSettings taaSettings;

      public static AntialiasingModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
