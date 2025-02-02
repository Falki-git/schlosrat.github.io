﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CameraClipPlaneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  public class CameraClipPlaneManager : KerbalMonoBehaviour
  {
    private const float CAM_FAR_CLIP_PLANE_DEFAULT = 200000f;
    private const float FAR_CLIP_PLANE_ORBIT = 100000f;
    private GraphicsManager _graphicsManger;
    private bool _initialized;
    private bool _enabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(GraphicsManager gm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Enable(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateClipPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraClipPlaneManager() => throw null;
  }
}
