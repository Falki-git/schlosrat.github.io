﻿// Decompiled with JetBrains decompiler
// Type: PieChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PieChart : MonoBehaviour
{
  public Material material;
  public int resolution;
  public float radius;
  public float depth;
  public List<PieChart.Slice> slices;
  private List<PieChartSlice> sliceObjects;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSlices(List<PieChart.Slice> slices) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateChart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateEnds(
    float angle,
    float endAngle,
    float deltaAngle,
    List<Vector3> verts,
    List<int> tris)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateTopBottom(
    float angle,
    float endAngle,
    float deltaAngle,
    List<Vector3> verts,
    List<int> tris)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateEdges(
    float angle,
    float endAngle,
    float deltaAngle,
    List<Vector3> verts,
    List<int> tris)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Vector3 CreateDirection(float angle, float height) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PieChart() => throw null;

  public delegate void OnInputDelegate(PieChart.Slice slice);

  [Serializable]
  public class Slice
  {
    public string name;
    public int id;
    public float fraction;
    public Color color;
    public object Data;
    [HideInInspector]
    public PieChartSlice slice;
    [HideInInspector]
    public Mesh mesh;
    [HideInInspector]
    public Material material;
    [HideInInspector]
    public PieChart.OnInputDelegate onOver;
    [HideInInspector]
    public PieChart.OnInputDelegate onExit;
    [HideInInspector]
    public PieChart.OnInputDelegate onTap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOnOver(PieChart.OnInputDelegate onOver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOnOver(PieChart.OnInputDelegate onOver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOnExit(PieChart.OnInputDelegate onExit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOnExit(PieChart.OnInputDelegate onExit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOnTap(PieChart.OnInputDelegate onTap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOnTap(PieChart.OnInputDelegate onTap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Slice(string name, float fraction, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Slice(string name, int id, float fraction, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Slice(int id, float fraction, Color color) => throw null;
  }
}
