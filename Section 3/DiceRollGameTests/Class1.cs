#nullable disable warnings

using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

using DiceRollGame.DiceGame;
using DiceRollGame;

namespace DiceRollGameTests;

public class GameTests
{
    private Mock<IDice> _diceMock;
    private Mock<IUserCommunication> _userCommunicationMock;
    private Game _cut;

    [SetUp]
    public void SetUp()
    {
        _diceMock = new Mock<IDice>();
        _userCommunicationMock = new Mock<IUserCommunication>();
        _cut = new Game(_diceMock.Object, _userCommunicationMock.Object);
    }

    [Test]
    public void Play_ShallWin_IfUserGuessesRightOnFirstTry()
    {
        const int NumberRolled = 3;
        _diceMock.Setup(mock => mock.Sides).Returns(6);
        _diceMock.Setup(mock => mock.Roll()).Returns(NumberRolled);
        _userCommunicationMock.Setup(mock => mock.CollectGuess(It.IsAny<string>()))
            .Returns(NumberRolled);

        var result = _cut.Play();

        Assert.AreEqual(Results.Win, result);
    }

    [Test]
    public void Play_ShallWin_IfUserGuessesRightOnThirdTry()
    {
        const int NumberRolled = 3;
        _diceMock.Setup(mock => mock.Sides).Returns(6);
        _diceMock.Setup(mock => mock.Roll()).Returns(NumberRolled);
        _userCommunicationMock.SetupSequence(mock => mock.CollectGuess(It.IsAny<string>()))
            .Returns(1)
            .Returns(2)
            .Returns(NumberRolled);

        var result = _cut.Play();

        Assert.AreEqual(Results.Win, result);
    }

    [Test]
    public void Play_ShallLose_IfUserNeverGuessesRight()
    {
        const int NumberRolled = 3;
        const int UserGuess = 1;
        _diceMock.Setup(mock => mock.Sides).Returns(6);
        _diceMock.Setup(mock => mock.Roll()).Returns(NumberRolled);
        _userCommunicationMock.Setup(mock => mock.CollectGuess(It.IsAny<string>()))
            .Returns(UserGuess);

        var result = _cut.Play();

        Assert.AreEqual(Results.Lose, result);
    }

    [Test]
    public void Play_ShallLose_IfGuessesNumberAfterTriesFinishes()
    {
        const int NumberRolled = 3;
        _diceMock.Setup(mock => mock.Sides).Returns(6);
        _diceMock.Setup(mock => mock.Roll()).Returns(NumberRolled);
        _userCommunicationMock.SetupSequence(mock => mock.CollectGuess(It.IsAny<string>()))
            .Returns(1)
            .Returns(2)
            .Returns(4)
            .Returns(NumberRolled);

        var result = _cut.Play();

        Assert.AreEqual(Results.Lose, result);
    }

    [Test]
    public void Play_GreetingStringShows_OnPlayStartUp()
    {
        const int NumberRolled = 3;
        _diceMock.Setup(mock => mock.Sides).Returns(NumberRolled);
        _diceMock.Setup(mock => mock.Roll()).Returns(NumberRolled);
        _userCommunicationMock.Setup(mock => mock.CollectGuess(It.IsAny<string>()))
            .Returns(NumberRolled);
        var result = _cut.Play();
        _userCommunicationMock.Verify(mock => mock.PrintMessage(
            string.Format(Resources.Greeting, 3)), Times.Once());
    }
}
