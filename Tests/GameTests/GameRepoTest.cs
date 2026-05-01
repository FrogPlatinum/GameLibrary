using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;
using GameLibrary.Infrastructure.Data;
using GameLibrary.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Tests;

[TestClass]
public class GameRepoTest
{
    private DBGameRepo _gameRepo;
    private AppDbContext _context;

    [TestInitialize]
    public void Init()
    {
        var config = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDB")
            .Options;
        
        _context = new AppDbContext(config);
        _context.Database.EnsureCreated();

        _gameRepo = new DBGameRepo(_context);
    }

    [TestMethod]
    public async Task AddAsync()
    {
        //Arrange
        var newGame = new Game(
            id: 1,
            name: "Returnal",
            genre: GameGenre.Roguelite,
            status: GameStatus.InProgress,
            timeToBeat: 100);

        //Act
        var createdGame = await _gameRepo.AddAsync(newGame);

        //Assert
        Assert.IsNotNull(createdGame);
        Assert.AreEqual(1, createdGame.Id);
    }
}
