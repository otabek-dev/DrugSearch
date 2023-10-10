# DrugSearch bot
## About the Bot

The DrugSearch bot is designed to simplify the process of searching for medicines and pharmaceutical products within the Telegram platform. With this bot, users can easily and quickly find the medicines they need without leaving the application. The bot is created with your convenience in mind, providing fast access to essential information about medications and assisting you and your friends in staying healthy.

With the DrugSearch bot, you can:

- Find information about medicines and pharmaceutical products, including their names, descriptions, and prices in various pharmacies.
- Receive up-to-date data on the availability of medicines in pharmacies and their prices, enabling you to make informed decisions.
- Share the found information with friends and loved ones by using inline mode, which allows you to send search results in chats and groups.

The DrugSearch bot is here to facilitate your search for the medicines you need and save you time. https://t.me/MiniDrugSearch_bot

<hr/>

## Getting Started

To start using the DrugSearch bot, you'll first need to launch the bot in your Telegram application. Once you've done that, you can begin searching for medicines and pharmaceutical products using various methods. Here's how you can get started:

### Basic Search
- You can initiate a basic search by sending the name of the medicine you're looking for directly to the bot in a chat. Simply type the name of the medication and send your message.

### Inline Mode
- For a more interactive search experience, you can use the bot's inline mode. To access this feature, open any chat or group where you want to search for medicines.
- Begin typing the name of the medication you're looking for, and the bot will automatically suggest relevant search results.
- You can choose from the suggested results and share them with others in the chat or group, making it easy to discuss and find medicines collaboratively.

Whether you prefer a simple one-on-one chat or a more interactive group experience, the DrugSearch bot offers multiple options to help you quickly locate the medications you need without leaving the Telegram platform. Start searching now and make informed decisions about your pharmaceutical needs.

<img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/start.png" alt="Описание 1" width="600"/> <img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/inlineMode.png" alt="Описание 1" width="300"/> <img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/inlineModeResult.png" alt="Описание 1" width="300"/> <img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/searchDrug.png" alt="Описание 1" width="600"/> <img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/results.png" alt="Описание 1" width="300"/> <img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/searchWithInlineMode.png" alt="Описание 1" width="600"/>

## Project Structure

```
├── DrugSearch.Backend
│   ├── Bot.cs
│   ├── Controllers
│   │   ├── BotController.cs
│   │   └── DrugController.cs
│   ├── DB
│   │   ├── AppDbConfig.cs
│   │   └── AppDbContext.cs
│   ├── DrugSearch.Backend.csproj
│   ├── Migrations
│   ├── Models
│   │   ├── Drug.cs
│   │   ├── DrugPriceInDrugStore.cs
│   │   └── DrugStore.cs
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── Services
│   │   ├── DrugService.cs
│   │   └── UpdateHandlers.cs
│   ├── ViewModel
│   │   ├── DrugPriceInDrugStoreViewModel.cs
│   │   ├── DrugStoreViewModel.cs
│   │   └── DrugViewModel.cs
│   ├── appsettings.json
├── DrugSearch.Frontend
│   ├── README.md
│   ├── index.html
│   ├── netlify.toml
│   ├── package.json
│   ├── public
│   │   ├── drug.png
│   │   └── vite.svg
│   ├── src
│   │   ├── API
│   │   │   ├── Config.js
│   │   │   └── DrugService.js
│   │   ├── App.css
│   │   ├── App.jsx
│   │   ├── Components
│   │   │   ├── DrugItem
│   │   │   │   ├── DrugItem.jsx
│   │   │   │   └── drugItem.module.css
│   │   │   ├── DrugList
│   │   │   │   ├── DrugList.jsx
│   │   │   │   └── drugList.module.css
│   │   │   ├── DrugStoreItem
│   │   │   │   ├── DrugStoreItem.jsx
│   │   │   │   └── drugStoreItem.module.css
│   │   │   ├── DrugViewPage
│   │   │   │   ├── DrugViewPage.jsx
│   │   │   │   └── drugViewPage.module.css
│   │   │   ├── HomePage
│   │   │   │   └── HomePage.jsx
│   │   │   ├── Loader
│   │   │   │   ├── Loader.jsx
│   │   │   │   └── loader.module.css
│   │   │   └── MyLink
│   │   │       ├── MyLink.jsx
│   │   │       └── myLink.module.css
│   │   ├── Hooks
│   │   │   ├── useFetching.js
│   │   │   └── useTelegram.js
│   │   └── main.jsx
│   ├── vite.config.js
│   └── yarn.lock
├── DrugSearch.sln
├── LICENSE.txt
└── README.md
```

<hr/>

# Developer's Guide

**Required Tools:**
- Visual Studio 2022
- .NET 7
- PostgreSQL 15
- Node.js 18 LTS + Yarn + Vite
- ngrok
- WebStorm or Visual Studio Code

Download and install all the required tools.

<hr/>

To get started, clone the project from GitHub. You should see the following files:

<img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/projectFiles.png" alt="db" width="700"/> 

## Frontend

To run the frontend, navigate to the "TgForms.Frontend" directory in your console using the `cd /path/to/your/project` command. Then, run the `yarn` command in the console to install all the necessary dependencies. Once all the dependencies have been installed, you can run the project.

