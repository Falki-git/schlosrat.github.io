﻿// Decompiled with JetBrains decompiler
// Type: KSP.Platform.PlatformManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Platform
{
  public class PlatformManager
  {
    public static PlatformManager.PlatformEvent OnPlatformInitialized;
    public static bool PlatformIsLoaded;
    private static PlatformManager gInstance;
    private static SteamManager steamManager;

    public static PlatformManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterPlatform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SteamAPIIntializedCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetPlatformAuthentication() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SteamManager GetSteamManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlatformManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PlatformManager() => throw null;

    public delegate void PlatformEvent();
  }
}
