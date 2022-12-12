﻿using System.Collections.Immutable;
using SleepingBearSystems.Tools.DataOriented;

namespace SleepingBearSystems.CraftingTools.Domain;

/// <summary>
/// Methods used to support profession data.
/// </summary>
public static class Profession
{
    /// <summary>
    /// Creates a profession record.
    /// </summary>
    /// <param name="id">The profession ID.</param>
    /// <param name="name">The profession name.</param>
    /// <param name="gameId">The game Id.</param>
    /// <returns>A record containing the profession.</returns>
    public static ImmutableDictionary<string, object> CreateRecord(
        string id,
        string name,
        string gameId) =>
        Record
            .Begin()
            .AddProperty("id", id)
            .AddProperty("name", name)
            .AddProperty("gameId", gameId)
            .End();
}
