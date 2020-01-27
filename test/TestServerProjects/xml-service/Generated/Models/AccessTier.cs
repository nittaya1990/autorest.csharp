// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace xml_service.Models
{
    /// <summary> MISSING·SCHEMA-DESCRIPTION-CHOICE. </summary>
    public readonly partial struct AccessTier : IEquatable<AccessTier>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AccessTier"/> values are the same. </summary>
        public AccessTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P4Value = "P4";
        private const string P6Value = "P6";
        private const string P10Value = "P10";
        private const string P20Value = "P20";
        private const string P30Value = "P30";
        private const string P40Value = "P40";
        private const string P50Value = "P50";
        private const string HotValue = "Hot";
        private const string CoolValue = "Cool";
        private const string ArchiveValue = "Archive";

        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P4 { get; } = new AccessTier(P4Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P6 { get; } = new AccessTier(P6Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P10 { get; } = new AccessTier(P10Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P20 { get; } = new AccessTier(P20Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P30 { get; } = new AccessTier(P30Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P40 { get; } = new AccessTier(P40Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier P50 { get; } = new AccessTier(P50Value);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier Hot { get; } = new AccessTier(HotValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier Cool { get; } = new AccessTier(CoolValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static AccessTier Archive { get; } = new AccessTier(ArchiveValue);
        /// <summary> Determines if two <see cref="AccessTier"/> values are the same. </summary>
        public static bool operator ==(AccessTier left, AccessTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessTier"/> values are not the same. </summary>
        public static bool operator !=(AccessTier left, AccessTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessTier"/>. </summary>
        public static implicit operator AccessTier(string value) => new AccessTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessTier other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
