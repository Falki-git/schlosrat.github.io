﻿// Decompiled with JetBrains decompiler
// Type: TestLoopVideoPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Video;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestLoopVideoPlayer : MonoBehaviour
{
  [SerializeField]
  [Header("Use context menu to play with selections")]
  private LoopVideoPlayer loopVideoPlayer;
  [SerializeField]
  private LoopVideoData videoData;
  [SerializeField]
  private Vector2 imageSize;
  [SerializeField]
  private string addressablePrefabPath;
  [SerializeField]
  private string addressableDataPath;

  [ContextMenu("PlayVideoData")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayVideoData() => throw null;

  [ContextMenu("StopVideoData")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StopVideoData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TestLoopVideoPlayer() => throw null;
}
