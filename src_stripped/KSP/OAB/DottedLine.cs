﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.DottedLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class DottedLine : KerbalMonoBehaviour
  {
    public Texture2D dotLineTex;
    public float dotTextureScalar;
    public float materialTextureScale;
    public float lineWidth;
    public float lineHeight;
    private LineRenderer lineRenderer;
    private bool showing;
    private float scrollT;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show(bool b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawLine(Vector3 start, Vector3 end, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DottedLine() => throw null;
  }
}
