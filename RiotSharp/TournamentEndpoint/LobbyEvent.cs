﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiotSharp.TournamentEndpoint
{
    /// <summary>
    ///     The type of event that was triggered in the lobby (Tournament API).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LobbyEvent
    {
        /// <summary>
        /// Lobby created.
        /// </summary>
        PracticeGameCreatedEvent,

        /// <summary>
        /// Player joins lobby.
        /// </summary>
        PlayerJoinedGameEvent,

        /// <summary>
        /// Player switches teams.
        /// </summary>
        PlayerSwitchedTeamEvent,

        /// <summary>
        /// Player leaves lobby
        /// </summary>
        PlayerQuitGameEvent,

        /// <summary>
        /// Champion selection begins.
        /// </summary>
        ChampSelectStartedEvent,

        /// <summary>
        /// Loading screen begins.
        /// </summary>
        GameAllocationStartedEvent,

        /// <summary>
        /// Game begins.
        /// </summary>
        GameAllocatedToLsmEvent
    }
}
