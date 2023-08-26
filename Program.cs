// See https://aka.ms/new-console-template for more information
using System.Reflection;
using CodingReview;


var assembly = Assembly.GetExecutingAssembly();

var isAllReviewsCompleted = AnalyzeAssembly(assembly);

Console.WriteLine(isAllReviewsCompleted ? "All Code Reviews are Completed" : "Not All Completed!");


bool AnalyzeAssembly(Assembly assembly)
{
    var attributes = GetAssemblyAttriButes(assembly);

    Console.WriteLine($"Code Reviews List In {assembly.FullName}: ***** \n");
    
    foreach(var attr in attributes)
    {
        Console.WriteLine(attr);
    }

    Console.WriteLine("\n");

    var isAllCompleted = attributes.All(x => x.IsApproved);

   

    return isAllCompleted;
}

IEnumerable<CodeReview> GetAssemblyAttriButes (Assembly assembly)
{
    var classes = assembly.GetTypes();

    foreach(var type in classes)
    {
        var attrForType = (CodeReview[])type.GetCustomAttributes(typeof(CodeReview), false);
        
        var classAttribue = attrForType.FirstOrDefault();
        if (classAttribue != null)
        {
            yield return classAttribue;

            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var attrForMethod = (CodeReview[])method.GetCustomAttributes(typeof(CodeReview), false);

                var methodAttribue = attrForMethod.FirstOrDefault();
                if (methodAttribue != null)
                {
                    yield return methodAttribue;
                }
            }
        }

        

    }
}
