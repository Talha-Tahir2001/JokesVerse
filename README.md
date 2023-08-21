
# JokesVerse - Where Simplicity Meets Laughter

Welcome to JokesVerse, your go-to source for simple and hilarious jokes that are guaranteed to bring a smile to your face. Whether you need a quick chuckle or want to brighten someone's day, JokesVerse has you covered.

## Features

-   **Browse Jokes:** Explore a collection of handpicked jokes that cover a wide range of humor styles.
-   **Search Functionality:** Looking for a specific type of joke? Use our search feature to find the perfect punchline.
-   **User-Friendly Interface:** Our clean and intuitive design makes it easy to navigate and enjoy the jokes.
-   **Add, Edit, and Delete:** Have a joke of your own to share? Use the app to add, edit, or delete jokes.
-   **Entity Framework Integration:** Seamless integration with Entity Framework for efficient data management.
-   **Simple and Fun:** No frills, no ads, just pure laughter. Enjoy a distraction-free joke-telling experience.

## Getting Started

1.  **Clone the Repository:**
    
    -   Clone this repository to your local machine using Git.
    
    
    
    `git clone https://github.com/Talha-Tahir2001/JokesVerse.git` 
    
2.  **Setup Database:**
    
    -   Configure your database connection string in the `appsettings.json` or `appsettings.Development.json` files.
3.  **Run the Application:**
    
    -   Use your preferred development environment (e.g., Visual Studio, Visual Studio Code) to open the project.
    -   Build and run the application.
4.  **Access JokesVerse:**
    
    -   Open your web browser and navigate to `http://localhost:` to access the JokesVerse web app. You can find it in `launchSettings.json`
## Authentication with Google

JokesVerse offers a seamless authentication experience through Google. With Google authentication, you can enjoy the following benefits:

-   Secure and convenient sign-in using your Google account.
-   Access to additional features and personalized experiences.

### Getting Started with Google Authentication

1.  **Enable Google Authentication:**
    
    -   To enable Google authentication for your JokesVerse instance, you need to set up a Google OAuth 2.0 client ID and client secret.
    -   Visit the [Google Developer Console](https://console.developers.google.com/) and create a new project.
    -   Configure the OAuth consent screen with the required information.
    -   Create OAuth 2.0 credentials to obtain the client ID and client secret.
2.  **Add Google Credentials:**
    
    -   Open the `appsettings.json` or `appsettings.Development.json` file in your project.
    -   Add your Google OAuth 2.0 client ID and client secret as follows:
    
    
    `"Authentication": {
        "Google": {
            "ClientId": "YOUR_CLIENT_ID_HERE",
            "ClientSecret": "YOUR_CLIENT_SECRET_HERE"
        }
    }`
    
    **Test Google Authentication:**

-   Build and run your JokesVerse web app.
-   Click the "Sign In with Google" button to initiate the Google authentication flow.
-   Sign in with your Google account to access the app.

## Contributing

We welcome contributions from the community to make JokesVerse even better. If you have jokes to add, feature suggestions, or bug reports, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE.md](https://chat.openai.com/LICENSE.md) file for details.

## About

JokesVerse is a simple web application created with love and laughter by Me. We hope it brings joy to your day!
