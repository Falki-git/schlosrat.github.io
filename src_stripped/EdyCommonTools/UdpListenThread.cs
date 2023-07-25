﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.UdpListenThread
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Threading;

namespace EdyCommonTools
{
  public class UdpListenThread
  {
    public int threadStopTimeoutMs;
    public int threadSleepIntervalMs;
    public bool debug;
    private UdpConnection m_connection;
    private UdpListenThread.OnReceiveData m_onReceiveDataCb;
    private Thread m_thread;
    private bool m_threadExit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~UdpListenThread() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start(UdpConnection connection, UdpListenThread.OnReceiveData receiveDataCb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ListenThread() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UdpListenThread() => throw null;

    public delegate void OnReceiveData();
  }
}
