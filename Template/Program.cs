using Template;

Console.WriteLine( "Template Behavioral Design Pattern example" );

AlgebraExpert akgebraExpert = new();
akgebraExpert.SolveTheProblem();

GeometryExpert geometryExpert = new GeometryExpert();
geometryExpert.SolveTheProblem();

SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper();
softwareDeveloper.SolveTheProblem();
