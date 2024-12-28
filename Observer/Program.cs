// GOF Observer pattern

using Observer.Solution;

var dataSource = new DataSource();

var sheet = new Sheet2(dataSource);
var barChart = new BarChart(dataSource);

dataSource.AddObserver(barChart);
dataSource.AddObserver(sheet);

dataSource.Data = [1,2,3,4,5,6,7,7];