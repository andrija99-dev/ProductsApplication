namespace ProductsApplication.API.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string resourceType)
            : base($"{resourceType} does not exist or is invalid")
        {

        }
    }
}
