// Richard Johnson
// 10-26-22
// This API will take the user's input through the URL, and convert it to an int. It will then do some math to figure out the reverse order of the numbers, and print out the reverse order for the user to see.

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    // This route will need to be added to the URL along with "/ReverseIt/" in order for the API to work. {userInput} should be replaced by the numbers the user wants to put in
    [Route("Reverse/{userInput}")]

    public int ReverseIt(string userInput)
    {
        // This is where we will declare our ints and our bool
        int num = 0;
        int reverseNum = 0;
        bool isNumber;

        // The program will take the user's input from the URL and verify that it is a whole number by turning it into an int
        isNumber = Int32.TryParse(userInput, out num);
        
        if(isNumber == true)
        {
            while(num > 0)
            {
                // The program will take the number the user entered and try to find the remainder, which will be used to figure out the reverse order
                int remainder = num % 10;
                reverseNum = (reverseNum * 10) + remainder; 
                num = num / 10;
            }
        }
        // After the process of calculating the reverse order of the numbers that have been entered, the API will return the value of the reversed number to the screen
        return reverseNum;
    }
}
