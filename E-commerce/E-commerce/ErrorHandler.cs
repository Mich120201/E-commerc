namespace ecommerce;

/*WARNING: this is not a static class and so the exceptions list will be destructed if the instantiated object
  calls the deconstructor.
  Please be aware where the application destruct the instantiated object. 

  DO NOT make more than one instance in the program flow as it could potentially bring you to loose 
  knoledge where the exceptions are stored and so make void calls from the instances.
 */
public sealed class ErrorHandler
{
    private readonly ILogger _logger;
    private List<Exception> _Exceptions;

    public ErrorHandler(ILogger logger)
    {
        _logger = logger;
        _Exceptions = new();
    }

    public void NewException(Exception ex)
    {
        _Exceptions.Add(ex);
    }

    //This method rise all the exception stored in the list _Exceptions
    public void RiseExceptions()
    {
        //Message containing the source of the exception and the message
        string message = string.Empty;
        foreach (var ex in _Exceptions)
        {
            List<Exception> innestedExceptions = _InnerExceptions(ex);
            foreach (var _ex in innestedExceptions)
            {
                message += " | " + _ex.Source + ": " + _ex.Message;
            }
            _logger.LogError(message);
        }


    }

    //Find if there are present inner exceptions recursively and return a list.
    private List<Exception> _InnerExceptions(Exception ex)
    {
        List<Exception> innestedExceptions = new();
        if (ex.InnerException != null)
        {
            innestedExceptions.AddRange(_InnerExceptions(ex.InnerException));
            return innestedExceptions;
        }
        else
        {
            innestedExceptions.Add(ex);
            return innestedExceptions;
        }
    }
}
