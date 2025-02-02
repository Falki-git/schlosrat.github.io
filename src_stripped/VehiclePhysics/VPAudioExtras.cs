﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAudioExtras
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace VehiclePhysics
{
  public class VPAudioExtras : VehicleBehaviour
  {
    public AudioMixerGroup output;
    [Header("Engine startup")]
    public Transform enginePosition;
    public AudioClip engineStartupClip;
    [Range(0.0f, 1f)]
    public float engineStartupVolume;
    [Range(0.0f, 2f)]
    public float engineStartupPitch;
    [Header("3D Sound Settings")]
    [Tooltip("Maximum volume under this distance")]
    public float minDistance;
    [Tooltip("Volume clipped beyond this distance")]
    public float maxDistance;
    [Tooltip("Volume is attenuated progressively until this distance")]
    public float attenuationDistance;
    [Tooltip("Volume at Attenuation Distance. Beyond this distance is faded out to zero at Max Distance")]
    [Range(0.0f, 1f)]
    public float attenuatedVolume;
    [Range(0.0f, 1f)]
    [Header("Low Pass Filter")]
    public float interiorCameraFilter;
    private RuntimeAudio m_startupAudio;
    private VPCameraController m_cameraController;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Configure3DAudio(RuntimeAudio audio, AudioClip clip, float volume, float pitch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureInteriorCameraFilter(RuntimeAudio audio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPAudioExtras() => throw null;
  }
}
