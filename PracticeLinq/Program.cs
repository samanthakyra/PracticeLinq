using System;
using System.Collections.Generic;
using System.Linq;

List<string> videoGames = new()
            {
                "COD",
                "Fall Guys",
                "Fortnite",
                "Halo",
                "Mario Party"
            };
videoGames.OrderBy(videoGames => videoGames.Length)
    .ThenBy(videoGames => videoGames)
    .ToList()
    .ForEach(videoGames => Console.WriteLine(videoGames));