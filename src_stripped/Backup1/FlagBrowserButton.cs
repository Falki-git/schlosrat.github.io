﻿// Decompiled with JetBrains decompiler
// Type: FlagBrowserButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Obsolete("deprecated", true)]
public class FlagBrowserButton : MonoBehaviour
{
  public FlagBrowser flagBrowserPrefab;
  public RawImage flagRawImage;
  public Button button;
  private FlagBrowser browser;
  private FlagBrowser.FlagSelectedCallback OnFlagSelected;
  private Callback OnFlagCancelled;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Setup(
    Texture texture,
    Callback onBrowserOpen,
    FlagBrowser.FlagSelectedCallback onFlagSelect,
    Callback onFlagCancel)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetFlag(Texture texture) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SpawnBrowser() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnFlagSelect(FlagBrowser.FlagEntry selected) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnFlagCancel() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FlagBrowserButton() => throw null;
}
