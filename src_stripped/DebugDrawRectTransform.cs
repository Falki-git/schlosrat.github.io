﻿// Decompiled with JetBrains decompiler
// Type: DebugDrawRectTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (RectTransform))]
public class DebugDrawRectTransform : MonoBehaviour
{
  public static bool DrawDebugRects;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugDrawRectTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static DebugDrawRectTransform() => throw null;

  private enum DebugDrawMode
  {
    Box,
    Circle,
  }
}
