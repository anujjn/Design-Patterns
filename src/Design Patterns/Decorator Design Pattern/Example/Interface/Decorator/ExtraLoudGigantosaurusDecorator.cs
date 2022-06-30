namespace Decorator_Design_Pattern.Example
{
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{this.gigantosaurus.Roar()}!";
        }
    }
}