However, running the project locally is not enough because the frontend is designed to work in conjunction with the backend and Telegram data. Therefore, the next step is deploying the project. You can use any hosting service for this purpose, but I recommend using [Netlify](https://www.netlify.com/) because it's free and relatively straightforward.

Follow the deployment instructions provided by Netlify [here](https://docs.netlify.com/get-started/), and apply my settings for the build process.

<img src="https://github.com/otabek-dev/DrugSearch/blob/master/DrugSearch.Screens/deploySettings.png" alt="db" width="700"/> 

At this stage, you should obtain a public link to the frontend resembling something like `vergergerg-stroopwafel-fff02a.netlify.app.` You will need this link for the next step.

## Backend

1. Open the `TgForms.sln` file and wait for all the dependencies to be installed. In Visual Studio 2022, dependencies are downloaded automatically.

2. Create a file named `appsettings.json` inside the `TgForms.Backend` folder. Inside the file, configure the following settings:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "BotToken": "{Your Bot Token}",
  "WebAppUrl": "{Link to WebApp}", // For example, https://mywebapp.netlify.app
  "BotUrlWithStartApp": "{your_web_app_link_in_telegram}?startapp=",
  "DbConnDigitalOcean": "Host=localhost; Port=5432; Database=TgForms; Username=postgres; Password={Your Database Password}"
}
```

To obtain a token for your bot, follow this guide: [From BotFather to 'Hello World' (telegram.org)](https://core.telegram.org/bots/tutorial)

### Configuring Bot for Inline Mode

1. In your bot's settings, enable "Inline Mode."

2. To set up the "Create form" button, send the `/setmenubutton` command to [https://t.me/BotFather](https://t.me/BotFather). In response to the bot, send the following link: `https://{your web app link}/create-form`. The bot will ask you to provide a name for the button. Enter `Create form` as the button's name.

3. Create a WebApp link for your bot using the `/newapp` command in @BotFather. Follow the instructions provided by BotFather. Place the received link in the `"BotUrlWithStartApp"` field in the following format: `"{your received link}?startapp="`.

4. Ensure that there are no trailing slashes `/` at the end of the links, as this can lead to routing errors.

5. Finally, configure the connection string to your database. If you are using PostgreSQL, simply append your database password at the end of the connection string.

6. Run the project, and if there are no errors during startup, stop the project and apply the database migration. To migrate the database, open the Package Manager Console and run the following command: `Update-Database`.

### ngrok

Next, we will set up `ngrok` to allow our locally running bot to communicate with Telegram.

First, make sure your project is running. By default, the project should be accessible at

<img src="https://github.com/otabek-dev/TgForms/blob/master/TgForms.Screens/viewNgrok.png" alt="db" width="700"/> 

If it's running on a different address, that's okay.

To start an `ngrok` server, open your terminal and run the following command:

```
ngrok http http://localhost:5000/
```

You should see output similar to the screenshot you provided.

### Telegram WebHook

After running `ngrok` and exposing your local server, you need to set up a Telegram WebHook to connect your bot to the Telegram API.

Use the following URL to set the WebHook:

```
https://api.telegram.org/bot{your_bot_token}/setWebhook?url={your_web_app_url}
```

Replace `{your_bot_token}` with your actual bot token and `{your_https_ngrok_url}` with the public URL provided by `ngrok`.

You should receive a response like the following:

```
{"ok":true,"result":true,"description":"Webhook was set"}
```

Now your bot should be fully functional and ready to use.

# Deployment

To deploy your bot, you can use any operating system. I will be using Ubuntu 22 LTS for this example. You can find a detailed guide on how to deploy an ASP.NET Core application to Digital Ocean Droplets in this [link](https://juldhais.net/how-to-deploy-asp-net-core-application-to-digital-ocean-droplets-40861be83db7). This guide covers everything except migrating the database.

Before proceeding with the deployment, you need to install and configure the database on your server.

Start by installing PostgreSQL:

```bash
sudo apt update
sudo apt install postgresql postgresql-contrib
```

Now set a password for the PostgreSQL user:

```bash
sudo -u postgres psql
\password postgres
```

Next, download `dotnet ef`:

```bash
dotnet tool install --global dotnet-ef
```

After installation, add the directory containing the .NET Core SDK tools to your **`~/.bash_profile`**:

```bash
cat << \EOF >> ~/.bash_profile
# Add .NET Core SDK tools
export PATH="$PATH:/root/.dotnet/tools"
EOF
```

Then, update your current session to apply the changes:

```bash
source ~/.bash_profile
```

Now you can use **`dotnet-ef`** by running commands in your shell.

Proceed with the deployment guide I provided earlier. When building the project, don't forget to migrate the database:

```bash
cd /path/to/your/project
dotnet ef database update
```

Ensure that you configure the `appsettings.json` as I described in the developer's guide.

That's it! Good luck with your deployment!

# References

Here are the resources and references used in the development of this project:

- [Telegram Bots Web Apps](https://core.telegram.org/bots/webapps)
- [From BotFather to 'Hello World' (telegram.org)](https://core.telegram.org/bots/tutorial)
- [Telegram Bot API Documentation](https://telegrambots.github.io/book/index.html)
- [Entity Framework Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
- [How To Install and Use PostgreSQL on Ubuntu 22.04](https://www.digitalocean.com/community/tutorials/how-to-install-and-use-postgresql-on-ubuntu-22-04)
- [How to Deploy an ASP.NET Core Application to Digital Ocean Droplets](https://juldhais.net/how-to-deploy-asp-net-core-application-to-digital-ocean-droplets-40861be83db7)
- [Netlify](https://app.netlify.com/)
