﻿// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.DropdownLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Navigation
{
  [DisallowMultipleComponent]
  [RequireComponent(typeof (NavElementTag))]
  public class DropdownLayout : KerbalMonoBehaviour, INavigatable
  {
    public TMP_Dropdown TMPDropdownRef;
    private Selectable[] _items;
    private bool _isExpandedLastFrame;
    private int _indexPrev;
    private NavElementGroup _group;
    private bool _isLoaded;

    private Selectable CurrentItem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool Loaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    Selectable INavigatable.CurrentElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    bool INavigatable.Focused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    bool INavigatable.Active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigatable.UnloadComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool INavigatable.SelectElementAt(MoveDirection direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigatable.Quit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DropdownLayout() => throw null;
  }
}
