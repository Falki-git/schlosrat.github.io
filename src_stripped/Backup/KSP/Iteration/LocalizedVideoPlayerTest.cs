﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.LocalizedVideoPlayerTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Video;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration
{
  public class LocalizedVideoPlayerTest : MonoBehaviour
  {
    public LocalizedVideoPlayer player;
    [Space]
    public LocalizedVideoData video1;
    public LocalizedVideoData video2;
    public LocalizedVideoData video3;
    [Header("Quick-n-dirty \"buttons\" - click to play", order = 2)]
    [Space(order = 1)]
    public bool buttonPlay1;
    public bool buttonPlay2;
    public bool buttonPlay3;
    [Header("Click to stop if already playing", order = 2)]
    [Space(order = 1)]
    public bool buttonClose;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play1() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play3() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedVideoPlayerTest() => throw null;
  }
}
