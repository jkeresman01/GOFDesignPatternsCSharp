// GOF Command pattern

using Command.Solution;

var light = new Light();

var turnOnCommand = new TurnOnCommand(light);
var turnOffCommand = new TurnOffCommand(light);
var dimCommand = new DimCommand(light);

var remoteController = new RemoteController(turnOnCommand);
remoteController.PressButton();

remoteController.Command = turnOffCommand;
remoteController.PressButton();

remoteController.Command = dimCommand;
remoteController.PressButton();
