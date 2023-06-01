﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.PositionController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class PositionController : MonoBehaviour
  {
    public Transform target;
    public Vector3 position;
    public PositionController.Mode mode;
    public Vector3 targetOffset;
    public bool damped;
    public float damping;
    public bool clamped;
    public Bounds limits;
    public PositionController.OnPositionFinished onPositionFinished;
    private Transform m_trans;
    private Vector3 m_currentPosition;
    private bool m_positioning;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPosition(Vector3 newPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClampPosition(ref Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionController() => throw null;

    public enum Mode
    {
      Free,
      FixedToTarget,
    }

    public delegate void OnPositionFinished();
  }
}
