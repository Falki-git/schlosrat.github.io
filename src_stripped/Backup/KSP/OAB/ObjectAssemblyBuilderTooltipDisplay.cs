﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderTooltipDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderTooltipDisplay : 
    KerbalMonoBehaviour,
    ISelectHandler,
    IEventSystemHandler,
    IDeselectHandler,
    IPointerEnterHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private string tooltipText;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string TranslateText(string toTranslateKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderTooltipDisplay() => throw null;
  }
}
