using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ChatBot
    {
        static void chat()
        {
            Console.WriteLine("Hallo! Ich bin dein Chatbot. Wie kann ich dir helfen?");

            while (true)
            {
                string userInput = GetUserInput();
                string response = GetBotResponse(userInput);
                DisplayResponse(response);
            }
        }

        static string GetUserInput()
        {
            Console.Write("Du: ");
            return Console.ReadLine();
        }

        static string GetBotResponse(string userInput)
        {
            if (userInput.ToLower().Contains("hallo"))
            {
                return "Hallo! Wie kann ich dir helfen?";
            }
            else if (userInput.ToLower().Contains("wie geht es dir"))
            {
                return "Mir geht es gut, danke! Und dir?";
            }

            else if (userInput.ToLower().Contains("themes ändern") || userInput.ToLower().Contains("einstellung") || userInput.ToLower().Contains("ändern"))
            {
                return "Drücken Sie Einstellung/Themes/Ändern";
            }

            else if (userInput.ToLower().Contains("dein name"))
            {
                return "Ich bin ein Chatbot. Du kannst mich Teemo nennen.";
            }

            else if (userInput.ToLower().Contains("Excel Dateien") || userInput.ToLower().Contains("erstellen"))
            {
                return "\tJa, die Software kann Excel-Dateien erstellen. \n\t Navigieren Sie zum gewünschten Tab (Kunden, Lieferanten oder Artikel) und verwenden Sie die Schaltfläche \n\t'Exportieren', um eine Excel-Datei mit den entsprechenden Informationen zu generieren.";
            }

            else if (userInput.ToLower().Contains("lieferanten auflisten"))
            {
                return "Bot: Um alle Lieferanten anzuzeigen, die Artikel in der Datenbank haben, navigieren Sie zum Lieferanten-Tab und verwenden Sie die entsprechende Filteroption oder exportieren Sie die Informationen in eine Excel-Datei.";
            }

            else if (userInput.ToLower().Contains("neuen auftrag erstellen"))
            {
                return "Bot: Um einen neuen Auftrag zu erstellen, wechseln Sie zum Auftrags-Tab, wählen Sie den Kunden aus, fügen Sie die gewünschten Artikel hinzu und geben Sie das Auslieferungsdatum ein. Speichern Sie dann den Auftrag.";
            }

            else if (userInput.ToLower().Contains("artikel aktualisieren"))
            {
                return "Bot: Um einen Artikel zu aktualisieren, gehen Sie zum Artikel-Tab, wählen Sie den gewünschten Artikel aus und klicken Sie auf die Schaltfläche 'Aktualisieren'. Geben Sie die neuen Informationen ein und speichern Sie die Änderungen.";
            }

            else if (userInput.ToLower().Contains("neuen kunden hinzufügen"))
            {
                return "Bot: Um einen neuen Kunden hinzuzufügen, navigieren Sie zum Kunden-Tab und klicken Sie auf die Schaltfläche 'Neuen Kunden hinzufügen'. Geben Sie dann die erforderlichen Informationen ein.";
            }

            else if (userInput.ToLower().Contains("ayy"))
            {
                return "ayy lmao";
            }


            else if (userInput.ToLower().Contains("auf wiedersehen"))
            {
                Console.WriteLine("Auf Wiedersehen! Bis zum nächsten Mal.");
                Environment.Exit(0);
                return "";
            }
            else
            {
                return "Entschuldigung, ich habe das nicht verstanden. Kannst du das anders formulieren?";
            }
        }

        static void DisplayResponse(string response)
        {
            Console.WriteLine("Bot: " + response);
        }
    }
}
