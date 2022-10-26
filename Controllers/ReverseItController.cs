// Richard Johnson
// 10-26-22
// This API will take the user's input through the URL, and convert it to an int. It will then do some math to figure out the reverse order of the numbers, and print out the reverse order for the user to see.

// Peer Review: 

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("Reverse/{input}")]

    public int ReverseIt(string userInput)
    {
        int num = 0;
        int reverseNum = 0;
        bool isNumber;

        isNumber = Int32.TryParse(userInput, out num);
        
    }
}
