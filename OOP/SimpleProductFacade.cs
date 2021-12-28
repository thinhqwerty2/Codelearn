namespace OOP
{
    public class SimpleProductFacade
    {
        public DifficultProduct difficultProduct;
        public SimpleProductFacade()
        {
            difficultProduct = new DifficultProduct();
        }
        public void setName(string n)
        {

            char[] chars = n.ToCharArray();
            if (chars.Length > 0)
            {
                difficultProduct.setFirstNameCharacter(chars[0]);
            }
            if (chars.Length > 1)
            {
                difficultProduct.setSecondNameCharacter(chars[1]);
            }
            if (chars.Length > 2)
            {
                difficultProduct.setThirdNameCharacter(chars[2]);
            }
            if (chars.Length > 3)
            {
                difficultProduct.setFourthNameCharacter(chars[3]);
            }
            if (chars.Length > 4)
            {
                difficultProduct.setFifthNameCharacter(chars[4]);
            }
            if (chars.Length > 5)
            {
                difficultProduct.setSixthNameCharacter(chars[5]);
            }
            if (chars.Length > 6)
            {
                difficultProduct.setSeventhNameCharacter(chars[6]);
            }

        }
        public string getName()
        {
            return difficultProduct.getName();
        }
    }
    public class TestFacade
    {
        public TestFacade()
        {
            SimpleProductFacade simpleProductFacade = new SimpleProductFacade();

            simpleProductFacade.setName("printer");

            System.Console.WriteLine("This product is a " + simpleProductFacade.getName());

        }
    }
}
