﻿// Decompiled with JetBrains decompiler
// Type: ApplyGIProbe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class ApplyGIProbe : MonoBehaviour
{
  public bool enableCache;
  public Color ambientColor;
  public Color directionalColor;
  public Vector3 direction;
  public float directionIntensity;
  private Renderer _renderer;
  private MaterialPropertyBlock _propBlock;
  private SphericalHarmonicsL2 _shCache;
  private List<SphericalHarmonicsL2> _shCacheList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ApplyGIProbe() => throw null;
}
