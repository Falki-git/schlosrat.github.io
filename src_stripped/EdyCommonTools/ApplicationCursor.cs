﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ApplicationCursor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class ApplicationCursor : MonoBehaviour
  {
    [Header("On Enable")]
    public bool showCursor;
    public bool lockCursor;
    public bool dontChangeInEditor;
    [Header("On Update")]
    public bool autoHide;
    public float autoHideTimeout;
    public float speedThreshold;
    public GameObject[] skipIfActive;
    [Header("On Disable")]
    public bool restoreHiddenCursor;
    private Vector3 m_lastMousePosition;
    private float m_lastMovementTime;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ApplicationCursor() => throw null;
  }
}
