﻿// Decompiled with JetBrains decompiler
// Type: KSP.OutlineEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP
{
  [RequireComponent(typeof (Camera))]
  [DisallowMultipleComponent]
  public class OutlineEffect : MonoBehaviour
  {
    public Camera outlineCam;
    [SerializeField]
    [HideInInspector]
    private Shader outlineShader;
    private List<Outline> outlines;
    private const string shaderName = "KSP2/UI/JumpFloodOutline";
    private const CameraEvent cameraEvent = CameraEvent.AfterForwardAlpha;
    private const int SHADER_PASS_INTERIOR_STENCIL = 0;
    private const int SHADER_PASS_SILHOUETTE_BUFFER_FILL = 1;
    private const int SHADER_PASS_JFA_INIT = 2;
    private const int SHADER_PASS_JFA_FLOOD_SINGLE_AXIS = 3;
    private const int SHADER_PASS_JFA_OUTLINE = 4;
    private int silhouetteBufferID;
    private int nearestPointID;
    private int nearestPointPingPongID;
    private int outlineColorID;
    private int axisWidthID;
    private int sourceOutlineTexID;
    private CommandBuffer commandBuffer;
    private Material outlineMat;
    private Camera bufferCam;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOutline(Outline outline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOutline(Outline outline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Mesh MeshFromRenderer(Renderer r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCommandBuffer(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyCommandBuffer(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCommandBuffer(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OutlineEffect() => throw null;
  }
}
