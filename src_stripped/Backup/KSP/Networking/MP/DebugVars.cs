﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.DebugVars
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Networking.MP.Serialize;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  [Serializable]
  public class DebugVars : IMPSyncable
  {
    public const string BASEKEYORFILENAME = "MPDebug";
    public const string EXTENSION = ".json";
    public const string FULLPATH_PREFIX = "PersistentDataFiles\\";
    public static string DEFAULT_LOGGED_OUT_PLAYER_NAME_STRING;
    public static string DEFAULT_LOGGED_OUT_PLAYER_GUID_STRING;
    public static string DEFAULT_LOGIN_OVERLAY_ACCOUNT_NAME_STRING;
    public static string DEFAULT_BYPASS_PLAYER_NAME_STRING;
    public static string DEFAULT_BYPASS_PLAYER_GUID_STRING;
    public const bool DEFAULT_DEBUG_MPSYNC_IGGUID_WITH_DEBUG_NAME = false;
    public string LoggedOutPlayerNameString;
    public string LoggedOutPlayerGuidString;
    public string LoginOverlayAccountNameString;
    public string BypassPlayerNameString;
    public string BypassPlayerGuidString;
    public bool DebugMPSyncIGGuidWithDebugName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PopulateDynamicDefaultValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SaveStringToPasswordString(string saveString, out string passwordString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PasswordStringToSaveString(string passwordString, out string saveString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(IMPSerializer mpSerializer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SanityChecks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveLocation GetSaveLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PopulatePlayerIdentityFieldsIfNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Save() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DebugVars() => throw null;
  }
}
