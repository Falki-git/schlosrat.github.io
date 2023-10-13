﻿// Decompiled with JetBrains decompiler
// Type: Streak
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
[RequireComponent(typeof (Camera))]
public class Streak : MonoBehaviour
{
  [Range(0.0f, 5f)]
  [SerializeField]
  private float _threshold;
  [Range(0.0f, 1f)]
  [SerializeField]
  private float _stretch;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float _intensity;
  [SerializeField]
  [ColorUsage(false)]
  private Color _tint;
  [Header("Curve day/night settings")]
  public bool enableIntensityDayNight;
  public bool enableStretchDayNight;
  public bool enableThreshholdDayNight;
  public FloatCurve intensityDayNight;
  public FloatCurve stretchDayNight;
  public FloatCurve thresholdDayNight;
  [SerializeField]
  private Shader _shader;
  private Material _material;
  private Stack<RenderTexture> _mipStack;
  private Dictionary<Camera, CommandBuffer> m_Cameras;
  private CommandBuffer m_StreakBuffer;
  private int _globalTimeHash;

  public float threshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float stretch
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float intensity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Color tint
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private RenderTexture GetTempRT(int width, int height) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Cleanup() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnRenderImage(RenderTexture source, RenderTexture destination) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Streak() => throw null;
}
