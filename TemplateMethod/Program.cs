//GOF Template method design pattern

var bevarageMaker = new BevarageMaker(new Tea());
bevarageMaker.Make();

bevarageMaker.Bevarage = new Coffee();
bevarageMaker.Make();

