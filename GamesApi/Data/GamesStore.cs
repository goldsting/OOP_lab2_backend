using GamesApi.Models;
namespace GamesApi.Data;
public static class GamesStore {
    private static int _nextId = 6;
    public static List<Game> Games { get; } = new() {
        new Game {
            Id = 1,
            Title = "For Honor",
            Genre = "Action",
            ReleaseYear = 2017,
            IsFavourite = false
        }, new Game {
            Id = 2,
            Title = "Fallout 4",
            Genre = "Action RPG",
            ReleaseYear = 2015,
            IsFavourite = true
        },
            new Game {
            Id = 3,
            Title = "Who is Lila?",
            Genre = "Adventure",
            ReleaseYear = 2022,
            IsFavourite = true
        },
            new Game {
            Id = 4,
            Title = "We happy few",
            Genre = "Action adventure",
            ReleaseYear = 2016,
            IsFavourite = true
        },
            new Game {
            Id = 5,
            Title = "Resident Evil: Requiem",
            Genre = "Survival horror",
            ReleaseYear = 2026,
            IsFavourite = false
        }
    };
    public static int NextId() => _nextId++;
}