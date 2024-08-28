using System.Diagnostics.Eventing.Reader;

namespace bassant_khaled___sun_wed_8_pm_online___mvc2
{
    public class Program
    {
        public static void Main(string[] args)

        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();                    //register servies (mvc - هتشغل ال MapControllerRoute   )       (register servies after (builder))

            var app = builder.Build();

            app.UseStaticFiles();                                          //to add (middle where) of (bootstrap)

            //app.MapGet("/", () => "Hello World!");                        //default route


            app.UseRouting();                                            //to add (middle where) of routes

            app.UseEndpoints(endpoint =>

            {

                //    endpoint.Map("/Home", async (context) =>                            //routing

                //    {
                //        await context.Response.WriteAsync
                //         ("you are in the home page");
                //    });

                //    endpoint.Map("/products", async (context) =>

                //    {
                //        await context.Response.WriteAsync
                //         ("you are in the products page");
                //    });


                //    //-------------------------------------------------------------------------------------


                //    endpoint.MapGet("/product/{id}", async (context) =>                     //using parameters with routing

                //    {
                //        var id = Convert.ToInt32(context.Request.RouteValues["id"]);

                //        await context.Response.WriteAsync

                //       ($"you are in the product page with id {id}");

                //    });

                //    //----------------------------------------------------------------------------------

                //    endpoint.MapGet("/books/author/{authorname}/{bookid}", async (context) =>     //using more than one parameter

                //    {
                //        var authorname = Convert.ToString(context.Request.RouteValues["authorname"]);
                //        var bookid = Convert.ToInt32(context.Request.RouteValues["bookid"]);

                //        await context.Response.WriteAsync

                //       ($"you are getting book with bookid {bookid} and author {authorname}");

                //    });

                //    //------------------------------------------------------------------------------------

                //    endpoint.Map("/product/{id?}", async (context) =>                     //using optional parameter {... ?}

                //    {
                //        var id = context.Request.RouteValues["id"];

                //        if (id != null)

                //        {
                //            id = Convert.ToInt32(context.Request.RouteValues["id"]);

                //            await context.Response.WriteAsync

                //           ($"you are in the product page with id {id}");
                //        }

                //        else

                //            await context.Response.WriteAsync
                //            ("u are in the product page");


                //    });

                //    //------------------------------------------------------------------------------------


                //    endpoint.MapGet("/books/author/{authorname:alpha:minlength(5):maxlength(10)}/{bookid}", async (context) =>  //constraints on parameters
                //    {

                //        var authorname = Convert.ToString(context.Request.RouteValues["authorname"]);
                //        var bookid = Convert.ToInt32(context.Request.RouteValues["bookid"]);

                //        await context.Response.WriteAsync

                //        ($"you are getting book with bookid {bookid} and author {authorname}");

                //    });

                //    //----------------------------------------------------------------------------------------

                //    endpoint.MapGet("/products/{id=10}", async (context) =>                     //default value

                //    {
                //        var id = Convert.ToInt32(context.Request.RouteValues["id"]);

                //        await context.Response.WriteAsync

                //       ($"you are in the product page with id {id}");

                //    });

                //---------------------------------------------------------------------------------------

                endpoint.MapControllerRoute                                    //endpoint for (controller)

                (
                name: "default",
                pattern: "/{controller=home}/{action=index}",
                defaults: new {controllers = "home", action = "index"}         //return ("index")

                );





            });




            app.Run();
        }
    }
}
