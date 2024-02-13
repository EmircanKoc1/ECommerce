using CoreLayer.Enums;
using CoreLayer.Exceptions;
namespace BusinessLogicLayer.Extensions
{
    public static class CustomExceptionExtensions
    {

        public static void ThrowIfNull<T>(this T variable, string message, CustomException exception = CustomException.DefaultException)
        {
            if (variable is null)
                #region old switch case 
                //switch (exception)
                //{
                //    case CustomException.ParameterValueNullException:
                //        throw new ParameterValueNullException(message);

                //    case CustomException.EntityNotFoundException:
                //        throw new EntityNotFoundException(message);

                //    case CustomException.EntityAlreadyExistsException:
                //        throw new EntityAlreadyExistsException(message);

                //    case CustomException.DefaultException:
                //        throw new DefaultException(message);

                //};
                #endregion
                throw exception switch
                {
                    CustomException.ParameterValueNullException => new ParameterValueNullException(message),
                    CustomException.EntityNotFoundException => new EntityNotFoundException(message),
                    CustomException.EntityAlreadyExistsException => new EntityAlreadyExistsException(message),
                    CustomException.ForeignKeyOrNavigationPropertyNullException => new ForeignKeyOrNavigationPropertyNullException(message),
                    CustomException.DefaultException => new DefaultException(message),
                    _ => new DefaultException(message),
                };


        }




    }
}
