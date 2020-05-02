// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package
using System;
using System.Collections.Generic;
using System.Diagnostics;
using LibreLancer.Ini;

namespace LibreLancer.Data.Missions
{
    public class StoryCutsceneIni : IniFile
    {
        [Section("CharacterEncounter")]
        public List<StoryEncounter> Encounters = new List<StoryEncounter>();
        [Section("Reserve")]
        public List<StoryReserve> Reserves = new List<StoryReserve>();
        [Section("Char")]
        public List<StoryChar> Chars = new List<StoryChar>();

        public string RefPath; //Used for engine: Hacky
        public StoryCutsceneIni(string path, FileSystem vfs)
        {
            ParseAndFill(path, vfs);
        }
    }

    public class StoryReserve
    {
        [Entry("spot", Multiline = true)]
        public List<string> Spot = new List<string>();
    }

    public class StoryEncounter
    {
        [Entry("location")] public string[] Location;
        [Entry("action")] public string Action;
        [Entry("autoplay", Presence = true)] public bool Autoplay;
        [Entry("offer")] public string Offer;
        [Entry("decision")] public string Decision;
        [Entry("accept")] public string Accept;
        [Entry("reject")] public string Reject;
        [Entry("mission_text_id")] public int MissionTextId;
        [Entry("nooffer_text_id")] public int NoOfferTextId;
        [Entry("relocate_player")] public string RelocatePlayer;
    }
    public class StoryChar
    {
        [Entry("npc")] public string Npc;
        [Entry("actor")] public string Actor;
        [Entry("fidget")] public string Fidget;
        [Entry("spot")] public string Spot;
    }
    
}