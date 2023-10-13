﻿// Decompiled with JetBrains decompiler
// Type: I2.Loc.LanguageSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace I2.Loc
{
  [AddComponentMenu("I2/Localization/Source")]
  [ExecuteInEditMode]
  public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
  {
    public LanguageSourceData mSource;
    public int version;
    public bool NeverDestroy;
    public bool UserAgreesToHaveItOnTheScene;
    public bool UserAgreesToHaveItInsideThePluginsFolder;
    public bool GoogleLiveSyncIsUptoDate;
    public List<Object> Assets;
    public string Google_WebServiceURL;
    public string Google_SpreadsheetKey;
    public string Google_SpreadsheetName;
    public string Google_LastUpdatedVersion;
    public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;
    public float GoogleUpdateDelay;
    public List<LanguageData> mLanguages;
    public bool IgnoreDeviceLanguage;
    public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;
    public List<TermData> mTerms;
    public bool CaseInsensitiveTerms;
    public LanguageSourceData.MissingTranslationAction OnMissingTranslation;
    public string mTerm_AppName;

    public LanguageSourceData SourceData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetSourceName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LanguageSource() => throw null;

    public delegate void fnOnSourceUpdated(
      LanguageSourceData source,
      bool ReceivedNewData,
      string errorMsg);
  }
}
