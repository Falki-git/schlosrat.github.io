﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.UserLutModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class UserLutModel : PostProcessingModel
  {
    [SerializeField]
    private UserLutModel.Settings m_Settings;

    public UserLutModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UserLutModel() => throw null;

    [Serializable]
    public struct Settings
    {
      [Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
      public Texture2D lut;
      [Tooltip("Blending factor.")]
      [Range(0.0f, 1f)]
      public float contribution;

      public static UserLutModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
