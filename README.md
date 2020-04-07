# VietnameseUrlRewrite
Vietnamese String rewrite to Url for SEO

## Example
UrlWrite.Url(**string**);
```csharp
public IActionResult Index()
{
    string a = "Đây là Url bài viết số n";
    string b = UrlWrite.Url(a);
    return Content(b);
}
```

## How do I use it?

1. Install ["VietnameseUrlRewrite"](https://www.nuget.org/packages/VietnameseUrlRewrite) via [NuGet](http://nuget.org)

```
Install-Package VietnameseUrlRewrite -Version 1.0.1
```

2. In your controller code or Razor page, call **UrlWrite.Url(string)** if you want to convert string to url.

## Using .Net Standard 2.0
Use .net Standard should be suitable for all projects .Net Framework and .Net Core

## Authors

* **Bảo Dương** - *Initial work* - [baoduong-dev](https://github.com/baoduong-dev)

## License

Licensed under the [MIT License](http://www.opensource.org/licenses/mit-license.php).
