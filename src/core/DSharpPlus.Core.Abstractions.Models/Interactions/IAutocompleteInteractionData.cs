// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using DSharpPlus.Entities;

using Remora.Rest.Core;

using System.Collections.Generic;

namespace DSharpPlus.Core.Abstractions.Models;

/// <summary>
/// Contains the interaction metadata for application commands during the autocomplete process.
/// </summary>
public interface IAutocompleteInteractionData : IInteractionData
{
    /// <summary>
    /// The snowflake identifier of the invoked command.
    /// </summary>
    public Snowflake Id { get; }

    /// <summary>
    /// The name of the invoked command.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The type of the invoked command.
    /// </summary>
    public DiscordApplicationCommandType Type { get; }

    /// <summary>
    /// Contains resolved users, guild members, roles, channels, messages and attachments related to this
    /// interaction.
    /// </summary>
    public Optional<IResolvedData> Resolved { get; }

    /// <summary>
    /// The parameters and passed values from the user.
    /// </summary>
    public Optional<IReadOnlyList<IAutocompleteInteractionDataOption>> Options { get; }

    /// <summary>
    /// The snowflake identifier of the guild this command is being registered to.
    /// </summary>
    public Optional<Snowflake> GuildId { get; }
}
