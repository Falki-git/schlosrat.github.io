﻿// Decompiled with JetBrains decompiler
// Type: GITester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class GITester : MonoBehaviour
{
  [Header("Ambient")]
  public bool ambientEnabled;
  public Color ambientColor;
  [Header("Directional")]
  public bool directionalEnabled;
  public Color directionalColor;
  public Vector3 dir;
  private SphericalHarmonicsL2 _sh;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GITester() => throw null;
}
