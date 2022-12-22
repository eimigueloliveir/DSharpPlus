using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal.Gateway.Payloads;

/// <summary>
/// A user's presence is their current state on a guild. This event is sent when a user's presence or info, such as name or avatar, is updated.
/// </summary>
public sealed record InternalUpdatePresencePayload
{
    /// <summary>
    /// The user presence is being updated for.
    /// </summary>
    [JsonPropertyName("user")]
    public InternalUser User { get; init; } = null!;

    /// <summary>
    /// The id of the guild.
    /// </summary>
    [JsonPropertyName("guild_id")]
    public Snowflake GuildId { get; init; } = null!;

    /// <summary>
    /// Either "idle", "dnd", "online", or "offline".
    /// </summary>
    [JsonPropertyName("status")]
    public DiscordStatusType Status { get; init; }

    /// <summary>
    /// The user's current activities.
    /// </summary>
    [JsonPropertyName("activities")]
    public IReadOnlyList<InternalActivity> Activities { get; init; } = Array.Empty<InternalActivity>();

    /// <summary>
    /// The user's platform-dependent status.
    /// </summary>
    [JsonPropertyName("client_status")]
    public InternalClientStatus ClientStatus { get; init; } = null!;
}