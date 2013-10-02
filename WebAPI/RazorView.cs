using RazorEngine;
using RazorEngine.Templating;

namespace WebAPI
{
  public class RazorView
  {
    private readonly ExecuteContext _context = new ExecuteContext();

    public string TemplateName { get; set; }
    public string Template { get; set; }
    public object Model { get; set; }
    public dynamic ViewBag
    {
      get
      {
        return _context.ViewBag;
      }
    }

    public RazorView()
    {
    }

    public RazorView(string templateName)
    {
      TemplateName = templateName;
    }

    public RazorView(string templateName, object model)
      : this(templateName)
    {
      Model = model;
    }

    public string Run()
    {
      string content = null;
      if (!string.IsNullOrEmpty(TemplateName))
      {
        content =
            Razor.Resolve(TemplateName, Model).Run(_context);
      }
      else if (!string.IsNullOrEmpty(Template))
      {
        content =
            Razor.Parse(Template, Model);
      }

      return content;
    }
  }
}
