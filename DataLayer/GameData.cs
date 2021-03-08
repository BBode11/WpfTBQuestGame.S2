using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    public class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Brandon",
                Age = 24,
                LocationId = 0,
                Health = 100,
                Lives = 3,
                Currency = 125
            };
        }
        /// <summary>
        /// Start up message, shows after filling out player setup
        /// </summary>
        /// <returns></returns>
        public static List<string> StartUpMessage()
        {
            return new List<string>()
            {
                "After getting laid off of work you decided you wanted to do some home improvements in your spare time." +
                "The only thing is you do not have all the tools and materials you need." +
                "You decided to go to the hardware store just down the road." +
                "You don't know it yet, but it is about to be the experience of your lifetime."
            };
        }
        /// <summary>
        /// Map locations and descriptions
        /// </summary>
        /// <returns></returns>
        public static Map MapData()
        {
            return new Map()
            {
                MapLocations = new Location[]
                {
                    new Location()
                    {
                        Id = 0,
                        Name = "Isle 1",
                        Description = "(Treated Lumber) \n Down this isle you can find plywood, 2x4's and oriented strand board." ,

                    },

                    new Location()
                    {
                        Id = 1,
                        Name = "Isle 2",
                        Description = "(Non-Treated Lumber) \n Down this isle you can find plywood, 2x4's and oriented strand board. "
                    },

                    new Location()
                    {
                        Id = 2,
                        Name = "Isle 3",
                        Description = "(Saws) \n There are jig, circular, and miter saws down this isle. There also appears to be a worker stocking the shelves."
                    },
                    new Location()
                    {
                        Id = 3,
                        Name = "Isle 4",
                        Description = "(Drills and Bits) \n There are many things down this isle including, cordless and regular drills, impact drivers, with many different bits." +
                        "The bits include a forstner, metal, and wood bits."
                    },
                    new Location()
                    {
                        Id = 4,
                        Name = "Isle 5",
                        Description = "(Light Fixtures) \n Down this isle there are many things from LED lights to lava lamps. One of the lights appears to be broken."
                    },
                    new Location()
                    {
                        Id = 5,
                        Name = "Isle 6",
                        Description = "(Lawn and Outdoor) \n You are amazed when you go down this isle people are jousting on lawn mowers with weed whackers and you get hit by one of the rogue lawn mowers." +
                        "You lose half of your life and barely make it out of the isle alive. Hopefully you do not have to go back down there.",
                        ModifyHealth = 50

                    },
                    new Location()
                    {
                        Id = 6,
                        Name = "Isle 7",
                        Description = "(Outdoor Furniture / Grills) \n Wow you thought the last isle was weird. The townies are throwing their own BBQ in this isle and one of the townies asks if you brought a dish to pass."
                    },
                    new Location()
                    {
                        Id = 7,
                        Name = "Isle 8",
                        Description = "(Gardening) \n The townies apparently left their means of transportation in this isle and there is random horses, goats, and pigs digging through the fertilizer."
                    },
                    new Location()
                    {
                        Id = 8,
                        Name = "Isle 9",
                        Description = "(Nails and Screws) \n Down this isle you dan find nothing but nails and screws of different assortments."

                    },
                    new Location()
                    {
                        Id = 9,
                        Name = "Isle 10",
                        Description = "(Paint and Stains) \n In this isle there is deck stain, outdoor paint and primer, polyurethane and indoor paint."
                    },
                    new Location()
                    {
                        Id = 10,
                        Name = "Checkout",
                        Description = "(Checkout) \n"
                    },
                },

                CurrentLocationId = 0,

            };
        }
    }
}

