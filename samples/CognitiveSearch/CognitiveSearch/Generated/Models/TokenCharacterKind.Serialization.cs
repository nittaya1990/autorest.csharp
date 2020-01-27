// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    internal static class TokenCharacterKindExtensions
    {
        public static string ToSerialString(this TokenCharacterKind value) => value switch
        {
            TokenCharacterKind.Letter => "letter",
            TokenCharacterKind.Digit => "digit",
            TokenCharacterKind.Whitespace => "whitespace",
            TokenCharacterKind.Punctuation => "punctuation",
            TokenCharacterKind.Symbol => "symbol",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TokenCharacterKind value.")
        };

        public static TokenCharacterKind ToTokenCharacterKind(this string value) => value switch
        {
            "letter" => TokenCharacterKind.Letter,
            "digit" => TokenCharacterKind.Digit,
            "whitespace" => TokenCharacterKind.Whitespace,
            "punctuation" => TokenCharacterKind.Punctuation,
            "symbol" => TokenCharacterKind.Symbol,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TokenCharacterKind value.")
        };
    }
}
