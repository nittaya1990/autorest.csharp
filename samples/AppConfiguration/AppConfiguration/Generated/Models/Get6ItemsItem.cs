// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace AppConfiguration.Models
{
    /// <summary> MISSING·SCHEMA-DESCRIPTION-CHOICE. </summary>
    public readonly partial struct Get6ItemsItem : IEquatable<Get6ItemsItem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Get6ItemsItem"/> values are the same. </summary>
        public Get6ItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyValue = "key";
        private const string LabelValue = "label";
        private const string ContentTypeValue = "content_type";
        private const string ValueValue = "value";
        private const string LastModifiedValue = "last_modified";
        private const string TagsValue = "tags";
        private const string LockedValue = "locked";
        private const string EtagValue = "etag";

        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem Key { get; } = new Get6ItemsItem(KeyValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem Label { get; } = new Get6ItemsItem(LabelValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem ContentType { get; } = new Get6ItemsItem(ContentTypeValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem Value { get; } = new Get6ItemsItem(ValueValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem LastModified { get; } = new Get6ItemsItem(LastModifiedValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem Tags { get; } = new Get6ItemsItem(TagsValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem Locked { get; } = new Get6ItemsItem(LockedValue);
        /// <summary> The value &apos;undefined&apos;. </summary>
        public static Get6ItemsItem Etag { get; } = new Get6ItemsItem(EtagValue);
        /// <summary> Determines if two <see cref="Get6ItemsItem"/> values are the same. </summary>
        public static bool operator ==(Get6ItemsItem left, Get6ItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Get6ItemsItem"/> values are not the same. </summary>
        public static bool operator !=(Get6ItemsItem left, Get6ItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Get6ItemsItem"/>. </summary>
        public static implicit operator Get6ItemsItem(string value) => new Get6ItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Get6ItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Get6ItemsItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
