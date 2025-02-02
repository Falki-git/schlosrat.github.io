﻿// Decompiled with JetBrains decompiler
// Type: GUIUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GUIUtil
{
  private static int progressBarBorderLeft;
  private static int progressBarBorderRight;
  private static int progressBarBorderTop;
  private static int progressBarBorderBottom;
  private static Dictionary<int, bool> EditableFieldStates;
  private static Vector2 enumSelectionPaneScrollPos;
  private static Rect enumSelectionPaneRect;
  private static int enumSelectionPaneSelIdx;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ProgressBar(Rect rect, float start, float end, GUIStyle style) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ProgressBarVertical(Rect rect, float start, float end, GUIStyle style) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Rect ScreenCenteredRect(float width, float height) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float LabelHorizontalSlider(
    string caption,
    float value,
    float leftValue,
    float rightValue,
    string valueStringFormat,
    params GUILayoutOption[] guiOptions)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float LabelVerticalSlider(
    string caption,
    float value,
    float leftValue,
    float rightValue,
    string valueStringFormat,
    params GUILayoutOption[] guiOptions)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T EnumFlagField<T>(
    string caption,
    T value,
    int ValueCount,
    int xCount,
    Func<int, T> ValueAt,
    Func<int, string> ValueNameAt,
    Func<T, int> IntCast,
    Func<int, T> TCast)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ClearEditableFieldFlags() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T EditableField<T>(
    string caption,
    T value,
    Func<T, string> ToStringMethod,
    Func<string, T> ParseMethod,
    Callback<T> onSubmit)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string EditableStringField(string caption, string value, Callback<string> onSubmit) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool EditableBoolField(string caption, bool value, Callback<bool> onSubmit) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int EditableIntField(string caption, int value, Callback<int> onSubmit) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float EditableFloatField(string caption, float value, Callback<float> onSubmit) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double EditableDoubleField(string caption, double value, Callback<double> onSubmit) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string EditableTextArea(
    string caption,
    string value,
    Callback<string> onSubmit,
    params GUILayoutOption[] guiOptions)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int EditableEnumField(
    string caption,
    System.Type enumType,
    int selected,
    Callback<int> onSubmit,
    params GUILayoutOption[] guiOptions)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static int DrawEnumSelectionPane(System.Type enumType, int selected, ref Vector2 scrollPos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GUIUtil() => throw null;

  public class Layout
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ProgressBar(
      float start,
      float end,
      GUIStyle bgStyle,
      GUIStyle barStyle,
      params GUILayoutOption[] options)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ProgressBarVert(
      float start,
      float end,
      GUIStyle bgStyle,
      GUIStyle barStyle,
      params GUILayoutOption[] options)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Layout() => throw null;
  }
}
