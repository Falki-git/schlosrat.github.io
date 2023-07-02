﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.PolygonUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public class PolygonUtility
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AlignPointsWithTerrain(
      List<Vector3> pointList,
      bool closePolygon,
      LayerMask groundLayerMask)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> InflatePolygon(
      List<Vector3> pointList,
      double offset,
      bool closedPolygon)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> DouglasPeucker(
      List<Vector2> points,
      int startIndex,
      int lastIndex,
      float epsilon)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float PointLineDistance(Vector2 point, Vector2 start, Vector2 end) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Cross(Vector2 o, Vector2 a, Vector2 b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> GetConvexHull(List<Vector2> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> DouglasPeuckerReduction(List<Vector2> pointList, float tolerance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DouglasPeuckerReduction(
      List<Vector2> points,
      int firstPoint,
      int lastPoint,
      float tolerance,
      ref List<int> pointIndexsToKeep)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float PerpendicularDistance(Vector2 p1, Vector2 p2, Vector2 p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolygonUtility() => throw null;
  }
}
