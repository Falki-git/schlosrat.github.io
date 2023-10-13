﻿// Decompiled with JetBrains decompiler
// Type: KSPAudioListenerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPAudioListenerManager : KerbalMonoBehaviour
{
  public float MapViewDistanceToShip;
  private AkAudioListener _listener;
  private bool _registeredForMessages;
  private SubscriptionHandle _messageHandle;
  private static KSPAudioListenerManager _Instance;
  private float _p_camera_altitude;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetInstance(KSPAudioListenerManager instance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Vector3 GetListenerPosition() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static GameObject GetListenerGameObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetDebugListenerTransform(Transform transform) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateListenerInFlight() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateListenerInOAB() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateListenerInMap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateListenerMainMenu() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnCameraManagerUpdated(MessageCenterMessage message) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RegisterForMessages() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPAudioListenerManager() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static KSPAudioListenerManager() => throw null;
}
