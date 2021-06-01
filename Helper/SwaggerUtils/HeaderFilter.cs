using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace personalAPI.Helper.SwaggerUtils
{
    public class HeaderFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "Authorization Bearer",
                Description= "Bearer Authorization token",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema() {Type = "String"},
            });
        }
    }
}