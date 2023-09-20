using MauiWhisper.Models;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.SkillDefinition;
using System.ComponentModel;

namespace MauiWhisper.Tools
{
    public class TranslateSrtSkill
    {
        private readonly ISKFunction translate;

        private const string TranslatorPrompt =
            @"Translate thw following SRT subtitles into the language specified. For example:
[Examples]
Translate: jp
SRT:
1
00:00:00,500 --> 00:00:06,240
Tudor's Biscuit World got the best raps

2
00:00:03,600 --> 00:00:08,820
ever they make them big enough so you

3
00:00:06,240 --> 00:00:11,700
won't be hungry after got bacon egg and

Translated:
1
00:00:00,500 --> 00:00:06,240
チューダーのビスケットワールドは最高のラップを提供しています

2
00:00:03,600 --> 00:00:08,820
彼らはそれらを大きく作るので、あなたは

3
00:00:06,240 --> 00:00:11,700
食後にお腹がすかないでしょう、ベーコン、卵、そして

[End of Examples]

Translate: {{ $translate }}
SRT:
{{ $input }}
        ";

        public TranslateSrtSkill(IKernel kernel)
        {
            this.translate = kernel.CreateSemanticFunction(
               TranslatorPrompt,
               skillName: nameof(TranslateSrtSkill),
               functionName: "TranslateSrt",
               description: "Used by 'TranslateSrt' function.",
               maxTokens: 1024,
               temperature: 0.0,
               topP: 1);
        }

        [SKFunction, SKName("TranslateSrt"), Description("Translate SRT files from one language to another.")]
        public async Task<string> TranslateAsync([Description("An SRT Subtitle file.")] string input, [Description("The language to translate to.")] WhisperLanguage translate, SKContext context)
        {
            context.Variables.Set("input", input);
            context.Variables.Set("translate", translate.LanguageCode);
            SKContext answer = await this.translate.InvokeAsync(context.Variables).ConfigureAwait(false);
            var inputText = answer.Result;
            int srtIndex = inputText.IndexOf("SRT:");
            if (srtIndex > 0)
            {
                inputText = inputText.Substring(srtIndex + 4).Trim();
            }

            return inputText;
        }
    }
}
