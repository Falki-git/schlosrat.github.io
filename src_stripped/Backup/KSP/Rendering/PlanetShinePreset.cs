﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetShinePreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [CreateAssetMenu(fileName = "PlanetShinePreset", menuName = "KSP Lighting/PlanetShinePresets", order = 100)]
  [Serializable]
  public class PlanetShinePreset : ScriptableObject
  {
    public PlanetShinePresetData presetData;

    public static PlanetShinePresetData DefaultPreset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlanetShinePreset() => throw null;
  }
}
