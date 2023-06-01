﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.SaveGameThumbnailCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Game.Flow
{
  public class SaveGameThumbnailCreator
  {
    public const int DEFAULT_THUMBNAIL_HEIGHT = 128;
    protected RenderTexture _grabTexture;
    protected RenderTexture _finalTexture;
    protected NativeArray<byte> _rawBuffer;

    public GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AsyncCreateThumbnail(string outputFilePath, int thumbnailHeightOverride = 128) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IEnumerator GenerateThumbnailImageCoroutine(string path, int thumbnailHeightOverride = 128) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CaptureAsync(string path, int finalWidth, int finalHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnCompleteReadback(AsyncGPUReadbackRequest request, string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveGameThumbnailCreator() => throw null;
  }
}
