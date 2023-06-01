﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIButtonToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (Button))]
  public class UIButtonToggle : MonoBehaviour
  {
    public Image toggleImage;
    public Sprite spriteOn;
    public Sprite spriteOff;
    public bool startOn;
    public bool canToggleOn;
    public bool canToggleOff;
    public Button.ButtonClickedEvent onToggle;
    public Button.ButtonClickedEvent onToggleOff;
    public Button.ButtonClickedEvent onToggleOn;
    private Button button;
    private bool hasBeenSet;
    private bool _state;

    public Button ButtonCtrl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool state
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool interactable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(bool on) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIButtonToggle() => throw null;
  }
}
