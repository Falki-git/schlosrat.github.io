﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.CameraMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class CameraMode
  {
    public KeyCode hotKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetTargetConfig(VPCameraTarget targetConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize(Transform self) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnable(Transform self) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset(Transform self, Transform target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(Transform self, Transform target, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetPose(Transform self, Vector3 position, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetDriverFov(Transform self, float fieldOfView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDisable(Transform self) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetInputForAxis(string axisName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraMode() => throw null;
  }
}
