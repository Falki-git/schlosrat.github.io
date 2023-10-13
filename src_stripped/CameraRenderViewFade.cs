﻿// Decompiled with JetBrains decompiler
// Type: CameraRenderViewFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraRenderViewFade : MonoBehaviour
{
  [SerializeField]
  private float camNearEndFade;
  [SerializeField]
  private float camFarStartFade;
  private CameraEvent cameraEventSrc;
  private CameraEvent cameraEventDst;
  private CameraEvent cameraEventSrcOld;
  private CameraEvent cameraEventDstOld;
  private Camera m_Camera;
  private List<CommandBuffer> buffersOnCamera;
  private CommandBuffer buffSrc;
  private CommandBuffer buffDst;
  private Material fadeMaterial;
  private int nearClipPlaneID;
  private int farClipPlaneID;
  private int camStartFadeID;
  private int camEndFadeID;
  private bool render;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Cleanup() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPreRender() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddBufferSrc() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddBufferDest() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CameraRenderViewFade() => throw null;
}
