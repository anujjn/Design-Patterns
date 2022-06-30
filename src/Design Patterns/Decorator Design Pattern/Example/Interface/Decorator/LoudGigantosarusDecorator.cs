namespace Decorator_Design_Pattern.Example
{
    public class LoudGigantosarusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{this.gigantosaurus.Roar()} loudly";
        }
    }
}
