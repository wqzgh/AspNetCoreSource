// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using System.Text.Json;

namespace Microsoft.AspNetCore.Internal
{
    internal static class SystemTextJsonExtensions
    {
        public static bool CheckRead(this ref Utf8JsonReader reader)
        {
            if (!reader.Read())
            {
                throw new InvalidDataException("Unexpected end when reading JSON.");
            }

            return true;
        }

        public static void EnsureObjectStart(this ref Utf8JsonReader reader)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new InvalidDataException($"Unexpected JSON Token Type '{reader.GetTokenString()}'. Expected a JSON Object.");
            }
        }

        public static string GetTokenString(this ref Utf8JsonReader reader)
        {
            return GetTokenString(reader.TokenType);
        }

        public static string GetTokenString(JsonTokenType tokenType)
        {
            switch (tokenType)
            {
                case JsonTokenType.None:
                    break;
                case JsonTokenType.StartObject:
                    return "Object";
                case JsonTokenType.StartArray:
                    return "Array";
                case JsonTokenType.PropertyName:
                    return "Property";
                default:
                    break;
            }
            return tokenType.ToString();
        }

        public static void EnsureArrayStart(this ref Utf8JsonReader reader)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new InvalidDataException($"Unexpected JSON Token Type '{reader.GetTokenString()}'. Expected a JSON Array.");
            }
        }

        public static string ReadAsString(this ref Utf8JsonReader reader, string propertyName)
        {
            reader.Read();

            if (reader.TokenType != JsonTokenType.String)
            {
                throw new InvalidDataException($"Expected '{propertyName}' to be of type {JsonTokenType.String}.");
            }

            return reader.GetString();
        }

        public static int? ReadAsInt32(this ref Utf8JsonReader reader, string propertyName)
        {
            reader.Read();

            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new InvalidDataException($"Expected '{propertyName}' to be of type {JsonTokenType.Number}.");
            }

            return reader.GetInt32();
        }
    }
}
