﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.MPGUIDGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class MPGUIDGenerator
  {
    private Guid _guid;
    private MPRandom _mpRandom;

    public Guid Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitGuid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGuid(Guid guid) => throw null;

    public MPRandom MPRandom
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitMPRandom() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMPRandom(MPRandom mpRandom) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMPRandom(uint seed, uint bias = 78665521, int counter = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetConfigureString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPGUIDGenerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPGUIDGenerator(Guid guid, uint seed, uint bias = 78665521, int counter = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPGUIDGenerator(string configureString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPGUIDGenerator(MPGUIDGenerator src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(Guid guid, uint seed, uint bias = 78665521, int counter = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(string configureString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(MPGUIDGenerator src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetViaConfigureString(string configureString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(MPGUIDGenerator src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Advance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Guid GetRandomGuid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;
  }
}
