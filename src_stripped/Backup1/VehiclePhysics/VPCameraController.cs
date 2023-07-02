﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPCameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Camera/Camera Controller")]
  public class VPCameraController : MonoBehaviour
  {
    public VPCameraController.Mode mode;
    public Transform target;
    public KeyCode changeCameraKey;
    public int customCameraIndex;
    public VPCameraController.TimeMode timeMode;
    public float driverCameraFov;
    [FormerlySerializedAs("attachTo")]
    public CameraAttachTo driver;
    public CameraSmoothFollow smoothFollow;
    [FormerlySerializedAs("mouseOrbit")]
    public CameraOrbit orbit;
    public CameraLookAt lookAt;
    public CameraFree free;
    private Transform m_transform;
    private CameraMode[] m_cameraModes;
    private Transform m_currentTarget;
    private VPCameraController.Mode m_prevMode;
    private bool m_forceResetMode;
    private int m_prevCustomCamera;
    private bool m_isInteriorCamera;
    private bool m_isDriverCamera;
    private VPCameraTarget m_targetConfig;
    private Transform m_viewTarget;

    public bool isInteriorCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VehicleBase targetVehicle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NextCameraMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetConfig(VPCameraTarget targetConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPose(Vector3 position, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MonitorTargetChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MonitorCustomCameraChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MonitorCustomCameraKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int InitializeCustomCamera(int cameraIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPCameraController() => throw null;

    public enum Mode
    {
      Driver,
      SmoothFollow,
      Orbit,
      LookAt,
      Free,
    }

    public enum TimeMode
    {
      Standard,
      Unscaled,
      Smooth,
      RefreshRate,
    }
  }
}
