﻿// Decompiled with JetBrains decompiler
// Type: I2.Loc.TranslationJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class TranslationJob : IDisposable
  {
    public TranslationJob.eJobState mJobState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TranslationJob.eJobState GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TranslationJob() => throw null;

    public enum eJobState
    {
      Running,
      Succeeded,
      Failed,
    }
  }
}
