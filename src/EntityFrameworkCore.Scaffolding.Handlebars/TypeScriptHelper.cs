﻿using System;

namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// TypeScript Helper
    /// </summary>
    public class TypeScriptHelper : ITypeScriptHelper
    {
        /// <summary>
        /// Convert CLR type to TypeScript type
        /// </summary>
        /// <param name="clrType">CLR type.</param>
        /// <returns>TypeScript type</returns>
        public string TypeName(Type clrType)
        {
            var result = "any";
            if (clrType == typeof(bool) || clrType == typeof(bool?))
                result = "boolean";
            if (clrType == typeof(char) || clrType == typeof(char?)
                || clrType == typeof(string))
                result = "string";
            if (clrType == typeof(DateTime) || clrType == typeof(DateTime?))
                result = "Date";
            if (clrType == typeof(byte) || clrType == typeof(byte?)
                || clrType == typeof(sbyte) || clrType == typeof(sbyte?)
                || clrType == typeof(decimal) || clrType == typeof(decimal?)
                || clrType == typeof(double) || clrType == typeof(double?)
                || clrType == typeof(short) || clrType == typeof(short?)
                || clrType == typeof(ushort) || clrType == typeof(ushort?)
                || clrType == typeof(int) || clrType == typeof(int?)
                || clrType == typeof(uint) || clrType == typeof(uint?)
                || clrType == typeof(long) || clrType == typeof(long?)
                || clrType == typeof(ulong) || clrType == typeof(ulong?)
                || clrType == typeof(float) || clrType == typeof(float?))
                result = "number";
            return result;
        }
    }
}
