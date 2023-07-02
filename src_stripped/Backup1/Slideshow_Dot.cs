﻿// Decompiled with JetBrains decompiler
// Type: Slideshow_Dot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (ButtonExtended))]
[RequireComponent(typeof (Image))]
public class Slideshow_Dot : KerbalMonoBehaviour
{
  [SerializeField]
  [Header("Set on Prefab")]
  protected Color _activeColour;
  [SerializeField]
  protected Color _inactiveColour;
  [SerializeField]
  protected Image _image;
  [SerializeField]
  protected Sprite _sprite;
  [SerializeField]
  protected ButtonExtended _buttonExtended;
  public Action OnClickAction;
  private bool isActive;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSprite(Sprite newSprite) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetVisuallyActive(bool bValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void IsVisible(bool bValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void DotOnClickAction() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Slideshow_Dot() => throw null;
}
