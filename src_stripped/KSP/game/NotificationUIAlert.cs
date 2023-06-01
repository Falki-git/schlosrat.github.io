﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationUIAlert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  [RequireComponent(typeof (CanvasGroup))]
  public class NotificationUIAlert : KerbalMonoBehaviour
  {
    private const string CRITICAL_ALERT_NOTIFICATION_LOC_PATH = "Notifications/Alert/CriticalHeader";
    private const string ALERT_NOTIFICATION_LOC_PATH = "Notifications/Alert/Header";
    private const string DATETIME_SEPARATOR_LOC_PATH = "Menu/TrackingStation/Units/:";
    private const string HEADER_TEXT_PROPERTY_KEY = "headerText";
    private const string ALERT_TITILE_TEXT_PROPERTY_KEY = "alertTitleText";
    private const string ALERT_TITILE_ICON_PROPERTY_KEY = "alertTitleIcon";
    private const string ALERT_LINE_ITEM_ADJECTIVE_TEXT_PROPERTY_KEY = "lineItemAdjectiveText";
    private const string ALERT_LINE_ITEM_ADJECTIVE_ICON_PROPERTY_KEY = "lineItemAdjectiveIcon";
    private const string ALERT_LINE_ITEM_NOUN_TEXT_PROPERTY_KEY = "lineItemNounText";
    private const string ALERT_LINE_ITEM_NOUN_ICON_PROPERTY_KEY = "lineItemNounIcon";
    private const string ALERT_LOCATION_TEXT_PROPERTY_KEY = "location";
    private const string ALERT_LOCATION_ICON_PROPERTY_KEY = "locationIcon";
    private const string ALERT_TIMER_PROGRESS = "timerProgress";
    private const string DISMISS_ALERT_ACTION_KEY = "dismissAlertNotification";
    private const string GOTO_LOCATION_ACTION_KEY = "goToLocation";
    private const string INITIAL_VALUE_UNKNOWN = "UNASSIGNED";
    private const string DATETIME_POSTFIX_LOC_PATH = "t";
    private const string TITLE_TEXT_FORMAT = "{0}{1}[{2}]";
    private const char DOT = '.';
    private const string TIMESPAN_MINUTE = "mm";
    private const string TIMESPAN_SECOND = "ss";
    private const int HOURS_PER_DAY = 6;
    private const char HOURS_PREFIX = '0';
    [HideInInspector]
    public Property<string> Location;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private CanvasGroup _timerCanvasGroup;
    [SerializeField]
    private CanvasGroup _trackingStationActionCanvasGroup;
    [Header("Level of Importance - Colors")]
    [SerializeField]
    private TextMeshProUGUI _notificationTitle;
    [SerializeField]
    private TextMeshProUGUI _alertTitle;
    [SerializeField]
    private Image _borderImage;
    [SerializeField]
    private Image _contentImage;
    [SerializeField]
    private Image _timerFillImage;
    [SerializeField]
    private Image _trackingStationImage;
    [SerializeField]
    private CanvasGroup _highLOICloseButton;
    [SerializeField]
    private CanvasGroup _mediumLOICloseButton;
    [SerializeField]
    private CanvasGroup _lowLOICloseButton;
    [Header("High")]
    [SerializeField]
    private Color _highBorderColor;
    [SerializeField]
    private Color _highBackgroundColor;
    [Header("Medium")]
    [SerializeField]
    private Color _mediumBorderColor;
    [SerializeField]
    private Color _mediumBackgroundColor;
    [SerializeField]
    [Header("Low")]
    private Color _lowBorderColor;
    [SerializeField]
    private Color _lowBackgroundColor;
    private NotificationUIProvider _notificationUIProvider;
    private NotificationData _notificationData;
    private DOTweenAnimation _fadeAnimation;
    private string _id;
    private int _excessDotsAmount;
    private string _dateTimeSeparator;
    private DataContext _dataContext;
    private Property<string> _headerText;
    private Property<string> _alertTitleText;
    private Property<Sprite> _alertTitleIcon;
    private Property<Sprite> _locationIcon;
    private Property<float> _timerProgress;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(NotificationData data, NotificationUIProvider notificationUIProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupAlertVisuals(NotificationData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupAndLocalizeHeader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupAndLocalizeTitle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupAndLocalizeFirstLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivateTimer(float timerDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GoToLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLevelOfImportance(NotificationImportance importanceLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateContentColors(Color borderColor, Color contentBackgroundColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationUIAlert() => throw null;
  }
}
