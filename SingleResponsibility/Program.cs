﻿using SolidLibrary.Models;
using SolidLibrary.Services;

// Start the application with a welcome message
StandardMessager.WishlistRecorderStartMessage();

StandardMessager.SeparatorMessage();

// Create a record of Baldur's Gate 3
Game game = (Game)Factory.CreateGame();
game.Id = "0002";
game.Title = "Baldur's Gate 3";
game.Subtitle = "";
game.Price = 70.00f;

// Validate the game's id and price
if (!GameValidator.Validate(game))
{
    StandardMessager.WishlistRecorderEndMessage();
    return -1;
}

// Create a wishlist record and add it to the wishlist recorder
RolePlayingGame rpgBaldur = (RolePlayingGame)WishlistRecorder.CreateWishlistedRPG(game);
WishlistRecorder.Record(rpgBaldur);

StandardMessager.SeparatorMessage();

StandardMessager.WishlistRecorderEndMessage();

return 0;

