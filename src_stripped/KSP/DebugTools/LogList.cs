﻿// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.LogList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class LogList : MonoBehaviour
  {
    [SerializeField]
    private ScrollRect _scrollRect;
    [SerializeField]
    private RectTransform _logEntryParent;
    [SerializeField]
    private LogConsoleEntry _logEntryPrefab;
    private LogConsoleWindow _window;
    private List<LogEntry> _entries;
    private List<LogConsoleEntry> _objects;
    private int _visibleEntryCount;
    private int _previousCountBeforeVisible;
    private int _previousEntriesCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(LogConsoleWindow window) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh(List<LogEntry> entries) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshVisibleEntries(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetParentSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogList() => throw null;
  }
}
