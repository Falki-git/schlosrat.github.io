﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Slideshow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.Video;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class Slideshow : LoopVideoPlayer
  {
    protected int currentSlideIndex;
    [Header("Prefab References")]
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Tooltip("Title Text")]
    [SerializeField]
    protected TextMeshProUGUI _title;
    [Tooltip("Content Body Text")]
    [SerializeField]
    protected TextMeshProUGUI _body;
    [SerializeField]
    [Tooltip("This button is for closing the slideshow")]
    protected ButtonExtended _closeButton;
    [SerializeField]
    [Tooltip("Reference of the Parent Transform for the slide dot carousel.")]
    protected Transform _slideDotCarousel_T;
    [Tooltip("Reference of the slide dot for the carousel, that will get duplicated as needed.")]
    [SerializeField]
    protected GameObject _slideDotPrefab;
    [Tooltip("This button is for cycling back the slides")]
    [SerializeField]
    protected ButtonExtended _backButton;
    [Tooltip("This button is for cycling forward the slides")]
    [SerializeField]
    protected ButtonExtended _nextButton;
    [Tooltip("This button is for opening and closing child windows.")]
    [SerializeField]
    protected KSP2UIWindow[] _childWindows;
    [Tooltip("True if slides will have wrap/loop behaviour, ie. next on last slide will display the first one.")]
    [SerializeField]
    [Header("Parameters")]
    protected bool _wrapsSlides;
    protected SlideData _currentSlide;
    protected List<SlideData> _slides;
    protected List<Slideshow_Dot> _slideDots;
    protected System.Type _OnDismissMessage;
    [Tooltip("Loc String when the next button will display Next")]
    [SerializeField]
    protected string _nextButtonIsNext;
    [Tooltip("Loc String when the next button will display Finish")]
    [SerializeField]
    protected string _nextButtonIsFinish;
    protected string translationCache;
    protected bool buttonsSubscribed;
    protected int lastSlideIndex;
    protected float finishButtonDelay;
    protected WaitForSeconds finishButtonWait;
    protected bool lastSlideReached;
    protected Coroutine lastSlideCoroutine;
    private DataContext _uiData;
    private Property<string> _NextButtonTextValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void LoadSlides(Slides slides) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void LoadSlides(Slides slides, System.Type DismissMessage, float finishBtnDelay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ClearSlides() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisplaySlide(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual int ClampIndex(int currentIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetSlideText(SlideData currentSlide) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeSlideDots(Slides slides) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Slideshow_Dot InstanceNewSlideDot(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LastSlideReached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator FinishButtonDelay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFinishedButtonClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FireDismissedMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Slideshow() => throw null;
  }
}
