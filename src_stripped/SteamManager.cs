﻿// Decompiled with JetBrains decompiler
// Type: SteamManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AOT;
using Steamworks;
using System.Runtime.CompilerServices;
using System.Text;

public class SteamManager
{
  public SteamManager.SteamManagerEvent OnSteamAPIInitialized;
  protected static bool s_EverInitialized;
  protected static SteamManager s_instance;
  protected bool m_bInitialized;
  protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

  public static SteamManager Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool Initialized
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MonoPInvokeCallback(typeof (SteamAPIWarningMessageHook_t))]
  [MethodImpl(MethodImplOptions.NoInlining)]
  protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void Enable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  ~SteamManager() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string GetSteamAuthTicket() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void QuitApplication() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string GetSteamUserID() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SteamManager() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static SteamManager() => throw null;

  public delegate void SteamManagerEvent();
}
