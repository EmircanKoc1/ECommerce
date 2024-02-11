using CoreLayer.Enums;
using CoreLayer.Exceptions;
namespace BusinessLogicLayer.Extensions
{
    public static class CustomExceptionExtensions
    {

        public static void ThrowIfNull<T>(this T variable, string message, CustomException exception = CustomException.DefaultException)
        {
            if (variable is null)
                switch (exception)
                {
                    case CustomException.ParameterValueNullException:
                        throw new ParameterValueNullException(message);

                    case CustomException.EntityNotFoundException:
                        throw new EntityNotFoundException(message);

                    case CustomException.EntityAlreadyExistsException:
                        throw new EntityAlreadyExistsException(message);

                    case CustomException.DefaultException:
                        throw new DefaultException(message);

                };

        }




    }
}
