﻿using ModernSpotifyUWP.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ModernSpotifyUWP.SpotifyApi
{
    public class Playlist : ApiBase
    {
        public async Task<Model.Playlist> GetPlaylist(string playlistId)
        {
            StoreEventHelper.Log("api:getplaylist");

            var result = await SendRequestWithTokenAsync($"https://api.spotify.com/v1/playlists/{playlistId}", HttpMethod.Get);
            var resultString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Model.Playlist>(resultString);
        }

    }
}