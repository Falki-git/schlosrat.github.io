﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.CrossSave.CrossSaveManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    public bool UploadCloudSave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DownloadCloudSave(string fileName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ListCloudSaves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DeleteCrossSave(string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessCloudSaveDelete(string fileName, string response, string error = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FinalizeCloudSaveUpload(string response, string error = "", SaveFileInfo[] files = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ProcessCloudSaveUploads(string body, string error = "", SaveFileInfo[] saves = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessCrossSaveDownload(string response, string error = "", string fileName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessCrossSaveListFiles(string response, string error = "") => throw null;

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
