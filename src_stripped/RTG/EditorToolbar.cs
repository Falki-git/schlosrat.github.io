﻿// Decompiled with JetBrains decompiler
// Type: RTG.EditorToolbar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class EditorToolbar
  {
    [SerializeField]
    private Color _activeTabColor;
    [SerializeField]
    private int _numTabsPerRow;
    [SerializeField]
    private EditorToolbarTab[] _tabs;
    [SerializeField]
    private int _activeTabIndex;

    public int ActiveTabIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public EditorToolbarTab ActiveTab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ActiveTabColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumTabsPerRow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumTabs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EditorToolbar(EditorToolbarTab[] tabs, int numTabsPerRow, Color activeTabColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EditorToolbarTab GetTabByIndex(int tabIndex) => throw null;
  }
}
