﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DitheringModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class DitheringModel : PostProcessingModel
  {
    [SerializeField]
    private DitheringModel.Settings m_Settings;

    public DitheringModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DitheringModel() => throw null;

    [Serializable]
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct Settings
    {
      public static DitheringModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
