﻿// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRotationArc2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoRotationArc2D
  {
    private ArcShape2D _arc;
    private GizmoRotationArc2D.ArcType _type;
    private PolygonShape2D _projectionPoly;
    private int _numProjectedPoints;

    public float RotationAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoRotationArc2D.ArcType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PolygonShape2D ProjectionPoly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumProjectedPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetArcData(Vector2 arcOrigin, Vector2 arcStart, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(GizmoRotationArc2DLookAndFeel lookAndFeel, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoRotationArc2D() => throw null;

    public enum ArcType
    {
      Standard,
      PolyProjected,
    }
  }
}
