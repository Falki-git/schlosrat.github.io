﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtEase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  public static class SgtEase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Evaluate(SgtEase.Type ease, float t) => throw null;

    public enum Type
    {
      Linear,
      Smoothstep,
      Sinusoidial,
      Quadratic,
      Circular,
      Cubic,
      Quartic,
      Quintic,
      Exponential,
    }
  }
}
