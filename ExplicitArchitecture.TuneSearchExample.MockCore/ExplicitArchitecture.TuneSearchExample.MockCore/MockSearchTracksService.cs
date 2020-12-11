using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExplicitArchitecture.TuneSearchExample.Core.Ports;

namespace ExplicitArchitecture.TuneSearchExample.MockCore
{
    public class MockSearchTracksService : ISearchTracksService
    {
        private static List<ICollectionEntity> CreateMock()
        {
            var collection1 =
                new CollectionEntity() {Name = "From Here to Now to You"};
            collection1.Tracks.Add(item: new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "I Got You",
                TrackNumber = 1
            });
            collection1.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "Washing Dishes",
                TrackNumber = 2
            });
            collection1.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "Never Fade",
                TrackNumber = 4
            });
            collection1.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "Don't Believe a Thing I Say",
                TrackNumber = 6
            });
            collection1.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "As I Was Saying",
                TrackNumber = 7
            });
            collection1.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "You Remind Me of You",
                TrackNumber = 8
            });
            collection1.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/87/00/83/8700835d-d21f-d862-d816-62966095521e/source/100x100bb.jpg"),
                CollectionName = "From Here to Now to You",
                DiscNumber = 1,
                TrackName = "Home",
                TrackNumber = 12
            });
            var collection2 = new CollectionEntity()
            {
                Name = "In Between Dreams (Bonus Track Version)"
            };
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Better Together",
                TrackNumber = 1
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Never Know",
                TrackNumber = 2
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Banana Pancakes",
                TrackNumber = 3
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Good People",
                TrackNumber = 4
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "No Other Way",
                TrackNumber = 5
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Staple It Together",
                TrackNumber = 7
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Situations",
                TrackNumber = 8
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Crying Shame",
                TrackNumber = 9
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "If I Could",
                TrackNumber = 10
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Breakdown",
                TrackNumber = 11
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Belle",
                TrackNumber = 12
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Do You Remember",
                TrackNumber = 13
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Constellations",
                TrackNumber = 14
            });
            collection2.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/24/46/97/24469731-f56f-29f6-67bd-53438f59ebcb/source/100x100bb.jpg"),
                CollectionName = "In Between Dreams (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Constellations",
                TrackNumber = 15
            });
            var collection3 = new CollectionEntity()
            {
                Name =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George"
            };
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Upside Down",
                TrackNumber = 1
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Broken",
                TrackNumber = 2
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "People Watching",
                TrackNumber = 3
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Wrong Turn",
                TrackNumber = 4
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Talk of the Town (feat. Kawika Kahiapo)",
                TrackNumber = 5
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Jungle Gym (feat. G. Love)",
                TrackNumber = 6
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "We're Going To Be Friends",
                TrackNumber = 7
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "The Sharing Song",
                TrackNumber = 8
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "The 3 R's",
                TrackNumber = 9
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Lullaby (feat. Matt Costa)",
                TrackNumber = 10
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "My Own Two Hands (feat. Ben Harper)",
                TrackNumber = 11
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Questions",
                TrackNumber = 12
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Supposed To Be",
                TrackNumber = 13
            });
            collection3.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is4-ssl.mzstatic.com/image/thumb/Music123/v4/be/38/d0/be38d058-31ed-c0ea-91e6-12052865fd20/source/100x100bb.jpg"),
                CollectionName =
                    "Jack Johnson and Friends: Sing-A-Longs and Lullabies for the Film Curious George",
                DiscNumber = 1,
                TrackName = "Upside Down (feat. Money Mark)",
                TrackNumber = 14
            });
            var collection4 =
                new CollectionEntity() {Name = "Sleep Through the Static"};
            collection4.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/49/09/ff/4909ffd6-9051-c729-7761-3dfcc183333c/source/100x100bb.jpg"),
                CollectionName = "Sleep Through the Static",
                DiscNumber = 1,
                TrackName = "If I Had Eyes",
                TrackNumber = 6
            });
            var collection5 = new CollectionEntity()
            {
                Name = "To the Sea (Bonus Track Version)"
            };
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "You and Your Heart",
                TrackNumber = 1
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "To the Sea",
                TrackNumber = 2
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "No Good With Faces",
                TrackNumber = 3
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "At Or With Me",
                TrackNumber = 4
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "When I Look Up",
                TrackNumber = 5
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "From the Clouds",
                TrackNumber = 6
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "My Little Girl",
                TrackNumber = 7
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Turn Your Love",
                TrackNumber = 8
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "The Upsetter",
                TrackNumber = 9
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Red Wine, Mistakes, Mythology",
                TrackNumber = 10
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Pictures of People Taking Pictures",
                TrackNumber = 11
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Anything But the Truth",
                TrackNumber = 12
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Only the Ocean",
                TrackNumber = 13
            });
            collection5.Tracks.Add(new TrackEntity()
            {
                ArtistName = "Jack Johnson",
                ArtworkUrl =
                    new Uri(
                        "https://is5-ssl.mzstatic.com/image/thumb/Music118/v4/42/24/53/422453e1-9a78-34e6-6491-3c54469c28ec/source/100x100bb.jpg"),
                CollectionName = "To the Sea (Bonus Track Version)",
                DiscNumber = 1,
                TrackName = "Better Together (feat. Paula Fuga)",
                TrackNumber = 14
            });
            var collections = new List<ICollectionEntity>
            {
                collection1,
                collection2,
                collection3,
                collection4,
                collection5,
            };
            return collections;
        }
        
        public async Task Execute(ISearchTerm inDTO,
            Action<List<ICollectionEntity>> successHandler,
            Action<Exception> errorHandler)
        {
            successHandler(CreateMock());
            await Task.Delay(1);
        }
    }
}