﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.CameraShift
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (Camera))]
  [ExecuteInEditMode]
  public class CameraShift : MonoBehaviour
  {
    public Vector2 offset;
    private Camera m_camera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetPerspectiveOffset(Camera cam, Vector2 perspectiveOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Matrix4x4 PerspectiveOffCenter(
      float left,
      float right,
      float bottom,
      float top,
      float near,
      float far)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraShift() => throw null;
  }
}
