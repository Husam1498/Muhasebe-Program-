
using FluentValidation;

namespace OMPS.WebApi.Midleware
{
    public class ExceptionMidleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch(Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private  Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode=(int)StatusCodes.Status500InternalServerError;

            #region FluentValidation işlemi
            if (ex.GetType()== typeof(ValidationException))
            {
                return context.Response.WriteAsync(new ValidationErorsDetails
                {
                    Erors = ((ValidationException)ex).Errors.Select(x=>x.PropertyName),
                    StatusCode = context.Response.StatusCode
                }.ToString());
            }
            #endregion

            return context.Response.WriteAsync(new ErorResult()
            {
                Message = ex.Message,
                StatusCode = context.Response.StatusCode
            }.ToString());

        }
    }
}
