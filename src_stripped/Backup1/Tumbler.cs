﻿// Decompiled with JetBrains decompiler
// Type: Tumbler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class Tumbler : MonoBehaviour
{
  public float sharpness;
  private double tgtRot;
  private double currRot;
  private double N;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void tumbleTo(double n, Tumbler.TumbleDirection tumble) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Tumbler() => throw null;

  public enum TumbleDirection
  {
    Up,
    Down,
  }
}
