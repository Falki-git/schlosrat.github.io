﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.RDPinMapTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  public class RDPinMapTool : KerbalMonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    [SerializeField]
    private Image _cameraBox;
    private Camera _rdCamera;
    private RDCameraManager _rdCameraManager;
    private List<DOTweenAnimation> _tweenAnimations;
    private bool _isVisible;
    private float _cameraBoxScale;
    private RectTransform _rectTransform;
    private RectTransform _cameraBoxRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandlePinMapVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RDPinMapTool() => throw null;
  }
}
