﻿// Decompiled with JetBrains decompiler
// Type: GlassBlurCommandBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class GlassBlurCommandBuffer : CommandBufferObserver
{
  public Shader blurShader;
  private const int blurRepeat = 1;

  public override string CommandBufferName
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public override CameraEvent TargetCameraEvent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void SetUpCommandBuffer(
    CommandBuffer commandBuffer,
    CommandBufferObserver.CommandBufferData bufferData)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void WillRender(CommandBufferObserver.CommandBufferData bufferData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GlassBlurCommandBuffer() => throw null;
}
