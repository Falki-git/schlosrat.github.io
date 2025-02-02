﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.CrossSave.CrossSaveManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.OnlineServices.CrossSave
{
  public class CrossSaveManager : MonoBehaviour
  {
    private static CrossSaveManager instance;
    public List<Metadatum> ActiveCloudSaves;
    public bool CloudSavesListLoaded;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CrossSaveManager.DownloadState CurrentDownloadState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static CrossSaveManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFilesDownloaded(bool successfulDownload) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<string, string> GetTitleCrossSaveHeaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsSignedInToService() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossSaveManager() => throw null;

    public enum DownloadState
    {
      None,
      Fail,
      Success,
    }
  }
}
