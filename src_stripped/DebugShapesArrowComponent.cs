﻿// Decompiled with JetBrains decompiler
// Type: DebugShapesArrowComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Shapes;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugShapesArrowComponent : DebugShapesComponentBase
{
  public float lineLength;
  public float lineWidth;
  public float coneDiameter;
  public ShapeGroup shapeGroup;
  public Cone arrowHead;
  public Shapes.Line arrowLine;
  public Color color;
  public bool invertDirection;
  private Vector3 lineEnd;
  private Vector3 arrowInverse;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugShapesArrowComponent() => throw null;
}
