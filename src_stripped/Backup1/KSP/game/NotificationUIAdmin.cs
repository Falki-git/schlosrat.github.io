﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationUIAdmin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class NotificationUIAdmin : NotificationUI
  {
    private const string TITLE_TEXT_PROPERTY_KEY = "adminTitle";
    private const string BODY_CONTENT_PROPERTY_KEY = "adminBodyContent";
    private const string PRIMARY_ICON_PROPERTY_KEY = "adminIcon";
    private const string INITIAL_VALUE_UNKNOWN = "UNASSIGNED";
    [SerializeField]
    private GameObject _alertTitle;
    private Property<string> _title;
    private Property<string> _bodyContent;
    private Property<Sprite> _icon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetupAndLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupAndLocalizeBodyContent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DismissNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationUIAdmin() => throw null;
  }
}
