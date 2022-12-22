using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalSelectOptionValue
{
    /// <summary>
    /// The user-facing name of the option, max 100 characters.
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; init; } = null!;

    /// <summary>
    /// The dev-defined value of the option, max 100 characters.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; init; } = null!;

    /// <summary>
    /// An additional description of the option, max 100 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public Optional<string> Description { get; init; }

    /// <summary>
    /// The id, name, and animated properties.
    /// </summary>
    [JsonPropertyName("emoji")]
    public Optional<InternalEmoji> Emoji { get; init; }

    /// <summary>
    /// Whether the client should render this option as selected by default.
    /// </summary>
    [JsonPropertyName("default")]
    public Optional<bool> Default { get; init; }
}