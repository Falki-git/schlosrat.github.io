﻿// Decompiled with JetBrains decompiler
// Type: TextButton3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (TextMesh), typeof (Collider))]
public class TextButton3D : MonoBehaviour, IMouseEvents
{
  public Color normalColor;
  public Color hoverColor;
  public Color downColor;
  public Callback onPressed;
  public Callback onReleased;
  public Callback onTap;
  private bool lockButton;
  private bool isHover;
  private Renderer rendrer;
  private TextMesh text;
  private bool tapping;
  private bool tapped;

  public Renderer Rendrer
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public TextMesh Text
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseEnter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseExit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator OnMouseTap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Lock() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Unlock() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseDrag() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MonoBehaviour GetInstance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TextButton3D() => throw null;
}
