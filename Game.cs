using Microsoft.SemanticKernel.AI.ChatCompletion;
using Microsoft.SemanticKernel;
using System.Text;
using System.Resources;

namespace DungeonMaster;

public class Game
{
    public async Task Run()
    {
        string aoaiEndpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")!;
        string aoaiApiKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY")!;
        string aoaiModel = "Gpt35Turbo_0301";

        // Get reference to the resources object
        ResourceManager resourceManager = new("DungeonMaster.Properties.Resources", typeof(Game).Assembly);
        string gameLoadMessage = resourceManager.GetString("GameLoadMessage")!;
        string initialMessage = resourceManager.GetString("InitialMessage")!;
        string gameInstructions = resourceManager.GetString("GameInstructions")!;
        string playerPrompt = resourceManager.GetString("PlayerPrompt")!;
        string messageSeparator = resourceManager.GetString("MessageSeparator")!;


        // Initialize the kernel
        KernelBuilder kernalBuilder = new KernelBuilder();
        IKernel kernel = kernalBuilder
            .WithAzureOpenAIChatCompletionService(aoaiModel, aoaiEndpoint, aoaiApiKey)
            .Build();

        // Create a new chat
        IChatCompletion ai = kernel.GetService<IChatCompletion>();
        ChatHistory chat = ai.CreateNewChat(gameInstructions);
        StringBuilder answer = new();

        Console.WriteLine(gameLoadMessage);
        Console.WriteLine(initialMessage);
        Console.WriteLine();


        // Game question and answer loop
        while (true)
        {
            Console.WriteLine(messageSeparator);
            Console.WriteLine("");
            Console.Write(playerPrompt);
            var question = Console.ReadLine()!;
            chat.AddUserMessage(question);

            answer.Clear();
            await foreach (string message in ai.GenerateMessageStreamAsync(chat))
            {
                Console.Write(message);
                answer.Append(message);
            }

            Console.WriteLine();
            chat.AddAssistantMessage(answer.ToString());
            Console.WriteLine();
        }
    }
}
