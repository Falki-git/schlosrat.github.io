﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_HoveredListMoveIndex_Visible
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_HoveredListMoveIndex_Visible : UIValueBinder<int>
  {
    [Header("Assign in Prefab")]
    [Tooltip(" behaviour we want to enable or disable depending if the next element will be GREATER than our current index")]
    public CanvasGroup movingToGrater;
    [Tooltip(" behaviour we want to enable or disable depending if the next element will be LOWER than our current index")]
    public CanvasGroup movingToLower;
    [SerializeField]
    private string fromElementPropertyName;
    [SerializeField]
    private string toElementPropertyName;
    public UIList_ListElement uIListElement;
    private int _highlightIndex;
    private int _currentElementIndex;
    private int _FromElementIndex;
    private int _ToElementIndex;
    private Coroutine queuedEnabledCoroutine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayAction(bool enableGreater, bool enableLower) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetQueuedActive(bool enableGreater, bool enableLower) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_HoveredListMoveIndex_Visible() => throw null;
  }
}
