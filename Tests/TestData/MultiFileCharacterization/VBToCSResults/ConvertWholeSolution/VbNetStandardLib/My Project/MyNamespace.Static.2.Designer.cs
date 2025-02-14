// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Microsoft.VisualBasic
{
    namespace CompilerServices
    {
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class EmbeddedOperators
        {
            private EmbeddedOperators()
            {
            }
            public static int CompareString(string Left, string Right, bool TextCompare)
            {
                if (ReferenceEquals(Left, Right))
                {
                    return 0;
                }
                if (Left is null)
                {
                    if (Right.Length == 0)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (Right is null)
                {
                    if (Left.Length == 0)
                    {
                        return 0;
                    }
                    return 1;
                }
                int Result;
                if (TextCompare)
                {
                    var OptionCompareTextFlags = System.Globalization.CompareOptions.IgnoreCase | System.Globalization.CompareOptions.IgnoreWidth | System.Globalization.CompareOptions.IgnoreKanaType;
                    Result = Conversions.GetCultureInfo().CompareInfo.Compare(Left, Right, OptionCompareTextFlags);
                }
                else
                {
                    Result = string.CompareOrdinal(Left, Right);
                }
                if (Result == 0)
                {
                    return 0;
                }
                else if (Result > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class Conversions
        {
            private Conversions()
            {
            }
            private static object GetEnumValue(object Value)
            {
                var underlyingType = Enum.GetUnderlyingType(Value.GetType());
                if (underlyingType.Equals(typeof(sbyte)))
                {
                    return (sbyte)Value;
                }
                else if (underlyingType.Equals(typeof(byte)))
                {
                    return (byte)Value;
                }
                else if (underlyingType.Equals(typeof(short)))
                {
                    return (short)Value;
                }
                else if (underlyingType.Equals(typeof(ushort)))
                {
                    return (ushort)Value;
                }
                else if (underlyingType.Equals(typeof(int)))
                {
                    return (int)Value;
                }
                else if (underlyingType.Equals(typeof(uint)))
                {
                    return (uint)Value;
                }
                else if (underlyingType.Equals(typeof(long)))
                {
                    return (long)Value;
                }
                else if (underlyingType.Equals(typeof(ulong)))
                {
                    return (ulong)Value;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
            public static bool ToBoolean(string Value)
            {
                if (Value is null)
                {
                    Value = "";
                }
                try
                {
                    var loc = GetCultureInfo();
                    if (loc.CompareInfo.Compare(Value, bool.FalseString, System.Globalization.CompareOptions.IgnoreCase) == 0)
                    {
                        return false;
                    }
                    else if (loc.CompareInfo.Compare(Value, bool.TrueString, System.Globalization.CompareOptions.IgnoreCase) == 0)
                    {
                        return true;
                    }
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return ToBoolean(i64Value);
                    }
                    return ToBoolean(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static bool ToBoolean(object Value)
            {
                if (Value is null)
                {
                    return false;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return (bool)Value;
                }
                else if (Value is sbyte)
                {
                    return ToBoolean((sbyte)Value);
                }
                else if (Value is byte)
                {
                    return ToBoolean((byte)Value);
                }
                else if (Value is short)
                {
                    return ToBoolean((short)Value);
                }
                else if (Value is ushort)
                {
                    return ToBoolean((ushort)Value);
                }
                else if (Value is int)
                {
                    return ToBoolean((int)Value);
                }
                else if (Value is uint)
                {
                    return ToBoolean((uint)Value);
                }
                else if (Value is long)
                {
                    return ToBoolean((long)Value);
                }
                else if (Value is ulong)
                {
                    return ToBoolean((ulong)Value);
                }
                else if (Value is decimal)
                {
                    return ToBoolean((decimal)Value);
                }
                else if (Value is float)
                {
                    return ToBoolean((float)Value);
                }
                else if (Value is double)
                {
                    return ToBoolean((double)Value);
                }
                else if (Value is string)
                {
                    return ToBoolean((string)Value);
                }
                throw new InvalidCastException();
            }
            public static byte ToByte(string Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return (byte)i64Value;
                    }
                    return (byte)Math.Round(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static byte ToByte(object Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToByte((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (byte)(sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (byte)(short)Value;
                }
                else if (Value is ushort)
                {
                    return (byte)(ushort)Value;
                }
                else if (Value is int)
                {
                    return (byte)(int)Value;
                }
                else if (Value is uint)
                {
                    return (byte)(uint)Value;
                }
                else if (Value is long)
                {
                    return (byte)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (byte)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (byte)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (byte)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (byte)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToByte((string)Value);
                }
                throw new InvalidCastException();
            }
            [CLSCompliant(false)]
            public static sbyte ToSByte(string Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return (sbyte)i64Value;
                    }
                    return (sbyte)Math.Round(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            [CLSCompliant(false)]
            public static sbyte ToSByte(object Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToSByte((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (sbyte)(byte)Value;
                }
                else if (Value is short)
                {
                    return (sbyte)(short)Value;
                }
                else if (Value is ushort)
                {
                    return (sbyte)(ushort)Value;
                }
                else if (Value is int)
                {
                    return (sbyte)(int)Value;
                }
                else if (Value is uint)
                {
                    return (sbyte)(uint)Value;
                }
                else if (Value is long)
                {
                    return (sbyte)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (sbyte)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (sbyte)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (sbyte)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (sbyte)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToSByte((string)Value);
                }
                throw new InvalidCastException();
            }
            public static short ToShort(string Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return (short)i64Value;
                    }
                    return (short)Math.Round(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static short ToShort(object Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToShort((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (short)Value;
                }
                else if (Value is ushort)
                {
                    return (short)(ushort)Value;
                }
                else if (Value is int)
                {
                    return (short)(int)Value;
                }
                else if (Value is uint)
                {
                    return (short)(uint)Value;
                }
                else if (Value is long)
                {
                    return (short)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (short)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (short)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (short)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (short)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToShort((string)Value);
                }
                throw new InvalidCastException();
            }
            [CLSCompliant(false)]
            public static ushort ToUShort(string Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return (ushort)i64Value;
                    }
                    return (ushort)Math.Round(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            [CLSCompliant(false)]
            public static ushort ToUShort(object Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToUShort((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (ushort)(sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (ushort)(short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (ushort)(int)Value;
                }
                else if (Value is uint)
                {
                    return (ushort)(uint)Value;
                }
                else if (Value is long)
                {
                    return (ushort)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (ushort)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (ushort)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (ushort)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (ushort)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToUShort((string)Value);
                }
                throw new InvalidCastException();
            }
            public static int ToInteger(string Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return (int)i64Value;
                    }
                    return (int)Math.Round(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static int ToInteger(object Value)
            {
                if (Value is null)
                {
                    return 0;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToInteger((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (int)Value;
                }
                else if (Value is uint)
                {
                    return (int)(uint)Value;
                }
                else if (Value is long)
                {
                    return (int)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (int)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (int)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (int)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (int)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToInteger((string)Value);
                }
                throw new InvalidCastException();
            }
            [CLSCompliant(false)]
            public static uint ToUInteger(string Value)
            {
                if (Value is null)
                {
                    return 0U;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return (uint)i64Value;
                    }
                    return (uint)Math.Round(ParseDouble(Value));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            [CLSCompliant(false)]
            public static uint ToUInteger(object Value)
            {
                if (Value is null)
                {
                    return 0U;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToUInteger((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (uint)(sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (uint)(short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (uint)(int)Value;
                }
                else if (Value is uint)
                {
                    return (uint)Value;
                }
                else if (Value is long)
                {
                    return (uint)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (uint)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (uint)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (uint)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (uint)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToUInteger((string)Value);
                }
                throw new InvalidCastException();
            }
            public static long ToLong(string Value)
            {
                if (Value is null)
                {
                    return 0L;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return i64Value;
                    }
                    return (long)Math.Round(ParseDecimal(Value, null));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static long ToLong(object Value)
            {
                if (Value is null)
                {
                    return 0L;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToLong((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (int)Value;
                }
                else if (Value is uint)
                {
                    return (uint)Value;
                }
                else if (Value is long)
                {
                    return (long)Value;
                }
                else if (Value is ulong)
                {
                    return (long)(ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (long)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (long)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (long)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToLong((string)Value);
                }
                throw new InvalidCastException();
            }
            [CLSCompliant(false)]
            public static ulong ToULong(string Value)
            {
                if (Value is null)
                {
                    return 0UL;
                }
                try
                {
                    var ui64Value = default(ulong);
                    if (IsHexOrOctValue(Value, ref ui64Value))
                    {
                        return ui64Value;
                    }
                    return (ulong)Math.Round(ParseDecimal(Value, null));
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            [CLSCompliant(false)]
            public static ulong ToULong(object Value)
            {
                if (Value is null)
                {
                    return 0UL;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToULong((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (ulong)(sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (ulong)(short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (ulong)(int)Value;
                }
                else if (Value is uint)
                {
                    return (uint)Value;
                }
                else if (Value is long)
                {
                    return (ulong)(long)Value;
                }
                else if (Value is ulong)
                {
                    return (ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (ulong)Math.Round((decimal)Value);
                }
                else if (Value is float)
                {
                    return (ulong)Math.Round((float)Value);
                }
                else if (Value is double)
                {
                    return (ulong)Math.Round((double)Value);
                }
                else if (Value is string)
                {
                    return ToULong((string)Value);
                }
                throw new InvalidCastException();
            }
            public static decimal ToDecimal(bool Value)
            {
                if (Value)
                {
                    return -1m;
                }
                else
                {
                    return 0m;
                }
            }
            public static decimal ToDecimal(string Value)
            {
                if (Value is null)
                {
                    return 0m;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return i64Value;
                    }
                    return ParseDecimal(Value, null);
                }
                catch (OverflowException e1)
                {
                    throw e1;
                }
                catch (FormatException e2)
                {
                    throw new InvalidCastException(e2.Message, e2);
                }
            }
            public static decimal ToDecimal(object Value)
            {
                if (Value is null)
                {
                    return 0m;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToDecimal((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (int)Value;
                }
                else if (Value is uint)
                {
                    return (uint)Value;
                }
                else if (Value is long)
                {
                    return (long)Value;
                }
                else if (Value is ulong)
                {
                    return (ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (decimal)Value;
                }
                else if (Value is float)
                {
                    return (decimal)(float)Value;
                }
                else if (Value is double)
                {
                    return (decimal)(double)Value;
                }
                else if (Value is string)
                {
                    return ToDecimal((string)Value);
                }
                throw new InvalidCastException();
            }
            private static decimal ParseDecimal(string Value, System.Globalization.NumberFormatInfo NumberFormat)
            {
                System.Globalization.NumberFormatInfo NormalizedNumberFormat;
                var culture = GetCultureInfo();
                if (NumberFormat is null)
                {
                    NumberFormat = culture.NumberFormat;
                }
                NormalizedNumberFormat = GetNormalizedNumberFormat(NumberFormat);
                const System.Globalization.NumberStyles flags = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowTrailingSign | System.Globalization.NumberStyles.AllowParentheses | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowCurrencySymbol;
                Value = ToHalfwidthNumbers(Value, culture);
                try
                {
                    return decimal.Parse(Value, flags, NormalizedNumberFormat);
                }
                catch (FormatException FormatEx) when (!ReferenceEquals(NumberFormat, NormalizedNumberFormat))
                {
                    return decimal.Parse(Value, flags, NumberFormat);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            private static System.Globalization.NumberFormatInfo GetNormalizedNumberFormat(System.Globalization.NumberFormatInfo InNumberFormat)
            {
                System.Globalization.NumberFormatInfo OutNumberFormat;
                if (InNumberFormat.CurrencyDecimalSeparator is not null && InNumberFormat.NumberDecimalSeparator is not null && InNumberFormat.CurrencyGroupSeparator is not null && InNumberFormat.NumberGroupSeparator is not null && InNumberFormat.CurrencyDecimalSeparator.Length == 1 && InNumberFormat.NumberDecimalSeparator.Length == 1 && InNumberFormat.CurrencyGroupSeparator.Length == 1 && InNumberFormat.NumberGroupSeparator.Length == 1 && InNumberFormat.CurrencyDecimalSeparator[0] == InNumberFormat.NumberDecimalSeparator[0] && InNumberFormat.CurrencyGroupSeparator[0] == InNumberFormat.NumberGroupSeparator[0] && InNumberFormat.CurrencyDecimalDigits == InNumberFormat.NumberDecimalDigits)
                {
                    return InNumberFormat;
                }
                if (InNumberFormat.CurrencyDecimalSeparator is not null && InNumberFormat.NumberDecimalSeparator is not null && InNumberFormat.CurrencyDecimalSeparator.Length == InNumberFormat.NumberDecimalSeparator.Length && InNumberFormat.CurrencyGroupSeparator is not null && InNumberFormat.NumberGroupSeparator is not null && InNumberFormat.CurrencyGroupSeparator.Length == InNumberFormat.NumberGroupSeparator.Length)
                {
                    int i;
                    var loopTo = InNumberFormat.CurrencyDecimalSeparator.Length - 1;
                    for (i = 0; i <= loopTo; i++)
                    {
                        if (InNumberFormat.CurrencyDecimalSeparator[i] != InNumberFormat.NumberDecimalSeparator[i])
                            goto MisMatch;
                    }
                    var loopTo1 = InNumberFormat.CurrencyGroupSeparator.Length - 1;
                    for (i = 0; i <= loopTo1; i++)
                    {
                        if (InNumberFormat.CurrencyGroupSeparator[i] != InNumberFormat.NumberGroupSeparator[i])
                            goto MisMatch;
                    }
                    return InNumberFormat;
                }

            MisMatch:
                ;

                OutNumberFormat = (System.Globalization.NumberFormatInfo)InNumberFormat.Clone();
                OutNumberFormat.CurrencyDecimalSeparator = OutNumberFormat.NumberDecimalSeparator;
                OutNumberFormat.CurrencyGroupSeparator = OutNumberFormat.NumberGroupSeparator;
                OutNumberFormat.CurrencyDecimalDigits = OutNumberFormat.NumberDecimalDigits;
                return OutNumberFormat;
            }
            public static float ToSingle(string Value)
            {
                if (Value is null)
                {
                    return 0f;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return i64Value;
                    }
                    double Result = ParseDouble(Value);
                    if ((Result < float.MinValue || Result > float.MaxValue) && !double.IsInfinity(Result))
                    {
                        throw new OverflowException();
                    }
                    return (float)Result;
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static float ToSingle(object Value)
            {
                if (Value is null)
                {
                    return 0f;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToSingle((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (int)Value;
                }
                else if (Value is uint)
                {
                    return (uint)Value;
                }
                else if (Value is long)
                {
                    return (long)Value;
                }
                else if (Value is ulong)
                {
                    return (ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (float)(decimal)Value;
                }
                else if (Value is float)
                {
                    return (float)Value;
                }
                else if (Value is double)
                {
                    return (float)(double)Value;
                }
                else if (Value is string)
                {
                    return ToSingle((string)Value);
                }
                throw new InvalidCastException();
            }
            public static double ToDouble(string Value)
            {
                if (Value is null)
                {
                    return 0d;
                }
                try
                {
                    var i64Value = default(long);
                    if (IsHexOrOctValue(Value, ref i64Value))
                    {
                        return i64Value;
                    }
                    return ParseDouble(Value);
                }
                catch (FormatException e)
                {
                    throw new InvalidCastException(e.Message, e);
                }
            }
            public static double ToDouble(object Value)
            {
                if (Value is null)
                {
                    return 0d;
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToDouble((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return (sbyte)Value;
                }
                else if (Value is byte)
                {
                    return (byte)Value;
                }
                else if (Value is short)
                {
                    return (short)Value;
                }
                else if (Value is ushort)
                {
                    return (ushort)Value;
                }
                else if (Value is int)
                {
                    return (int)Value;
                }
                else if (Value is uint)
                {
                    return (uint)Value;
                }
                else if (Value is long)
                {
                    return (long)Value;
                }
                else if (Value is ulong)
                {
                    return (ulong)Value;
                }
                else if (Value is decimal)
                {
                    return (double)(decimal)Value;
                }
                else if (Value is float)
                {
                    return (double)(float)Value;
                }
                else if (Value is double)
                {
                    return (double)Value;
                }
                else if (Value is string)
                {
                    return ToDouble((string)Value);
                }
                throw new InvalidCastException();
            }
            private static double ParseDouble(string Value)
            {
                System.Globalization.NumberFormatInfo NormalizedNumberFormat;
                var culture = GetCultureInfo();
                var NumberFormat = culture.NumberFormat;
                NormalizedNumberFormat = GetNormalizedNumberFormat(NumberFormat);
                const System.Globalization.NumberStyles flags = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowTrailingSign | System.Globalization.NumberStyles.AllowParentheses | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowCurrencySymbol;
                Value = ToHalfwidthNumbers(Value, culture);
                try
                {
                    return double.Parse(Value, flags, NormalizedNumberFormat);
                }
                catch (FormatException FormatEx) when (!ReferenceEquals(NumberFormat, NormalizedNumberFormat))
                {
                    return double.Parse(Value, flags, NumberFormat);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            public static DateTime ToDate(string Value)
            {
                DateTime ParsedDate;
                const System.Globalization.DateTimeStyles ParseStyle = System.Globalization.DateTimeStyles.AllowWhiteSpaces | System.Globalization.DateTimeStyles.NoCurrentDateDefault;
                var Culture = GetCultureInfo();
                bool result = DateTime.TryParse(ToHalfwidthNumbers(Value, Culture), Culture, ParseStyle, out ParsedDate);
                if (result)
                {
                    return ParsedDate;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
            public static DateTime ToDate(object Value)
            {
                if (Value is null)
                {
                    return default(DateTime);
                }
                if (Value is DateTime)
                {
                    return ToDate((DateTime)Value);
                }
                else if (Value is string)
                {
                    return ToDate((string)Value);
                }
                throw new InvalidCastException();
            }
            public static char ToChar(string Value)
            {
                if (Value is null || Value.Length == 0)
                {
                    return Convert.ToChar(0 & 0xFFFF);
                }
                return Value[0];
            }
            public static char ToChar(object Value)
            {
                if (Value is null)
                {
                    return Convert.ToChar(0 & 0xFFFF);
                }
                if (Value is char)
                {
                    return (char)Value;
                }
                else if (Value is string)
                {
                    return ToChar((string)Value);
                }
                throw new InvalidCastException();
            }
            public static char[] ToCharArrayRankOne(string Value)
            {
                if (Value is null)
                {
                    Value = "";
                }
                return Value.ToCharArray();
            }
            public static char[] ToCharArrayRankOne(object Value)
            {
                if (Value is null)
                {
                    return "".ToCharArray();
                }
                char[] ArrayValue = Value as char[];
                if (ArrayValue is not null && ArrayValue.Rank == 1)
                {
                    return ArrayValue;
                }
                else if (Value is string)
                {
                    return ((string)Value).ToCharArray();
                }
                throw new InvalidCastException();
            }
            public static new string ToString(short Value)
            {
                return Value.ToString();
            }
            public static new string ToString(int Value)
            {
                return Value.ToString();
            }
            [CLSCompliant(false)]
            public static new string ToString(uint Value)
            {
                return Value.ToString();
            }
            public static new string ToString(long Value)
            {
                return Value.ToString();
            }
            [CLSCompliant(false)]
            public static new string ToString(ulong Value)
            {
                return Value.ToString();
            }
            public static new string ToString(float Value)
            {
                return Value.ToString();
            }
            public static new string ToString(double Value)
            {
                return Value.ToString("G");
            }
            public static new string ToString(DateTime Value)
            {
                long TimeTicks = Value.TimeOfDay.Ticks;
                if (TimeTicks == Value.Ticks || Value.Year == 1899 && Value.Month == 12 && Value.Day == 30)
                {
                    return Value.ToString("T");
                }
                else if (TimeTicks == 0L)
                {
                    return Value.ToString("d");
                }
                else
                {
                    return Value.ToString("G");
                }
            }
            public static new string ToString(decimal Value)
            {
                return Value.ToString("G");
            }
            public static new string ToString(object Value)
            {
                if (Value is null)
                {
                    return null;
                }
                else
                {
                    string StringValue = Value as string;
                    if (StringValue is not null)
                    {
                        return StringValue;
                    }
                }
                if (Value is Enum)
                {
                    Value = GetEnumValue(Value);
                }
                if (Value is bool)
                {
                    return ToString((bool)Value);
                }
                else if (Value is sbyte)
                {
                    return ((sbyte)Value).ToString();
                }
                else if (Value is byte)
                {
                    return ((byte)Value).ToString();
                }
                else if (Value is short)
                {
                    return ((short)Value).ToString();
                }
                else if (Value is ushort)
                {
                    return ((ushort)Value).ToString();
                }
                else if (Value is int)
                {
                    return ((int)Value).ToString();
                }
                else if (Value is uint)
                {
                    return ((uint)Value).ToString();
                }
                else if (Value is long)
                {
                    return ((long)Value).ToString();
                }
                else if (Value is ulong)
                {
                    return ((ulong)Value).ToString();
                }
                else if (Value is decimal)
                {
                    return ((decimal)Value).ToString();
                }
                else if (Value is float)
                {
                    return ((float)Value).ToString();
                }
                else if (Value is double)
                {
                    return ((double)Value).ToString();
                }
                else if (Value is char)
                {
                    return ToString((char)Value);
                }
                else if (Value is DateTime)
                {
                    return ToString((DateTime)Value);
                }
                else
                {
                    char[] CharArray = Value as char[];
                    if (CharArray is not null)
                    {
                        return new string(CharArray);
                    }
                }
                throw new InvalidCastException();
            }
            public static new string ToString(bool Value)
            {
                if (Value)
                {
                    return bool.TrueString;
                }
                else
                {
                    return bool.FalseString;
                }
            }
            public static new string ToString(byte Value)
            {
                return Value.ToString();
            }
            public static new string ToString(char Value)
            {
                return Value.ToString();
            }
            internal static System.Globalization.CultureInfo GetCultureInfo()
            {
                return System.Globalization.CultureInfo.CurrentCulture;
            }
            internal static string ToHalfwidthNumbers(string s, System.Globalization.CultureInfo culture)
            {
                return s;
            }
            internal static bool IsHexOrOctValue(string Value, ref long i64Value)
            {
                char ch;
                int Length;
                var FirstNonspace = default(int);
                string TmpValue;
                Length = Value.Length;
                while (FirstNonspace < Length)
                {
                    ch = Value[FirstNonspace];
                    if (ch == '&' && FirstNonspace + 2 < Length)
                    {
                        goto GetSpecialValue;
                    }
                    if (ch != Strings.ChrW(32) && ch != Strings.ChrW(0x3000))
                    {
                        return false;
                    }
                    FirstNonspace += 1;
                }
                return false;
            GetSpecialValue:
                ;

                ch = char.ToLowerInvariant(Value[FirstNonspace + 1]);
                TmpValue = ToHalfwidthNumbers(Value.Substring(FirstNonspace + 2), GetCultureInfo());
                if (ch == 'h')
                {
                    i64Value = Convert.ToInt64(TmpValue, 16);
                }
                else if (ch == 'o')
                {
                    i64Value = Convert.ToInt64(TmpValue, 8);
                }
                else
                {
                    throw new FormatException();
                }
                return true;
            }
            internal static bool IsHexOrOctValue(string Value, ref ulong ui64Value)
            {
                char ch;
                int Length;
                var FirstNonspace = default(int);
                string TmpValue;
                Length = Value.Length;
                while (FirstNonspace < Length)
                {
                    ch = Value[FirstNonspace];
                    if (ch == '&' && FirstNonspace + 2 < Length)
                    {
                        goto GetSpecialValue;
                    }
                    if (ch != Strings.ChrW(32) && ch != Strings.ChrW(0x3000))
                    {
                        return false;
                    }
                    FirstNonspace += 1;
                }
                return false;
            GetSpecialValue:
                ;

                ch = char.ToLowerInvariant(Value[FirstNonspace + 1]);
                TmpValue = ToHalfwidthNumbers(Value.Substring(FirstNonspace + 2), GetCultureInfo());
                if (ch == 'h')
                {
                    ui64Value = Convert.ToUInt64(TmpValue, 16);
                }
                else if (ch == 'o')
                {
                    ui64Value = Convert.ToUInt64(TmpValue, 8);
                }
                else
                {
                    throw new FormatException();
                }
                return true;
            }
            public static T ToGenericParameter<T>(object Value)
            {
                if (Value is null)
                {
                    return default(T);
                }
                var reflectedType = typeof(T);
                if (Equals(reflectedType, typeof(bool)))
                {
                    return (T)(object)ToBoolean(Value);
                }
                else if (Equals(reflectedType, typeof(sbyte)))
                {
                    return (T)(object)ToSByte(Value);
                }
                else if (Equals(reflectedType, typeof(byte)))
                {
                    return (T)(object)ToByte(Value);
                }
                else if (Equals(reflectedType, typeof(short)))
                {
                    return (T)(object)ToShort(Value);
                }
                else if (Equals(reflectedType, typeof(ushort)))
                {
                    return (T)(object)ToUShort(Value);
                }
                else if (Equals(reflectedType, typeof(int)))
                {
                    return (T)(object)ToInteger(Value);
                }
                else if (Equals(reflectedType, typeof(uint)))
                {
                    return (T)(object)ToUInteger(Value);
                }
                else if (Equals(reflectedType, typeof(long)))
                {
                    return (T)(object)ToLong(Value);
                }
                else if (Equals(reflectedType, typeof(ulong)))
                {
                    return (T)(object)ToULong(Value);
                }
                else if (Equals(reflectedType, typeof(decimal)))
                {
                    return (T)(object)ToDecimal(Value);
                }
                else if (Equals(reflectedType, typeof(float)))
                {
                    return (T)(object)ToSingle(Value);
                }
                else if (Equals(reflectedType, typeof(double)))
                {
                    return (T)(object)ToDouble(Value);
                }
                else if (Equals(reflectedType, typeof(DateTime)))
                {
                    return (T)(object)ToDate(Value);
                }
                else if (Equals(reflectedType, typeof(char)))
                {
                    return (T)(object)ToChar(Value);
                }
                else if (Equals(reflectedType, typeof(string)))
                {
                    return (T)ToString(Value);
                }
                else
                {
                    return (T)Value;
                }
            }
        }
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class ProjectData
        {
            private ProjectData()
            {
            }
            public static void SetProjectError(Exception ex)
            {
            }
            public static void SetProjectError(Exception ex, int lErl)
            {
            }
            public static void ClearProjectError()
            {
            }
        }
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class Utils
        {
            private Utils()
            {
            }
            public static Array CopyArray(Array arySrc, Array aryDest)
            {
                if (arySrc is null)
                {
                    return aryDest;
                }
                int lLength;
                lLength = arySrc.Length;
                if (lLength == 0)
                {
                    return aryDest;
                }
                if (aryDest.Rank != arySrc.Rank)
                {
                    throw new InvalidCastException();
                }
                int iDim;
                var loopTo = aryDest.Rank - 2;
                for (iDim = 0; iDim <= loopTo; iDim++)
                {
                    if (aryDest.GetUpperBound(iDim) != arySrc.GetUpperBound(iDim))
                    {
                        throw new ArrayTypeMismatchException();
                    }
                }
                if (lLength > aryDest.Length)
                {
                    lLength = aryDest.Length;
                }
                if (arySrc.Rank > 1)
                {
                    int LastRank = arySrc.Rank;
                    int lenSrcLastRank = arySrc.GetLength(LastRank - 1);
                    int lenDestLastRank = aryDest.GetLength(LastRank - 1);
                    if (lenDestLastRank == 0)
                    {
                        return aryDest;
                    }
                    int lenCopy = lenSrcLastRank > lenDestLastRank ? lenDestLastRank : lenSrcLastRank;
                    int i;
                    var loopTo1 = arySrc.Length / lenSrcLastRank - 1;
                    for (i = 0; i <= loopTo1; i++)
                        Array.Copy(arySrc, i * lenSrcLastRank, aryDest, i * lenDestLastRank, lenCopy);
                }
                else
                {
                    Array.Copy(arySrc, aryDest, lLength);
                }
                return aryDest;
            }
        }
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class ObjectFlowControl
        {
            internal sealed class ForLoopControl
            {
                public static bool ForNextCheckR4(float count, float limit, float StepValue)
                {
                    if (StepValue >= 0f)
                    {
                        return count <= limit;
                    }
                    else
                    {
                        return count >= limit;
                    }
                }
                public static bool ForNextCheckR8(double count, double limit, double StepValue)
                {
                    if (StepValue >= 0d)
                    {
                        return count <= limit;
                    }
                    else
                    {
                        return count >= limit;
                    }
                }
                public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue)
                {
                    if (StepValue >= 0m)
                    {
                        return count <= limit;
                    }
                    else
                    {
                        return count >= limit;
                    }
                }
            }
        }
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class StaticLocalInitFlag
        {
            public short State;
        }
        [Embedded()]
        [DebuggerNonUserCode()]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        internal sealed class IncompleteInitialization : Exception
        {
            public IncompleteInitialization() : base()
            {
            }
        }
        [Embedded()]
        [AttributeUsage(AttributeTargets.Class, Inherited = false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        internal sealed class StandardModuleAttribute : Attribute
        {
        }
        [Embedded()]
        [AttributeUsage(AttributeTargets.Class, Inherited = false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        internal sealed class DesignerGeneratedAttribute : Attribute
        {
        }
        [Embedded()]
        [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        internal sealed class OptionCompareAttribute : Attribute
        {
        }
        [Embedded()]
        [AttributeUsage(AttributeTargets.Class, Inherited = false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.CompilerServices.CompilerGenerated()]
        internal sealed class OptionTextAttribute : Attribute
        {
        }
    }
    [Embedded()]
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    internal sealed class HideModuleNameAttribute : Attribute
    {
    }
    [Embedded()]
    [DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    [StandardModule]
    internal static class Strings
    {
        public static char ChrW(int CharCode)
        {
            if (CharCode < -32768 || CharCode > 65535)
            {
                throw new ArgumentException();
            }
            return Convert.ToChar(CharCode & 0xFFFF);
        }
        public static int AscW(string String)
        {
            if (String is null || String.Length == 0)
            {
                throw new ArgumentException();
            }
            return AscW(String[0]);
        }
        public static int AscW(char String)
        {
            return AscW(String);
        }
    }
    [Embedded()]
    [DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    [StandardModule]
    internal static class Constants
    {
        public const string vbCrLf = Conversions.ToString(Strings.ChrW(13)) + Strings.ChrW(10);
        public const string vbNewLine = Conversions.ToString(Strings.ChrW(13)) + Strings.ChrW(10);
        public const string vbCr = "\r";
        public const string vbLf = "\n";
        public const string vbBack = "\b";
        public const string vbFormFeed = "\f";
        public const string vbTab = "\t";
        public const string vbVerticalTab = "\v";
        public const string vbNullChar = "\0";
        public const string vbNullString = null;
    }
}