﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.KerbalVarietyCategoryParsingRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct KerbalVarietyCategoryParsingRule
  {
    public string CategoryName;
    public List<string> StartsWithKeys;
    public List<string> ContainsKeys;
    public List<string> EndsWithKeys;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KerbalVarietyCategoryParsingRule Defaults() => throw null;
  }
}
