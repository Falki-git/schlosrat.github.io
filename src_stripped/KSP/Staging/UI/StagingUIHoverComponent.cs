﻿// Decompiled with JetBrains decompiler
// Type: KSP.Staging.UI.StagingUIHoverComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Staging.UI
{
  public class StagingUIHoverComponent : 
    UIValueBinder<bool>,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    public RectTransform[] BackgroundRects;
    [SerializeField]
    private RectTransform _stageHeader;
    [SerializeField]
    private string _stageIndexPropertyKey;
    [SerializeField]
    private string _selectedStageIndexPropertyKey;
    [SerializeField]
    private string _highlightStageActionKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSelectedStageIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBackgroundPadding(bool isExpanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingUIHoverComponent() => throw null;
  }
}
