﻿namespace osuBancho.Core
{
    internal enum Commands
    {
        IN_LocalUserState,
        IN_IrcMessage,
        IN_Logout,
        IN_UNK03, //update user stats?
        IN_HeartBit, //Ping?
        OUT_LoginResult,
        OUT_UNK06, //CommandError?
        OUT_IrcMessage,
        OUT_Ping,
        OUT_IrcUsernameChange, //Obsolete?
        OUT_IrcQuit, //Obsolete?
        OUT_UpdateUserState,
        OUT_UserQuit,
        OUT_SpectatorJoined,
        OUT_SpectatorLeft,
        OUT_SpectateFrames,
        IN_SpectatePlayer,
        IN_StopSpectate,
        IN_SpectateFrames,
        OUT_VersionUpdate,
        IN_ErrorReport,
        IN_CantSpectate,
        OUT_SpectatorCantSpectate,
        const_23,
        const_24,
        IN_IrcMessagePrivate,
        OUT_MatchUpdate,
        OUT_MatchNew,
        OUT_MatchDisband,
        IN_LobbyPart,
        IN_LobbyJoin,
        IN_MatchCreate,
        IN_MatchJoin,
        IN_MatchLeave,
        const_34,
        const_35,
        OUT_MatchJoinSuccess,
        OUT_MatchJoinFail,
        IN_MatchChangeSlot,
        IN_MatchReady,
        IN_MatchLockSlot,
        IN_MatchChangeSettings,
        OUT_FellowSpectatorJoined,
        OUT_FellowSpectatorLeft,
        IN_MatchStart,
        const_45,
        OUT_MatchStart,
        IN_MatchScoreUpdate,
        OUT_MatchScoreUpdate,
        IN_MatchComplete,
        OUT_MatchTransferHost,
        IN_MatchChangeMods,
        IN_MatchLoadComplete,
        OUT_MatchAllPlayersLoaded,
        IN_MatchNoBeatmap,
        IN_MatchNotReady,
        IN_MatchFailed, //Player failed
        OUT_MatchPlayerFailed,
        OUT_MatchComplete,
        IN_MatchHasBeatmap,
        IN_MatchSkipRequest,
        OUT_MatchSkip, //Skip the begin of a beatmap
        const_62,
        IN_ChannelJoin,
        OUT_ChannelJoinSuccess,
        OUT_ChannelAvailable,
        OUT_ChannelRevoked,
        OUT_ChannelAvailableAutoJoin,
        const_68,
        const_69,
        IN_MatchTransferHost,
        OUT_UserTags,
        OUT_FriendsList,
        IN_FriendAdd,
        IN_FriendRemove,
        OUT_ChoProtocol,
        OUT_Announcement,
        const_77,
        const_78,
        const_79,
        const_80,
        OUT_MatchSkipRequest,
        IN_AwayMessage,
        OUT_UpdateUserInfo,
        const_84,
        IN_GetUsersStats,
        const_86,
        IN_InvitePlayer,
        OUT_IrcMessagePrivate,
        const_89,
        IN_MatchChangePassword,
        const_91,
        const_92,
        const_93,
        const_94,
        OUT_UserForLoad,
        OUT_UserForLoadBundle,
        IN_GetUsersInfo,
        const_98,
        const_99,
        const_100,
        const_101,
        const_102,
        const_103,
        const_104,
        const_105,
        OUT_MatchAbort,
        const_107
    }
}