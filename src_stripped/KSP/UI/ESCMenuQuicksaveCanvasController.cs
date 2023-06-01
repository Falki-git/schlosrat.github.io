﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuQuicksaveCanvasController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class ESCMenuQuicksaveCanvasController : KerbalMonoBehaviour
  {
    private const string SAVE_TEXT = "Quick Saving...";
    private const string LOAD_TEXT = "Quick Loading...";
    [SerializeField]
    private Text showText;
    private bool _isSaving;
    private bool _isLoading;
    private RectTransform[] childRectTransforms;
    private bool _bHideOnPC;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableShow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableShow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideOnPC(bool isPC) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SaveOrLoadCompleted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuQuicksaveCanvasController() => throw null;
  }
}
