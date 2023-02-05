using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StudentSERVİCE.Exceptions;
using static System.Net.Mime.MediaTypeNames;

namespace Stu_dentWeb_API.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errorsInModelState = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(x => x.ErrorMessage)).ToArray();

                var errorReponse = new ValidationException();

                foreach (var error in errorsInModelState)
                {
                    foreach (var subError in error.Value)
                    {
                        errorReponse.Errors.Add(subError);
                    }
                }

                context.Result = new BadRequestObjectResult(errorReponse);
                return;
            }

            await next();
        }
    }
}
//Bu kod, ASP.NET Core uygulamalarında geçerlilik kontrolü için bir asenkron aksiyon filtresi olarak uygulanmak üzere tasarlanmış bir .NET Core sınıfıdır. Kod aşağıdaki görevleri yerine getirir:

//    ModelState'in geçerli olup olmadığını kontrol eder. ModelState ActionExecutingContext nesnesinin bir özelliğidir ve uygulamanın girdi verilerinin geçerli olup olmadığını belirler.

//    Eğer ModelState geçerli değilse, ModelState içindeki hata mesajlarının listesi ValidationException isimli bir nesnede toplanır.

//    Her bir hata mesajı, errorReponse.Errors listesine eklenir.

//    context.Result nesnesi, BadRequestObjectResult isimli bir nesne ile güncellenir ve hataları içeren errorReponse nesnesi ile birlikte döndürülür.

//    Bu kod, uygulamanın girdi verilerinin geçerlilik kontrolünü yapmasına ve uygun bir şekilde yanıt vermesine olanak tanır.
//}

