﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectIdUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public static class ObjectIdUtil
  {
    public const ulong OBJECT_ID_NONE = 0;
    public const ulong PART_ID_NONE = 0;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDebugObjectIdString(ulong objectId, bool abbrev) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ConvertObjectIdToPlayerIdAndPartId(
      ulong objectId,
      out byte playerIdOut,
      out ulong partIdOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ConvertPlayerIdAndPartIdToObjectId(
      byte playerId,
      ulong partId,
      out ulong objectIdOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ulong GetObjectId(byte playerId, ulong partId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte GetPlayerId(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ulong GetPartId(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static (byte, ulong) GetPlayerIdAndPartId(ulong objectId) => throw null;
  }
}
