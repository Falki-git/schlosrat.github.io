﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.GHResearchDevelopment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class GHResearchDevelopment : KerbalMonoBehaviour, IGHContextualMenu
  {
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private const string PLAYER_SCIENCE_PROPERTY_KEY = "playerScience";

    public GameState ID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBackgroundVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowContextualMenu(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GHResearchDevelopment() => throw null;
  }
}
