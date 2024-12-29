using ChainOfResponsibility.Solution;

var validator = new Validator();
var authenticator = new Authenticator();
var logger = new Logger();

validator.SetNextHandler(authenticator).SetNextHandler(logger);

var validHttpRequest = new HttpRequest("danny123", "123123123");
var invalidHttpRequest = new HttpRequest("111", "111");

var server = new WebServer(validator);
server.Handle(validHttpRequest);
server.Handle(invalidHttpRequest);
