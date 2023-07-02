﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.UdpSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace EdyCommonTools
{
  public class UdpSender
  {
    private UdpClient m_client;
    private IPEndPoint m_sendPoint;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UdpSender(string server, int port) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~UdpSender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendSync(byte[] bytesToSend, int maxBytes = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendAsync(byte[] bytesToSend, int maxBytes = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MessageSentA(IAsyncResult ar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close() => throw null;
  }
}
