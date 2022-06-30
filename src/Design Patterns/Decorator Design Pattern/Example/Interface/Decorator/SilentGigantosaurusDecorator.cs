namespace Decorator_Design_Pattern.Example.Interface.Decorator
{
    public class SilentGigantosaurusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public SilentGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return "";
        }
    }
}
