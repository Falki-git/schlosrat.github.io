﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.ChaseCameraRigSolution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.impl
{
  public class ChaseCameraRigSolution : ICameraRigSolution, ICameraShotInGimbal, ICameraShot
  {
    private CameraTweakables _tweakablesDefault;
    private CameraTweakables _tweakablesOverride;
    private UniverseCameraManager _universeCameraManager;
    private IGimbalPositionProvider _gimbalPositionProvider;
    private IDynamicFrameRotationProvider _gimbalRotationProvider;
    private GameInstance _game;
    private MessageCenter _gameMessageCenter;
    private GimbalState _defaultGimbalState;
    private GimbalState _targetGimbalState;
    private GimbalState _sourceGimbalState;
    private bool _lerpToTargetGimbalState;
    private float _gimbalStateInterpolationTimer;
    private float _gimbalStateInterpolationDuration;
    private float _gamepadYaw;
    private float _gamepadPitch;
    private Position _targetGimbalPos;
    private Position _sourceGimbalPos;
    private Rotation _targetGimbalRot;
    private Rotation _sourceGimbalRot;
    private float _gimbalTransformInterpolationTimer;
    private bool _lerpToTargetGimbalTransform;
    private bool warned;

    public ICameraShotInGimbal CameraShot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GimbalState GimbalState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Position CameraPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation CameraRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector CameraForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector CameraUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsOrthographic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double FieldOfView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double OrthographicSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrame GimbalFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position GimbalPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation GimbalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector GimbalAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel GimbalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame AnchorFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private CameraTweakables Tweakables
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChaseCameraRigSolution(string solutionGuid, CameraTweakables cameraTweakables) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnViewControllerFlowFinished(MessageCenterMessage viewControllerMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(GimbalState state, bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraFieldOfView(double fieldOfView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraIsOrthographic(bool isOrthographic) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraOrthographicSize(double orthographicSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraOrbitTarget(Transform newTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetGimbalTransform(
      Position targetPosition,
      Rotation targetRotation,
      bool shouldLerp = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalState(GimbalState state, bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultGimbalState(GimbalState gimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyGimbalState(GimbalStateIncremental change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyGimbalStateIncremental(GimbalStateIncremental change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTweakablesOverride(ICameraTweakablesProvider tweakablesOverride) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCameraContext GetCameraContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateShot(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalTransform(double universeDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAndValidateGimbalState(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraWithGimbalState(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshShot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AnchorToRig(ICameraRigAnchorProvider anchorProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalPositionProvider(IGimbalPositionProvider positionProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalRotationProvider(IDynamicFrameRotationProvider rotationProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraYawGamepad(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPitchGamepad(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightInput(float _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateDefaultGimbalState() => throw null;
  }
}
