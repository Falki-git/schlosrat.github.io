﻿// Decompiled with JetBrains decompiler
// Type: TextureScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class TextureScale
{
  private static Color[] texColors;
  private static Color[] newColors;
  private static int w;
  private static float ratioX;
  private static float ratioY;
  private static int w2;
  private static int finishCount;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Point(Texture2D tex, int newWidth, int newHeight) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Bilinear(Texture2D tex, int newWidth, int newHeight) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void Scale(Texture2D tex, int newWidth, int newHeight, bool useBilinear) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void BilinearScale(int end) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void PointScale(int end) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Color ColorLerpUnclamped(Color c1, Color c2, float value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TextureScale() => throw null;
}
