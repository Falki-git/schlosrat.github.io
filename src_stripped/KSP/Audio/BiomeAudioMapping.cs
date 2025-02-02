﻿// Decompiled with JetBrains decompiler
// Type: KSP.Audio.BiomeAudioMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  [CreateAssetMenu(fileName = "BiomeAudioMapping", menuName = "ScriptableObjects/BiomeAudioMapping")]
  public class BiomeAudioMapping : ScriptableObject
  {
    [SerializeField]
    public List<BiomeSwitchPair> BiomeTypeToAudioPairs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomeAudioMapping() => throw null;
  }
}
