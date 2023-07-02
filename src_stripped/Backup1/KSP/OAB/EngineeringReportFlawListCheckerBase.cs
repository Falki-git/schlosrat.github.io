﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EngineeringReportFlawListCheckerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public abstract class EngineeringReportFlawListCheckerBase
  {
    public string TitleLocalizationTerm;
    public EngineerReportSeverity Severity;
    public PartCategories FlawCategory;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract EngineeringReportFlawListCheckResult Check(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected EngineeringReportFlawListCheckerBase() => throw null;
  }
}
