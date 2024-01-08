using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("")]
public class SayHelloController : Controller
{
    [HttpPost]
    [Route("SayHello/{userName}")]
    public string Speak(string userName)
    {
        return "Hello, " + userName + ".";
    }
}
