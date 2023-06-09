

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer().AddSwaggerGen();

var app = builder.Build();
app.UseSwagger().UseSwaggerUI().UseHttpsRedirection();

var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

app.MapGet("/api/numbers/{kind?}", (Kind kind = Kind.All) 
    => kind switch
    {
        Kind.Even => numbers.Where(x => x % 2 == 0),
        Kind.Odd => numbers.Where(x => x % 2 != 0),
        Kind.All => numbers,
        _ => Array.Empty<int>(),
    })
.WithName("GetNumbers")
.WithOpenApi();

app.Run();

enum Kind { Even, Odd, All }

