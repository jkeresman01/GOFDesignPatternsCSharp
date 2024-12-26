//GOF - State design pattern

// ----------------------- Problem (Violates SOLID) ------------------------------

// using State.Problem;

/*
 
var document = new Document(DocumentState.Moderation, UserRoles.Admin);
Console.WriteLine(document);

document.Publish();

Console.WriteLine(document);


var document2 = new Document(DocumentState.Moderation, UserRoles.Editor);
Console.WriteLine(document2);

document2.Publish();

Console.WriteLine(document2);

*/

// ----------------------- Solution (State design pattern) ------------------------------

using State.Solution;

var document = new Document(UserRoles.Admin);
document.Publish();
