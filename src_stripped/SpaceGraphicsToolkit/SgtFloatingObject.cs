﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Object")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtFloatingObject")]
  [ExecuteInEditMode]
  public class SgtFloatingObject : MonoBehaviour
  {
    public UnityEvent OnSnap;
    public Action<double> OnDistance;
    [SerializeField]
    private SgtFloatingPoint point;
    [SerializeField]
    private Vector3 expectedPosition;
    [SerializeField]
    private bool expectedPositionSet;

    public SgtFloatingPoint Point
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckForPositionChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraSnap(SgtFloatingCamera floatingCamera, Vector3 delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePositionNow(SgtFloatingCamera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtFloatingObject() => throw null;
  }
}
