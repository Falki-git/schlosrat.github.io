﻿// Decompiled with JetBrains decompiler
// Type: RTG.GizmoQuad2DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoQuad2DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider2D PlaneSlider;
    public GizmoQuad2DBorder Border;
    public GizmoHandle TargetHandle;
    public QuadShape2D TargetQuad;
    public QuadShape2D BorderQuad;
    public int BorderQuadIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoQuad2DBorderControllerData() => throw null;
  }
}
