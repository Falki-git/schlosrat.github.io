﻿// Decompiled with JetBrains decompiler
// Type: TimeOfDayAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimeOfDayAnimation : MonoBehaviour
{
  public Transform target;
  public float dot;
  public Color emissiveColor;
  public Color emissiveTgtColor;
  public string emissiveColorProperty;
  public AnimationCurve emissivesCurve;
  public List<TimeOfDayAnimation.MaterialProperty> emissives;
  private Renderer[] renderers;
  private bool facilityDirty;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateRenderers() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool MaterialPropertiesDirty() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TimeOfDayAnimation() => throw null;

  [Serializable]
  public class MaterialProperty
  {
    public Material material;
    public string propertyName;
    private List<Renderer> instances;
    private int propertyID;
    private MaterialPropertyBlock mpb;

    public bool isDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInstances(Renderer[] renderers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColor(Color c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MaterialProperty() => throw null;
  }
}
