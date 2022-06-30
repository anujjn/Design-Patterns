using System;

namespace Decorator_Design_Pattern.Example
{
    class DecoratorExample
    {
        public static void DecoratorPatternExample()
        {
            var gigantosaurus = new Gigantosaurus();

            Console.WriteLine(gigantosaurus.Roar());

            var loudGigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);
            var extraLoudGigantosaurus = new ExtraLoudGigantosaurusDecorator(loudGigantosaurus);

            Console.WriteLine(extraLoudGigantosaurus.Roar());
        }
    }
}
