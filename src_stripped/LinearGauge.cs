﻿// Decompiled with JetBrains decompiler
// Type: LinearGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class LinearGauge : MonoBehaviour
{
  public Vector3 minPos;
  public Vector3 maxPos;
  public float maxValue;
  public float minValue;
  public float responsiveness;
  public float logarithmic;
  public float exponent;
  public GaugeLEDRange[] ledRanges;
  public Transform pointer;
  public LED led;
  private float rawValue;
  private float currValue;
  private float tgtValue;
  private Vector3 tgtPos;
  private int currentRange;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setValue(double val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setValue(float val) => throw null;

  public float Value
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void startSound(bool start) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LinearGauge() => throw null;
}
