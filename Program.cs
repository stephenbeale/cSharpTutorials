static void Notify (NotificationDelegate notification)
{
    notification("User notified by:");
}

NotificationDelegate EmailNotification = (string notificationType) => Console.WriteLine(notificationType + " email.");
NotificationDelegate SMSNotification = (string notificationType) => Console.WriteLine(notificationType + " SMS.");

Notify(EmailNotification);
Notify(SMSNotification);

delegate void NotificationDelegate(string notificationType);