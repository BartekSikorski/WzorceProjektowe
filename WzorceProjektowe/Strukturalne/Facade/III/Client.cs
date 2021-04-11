namespace WzorceProjektowe.Strukturalne.Facade.III
{
    public class Client
    {
        public static void Execute()
        {
            IJsonCoverter j = null;
            IByteArrayConveter b = null;
            IXmlConverter x = null;

            var converter = new ConverterFacade(j, x, b);
            var json = converter.ToJson();
        }
    }
}