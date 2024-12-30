using Prototype.Solution;

var circle = new Circle();
circle.Draw();

circle.Radius = 12;
circle.Draw();

var rectangle = new Rectangle();
rectangle.Draw();

rectangle.Width = 12.45;
rectangle.Height = 100.45;

rectangle.Draw();

var circleDuplicate = ShapeActions.Duplicate(circle);
circleDuplicate.Draw();

var rectangleDuplicate = ShapeActions.Duplicate(rectangle);
rectangleDuplicate.Draw();