﻿// Decompiled with JetBrains decompiler
// Type: LoadingBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using I2.Loc;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class LoadingBar : MonoBehaviour
{
  [SerializeField]
  private RectTransform loadingBarContainer;
  [SerializeField]
  private RectTransform loadingBarProgress;
  [SerializeField]
  private TMP_Text loadingText;
  [SerializeField]
  private TMP_Text statusText;
  [SerializeField]
  private TMP_Text tipsText;
  private LanguageSourceData tipsSource;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SourceDataInit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTips() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetText(string s) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPercentComplete(float f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LoadingBar() => throw null;
}
