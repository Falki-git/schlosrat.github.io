﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyFlagManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class AgencyFlagManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private CreateCampaignMenu _createCampaignMenu;
    [SerializeField]
    [Space]
    private AgencyFlagsData _agencyFlags;
    [SerializeField]
    private AgencyFlagItem _flagPrefab;
    [SerializeField]
    private RectTransform _flagParent;
    [SerializeField]
    private AgencyColorPicker _agencyColorPicker;
    [Space]
    [SerializeField]
    private SyncToggleGroupWithChildren _syncToggleGroupWithChildren;
    [Header("UI to hide on deactivate")]
    [SerializeField]
    private GameObject[] _hideableUI;
    private DataContext _dataContext;
    private Property<Sprite> _selectedFlagIcon;
    private AgencyFlag _currentAgencyFlag;
    private bool _initialized;
    private Property<Color> _selectedAccentColor;
    private Property<Color> _selectedBaseColor;
    private Property<Color> _defaultAccentColor;
    private Property<Color> _defaultBaseColor;

    public string SelectedFlagIconName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color SelectedAccentColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color SelectedBaseColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAgencyDefaultFlagAndColors(AgencyFlag agencyflag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlag(AgencyFlag agencyflag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAgencyColorsToCurrentFlag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyColorsFromColorPicker(bool isBase, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetSelectedColorsToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyFlagManager() => throw null;
  }
}
