﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Backtrace.BacktraceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Backtrace.Unity;
using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Backtrace
{
  public class BacktraceManager
  {
    private static BacktraceManager instance;
    public const string BUILD_ENVIRONMENT = "LIVE";
    private static BacktraceClient _backtraceClient;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static BacktraceManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BacktraceManager() => throw null;
  }
}
