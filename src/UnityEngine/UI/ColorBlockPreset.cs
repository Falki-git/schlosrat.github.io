﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ColorBlockPreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [CreateAssetMenu(fileName = "ColorBlockPreset", menuName = "UI Extended/ColorBlockPreset", order = 100)]
  [Serializable]
  public class ColorBlockPreset : ScriptableObject
  {
    public ColorBlock colors;

    public static ColorBlock DefaultColors
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static ColorBlock DefaultColorsOn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static ColorBlock DefaultColorsOff
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorBlockPreset() => throw null;
  }
}
