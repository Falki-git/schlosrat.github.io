﻿// Decompiled with JetBrains decompiler
// Type: RTG.GizmoSolidMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoSolidMaterial : Singleton<GizmoSolidMaterial>
  {
    private Material _material;

    public Material Material
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float LightIntensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoSolidMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetValuesToSensibleDefaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLit(bool isLit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightDirection(Vector3 lightDir) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightIntensity(float intensity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZWriteEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZTestEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZTestAlways() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZTestLess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullModeBack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullModeFront() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullModeOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPass(int passIndex) => throw null;
  }
}
