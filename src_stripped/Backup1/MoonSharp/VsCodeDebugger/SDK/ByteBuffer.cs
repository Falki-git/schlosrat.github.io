﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.ByteBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.VsCodeDebugger.SDK
{
  internal class ByteBuffer
  {
    private byte[] _buffer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ByteBuffer() => throw null;

    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetString(Encoding enc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Append(byte[] b, int length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte[] RemoveFirst(int n) => throw null;
  }
}
