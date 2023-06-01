﻿// Decompiled with JetBrains decompiler
// Type: RTG.RTCameraBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTCameraBackground : MonoSingleton<RTCameraBackground>
  {
    [SerializeField]
    private CameraBackgroundSettings _bkSettings;
    [SerializeField]
    private List<Camera> _renderIgnoreCameras;
    private Dictionary<Camera, CameraBackgroundSettings> _cameraToBkSettings;

    public CameraBackgroundSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraBkSettings(Camera camera, CameraBackgroundSettings bkSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Camera> GetAllRenderIgnoreCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render_SystemCall(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTCameraBackground() => throw null;
  }
}
