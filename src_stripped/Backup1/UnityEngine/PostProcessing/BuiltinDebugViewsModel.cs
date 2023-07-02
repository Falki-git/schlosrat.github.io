﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BuiltinDebugViewsModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class BuiltinDebugViewsModel : PostProcessingModel
  {
    [SerializeField]
    private BuiltinDebugViewsModel.Settings m_Settings;

    public BuiltinDebugViewsModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool willInterrupt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsModeActive(BuiltinDebugViewsModel.Mode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BuiltinDebugViewsModel() => throw null;

    [Serializable]
    public struct DepthSettings
    {
      [Range(0.0f, 1f)]
      [Tooltip("Scales the camera far plane before displaying the depth map.")]
      public float scale;

      public static BuiltinDebugViewsModel.DepthSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct MotionVectorsSettings
    {
      [Range(0.0f, 1f)]
      [Tooltip("Opacity of the source render.")]
      public float sourceOpacity;
      [Range(0.0f, 1f)]
      [Tooltip("Opacity of the per-pixel motion vector colors.")]
      public float motionImageOpacity;
      [Min(0.0f)]
      [Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
      public float motionImageAmplitude;
      [Tooltip("Opacity for the motion vector arrows.")]
      [Range(0.0f, 1f)]
      public float motionVectorsOpacity;
      [Range(8f, 64f)]
      [Tooltip("The arrow density on screen.")]
      public int motionVectorsResolution;
      [Tooltip("Tweaks the arrows length.")]
      [Min(0.0f)]
      public float motionVectorsAmplitude;

      public static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    public enum Mode
    {
      None,
      Depth,
      Normals,
      MotionVectors,
      AmbientOcclusion,
      EyeAdaptation,
      FocusPlane,
      PreGradingLog,
      LogLut,
      UserLut,
    }

    [Serializable]
    public struct Settings
    {
      public BuiltinDebugViewsModel.Mode mode;
      public BuiltinDebugViewsModel.DepthSettings depth;
      public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;

      public static BuiltinDebugViewsModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
