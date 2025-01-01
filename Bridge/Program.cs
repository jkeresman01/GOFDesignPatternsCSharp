using Bridge.Solution;

/*
var lgRemote = new LGRemote();
lgRemote.TurnOn();
lgRemote.TurnOff();

var lgAdvancedRemote = new AdvancedLGRemote();
lgAdvancedRemote.SetChannel(2);

var lgRadioAndTvRemote = new LGRadioAndTvRemote();
lgRadioAndTvRemote.ControlRadio();
lgRadioAndTvRemote.TurnOff();
lgRadioAndTvRemote.TurnOn();
lgRadioAndTvRemote.ControlTv();
*/

var lgRemoteControl = new RemoteControl(new LgDevice());
lgRemoteControl.TurnOff();
lgRemoteControl.TurnOn();

var sonyAdvancedRemote = new AdvancedRemote(new SonyDevice());
sonyAdvancedRemote.TurnOff();
sonyAdvancedRemote.TurnOn();
sonyAdvancedRemote.SetChannel(2);