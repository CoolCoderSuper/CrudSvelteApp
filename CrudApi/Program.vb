Imports System
Imports System.Text
Imports Microsoft.AspNetCore.Authentication.JwtBearer
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.IdentityModel.Tokens

Public Module Program
    Public Sub Main(args As String())
        Dim builder As WebApplicationBuilder = WebApplication.CreateBuilder(args)
        builder.Services.AddControllers()
        builder.Services.AddEndpointsApiExplorer()
        builder.Services.AddSwaggerGen()
        Dim origins = "origins"
        builder.Services.AddCors(Sub(options)
            options.AddPolicy(name:=origins, Sub(b)
                b.AllowAnyOrigin()
                b.AllowAnyHeader()
                b.AllowAnyMethod()
            End Sub)
        End Sub)
        Dim authenticationBuilder = builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
            Sub(options)
                options.SaveToken = True
                options.TokenValidationParameters = New TokenValidationParameters With {.ValidateIssuer = False,
                                                                                        .ValidateLifetime = True,
                                                                                        .ClockSkew = TimeSpan.Zero,
                                                                                        .ValidateAudience = False,
                                                                                        .ValidateIssuerSigningKey = True,
                                                                                        .IssuerSigningKey = New SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration("Jwt:Key")))
                                                                                        }
            End Sub)
        Dim app As WebApplication = builder.Build()
        app.UseSwagger()
        app.UseSwaggerUI()
        'app.UseHttpsRedirection()
        app.UseCors(origins)
        app.UseAuthorization()
        app.MapControllers()
#If DEBUG Then
        app.Run("http://0.0.0.0:5003")
#Else
        app.Run()
#End If
    End Sub
End Module