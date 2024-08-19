/*3 - Void function
 * - taking our generic delegate type as an argument / parameter 
 * - passes something to our delegate type
 * - implemented delegate function does something with argument passed
 */
static void Notify(NotificationDelegate notification)
{
    notification("User notification");
}

/*
 * 2 - Delegate function
 * - returning our defined delegate type
 * - anonymous function
 * - does something with argument
 */
NotificationDelegate EmailNotification = (string notificationType) => Console.WriteLine(notificationType + " is email");
NotificationDelegate SMSNotification = (string notificationType) => Console.WriteLine(notificationType + " is SMS");

//4 - Call our void function, passing in one of our implemented delegate functions
Notify(SMSNotification);
Notify(EmailNotification);

//1 - Our own 'generic' delegate type with relevant argument
delegate void NotificationDelegate(string type);