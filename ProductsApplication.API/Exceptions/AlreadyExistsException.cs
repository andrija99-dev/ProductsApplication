namespace ProductsApplication.API.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string entityName, string key)
            : base($"{entityName} with identifier '{key}' already exists")
        {

        }
    }
}
