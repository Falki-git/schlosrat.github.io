﻿// Decompiled with JetBrains decompiler
// Type: CommandBufferObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public abstract class CommandBufferObserver : MonoBehaviour
{
  private Dictionary<Camera, CommandBufferObserver.CommandBufferData> linkedBuffers;
  public MeshRenderer meshRenderer;

  public abstract string CommandBufferName
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public abstract CameraEvent TargetCameraEvent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnWillRenderObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void WillRender(CommandBufferObserver.CommandBufferData bufferData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private CommandBufferObserver.CommandBufferData CreateCommandBuffer(Camera camera) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void SetUpCommandBuffer(
    CommandBuffer commandBuffer,
    CommandBufferObserver.CommandBufferData bufferData)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected CommandBufferObserver() => throw null;

  protected class CommandBufferData
  {
    public bool wasRendered;
    public Camera camera;
    public CameraEvent cameraEvent;
    public CommandBuffer commandBuffer;
    public RenderTexture renderPass;
    public RenderTexture depthPass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCommandBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CommandBufferData() => throw null;
  }
}
