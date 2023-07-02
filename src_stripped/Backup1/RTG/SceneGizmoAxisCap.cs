﻿// Decompiled with JetBrains decompiler
// Type: RTG.SceneGizmoAxisCap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SceneGizmoAxisCap : SceneGizmoCap
  {
    private AxisDescriptor _axisDesc;
    private BoxFace _midAxisBoxFace;
    private GizmoTransform _zoomFactorTransform;
    private ColorRef _color;
    private ColorTransition _colorTransition;
    private Texture2D _labelTexture;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneGizmoAxisCap(SceneGizmo sceneGizmo, int id, AxisDescriptor gizmoAxisDesc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHoverPermission() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransform(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandlePicked(Gizmo gizmo, int handleId) => throw null;
  }
}
