# ✅ Zadanie: Refaktoryzacja systemu wysyłania wiadomości (SMS, Email, Messenger)

## 🧩 Cel:
Celem zadania jest rozpoznanie powielonego, nieelastycznego kodu oraz jego refaktoryzacja.

---

## 🚫 Kod przed refaktoryzacją (tzw. „legacy code”)

Poniższy kod działa, ale jest nieelastyczny i słabo zaprojektowany:


```cs
public class SmsSender
{
    public void SendBySms(string number, string message)
    {
        Console.WriteLine("[SMS] To: " + number + " | " + message);
    }
}

public class EmailSender
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine("[Email] To: " + email + " | " + message);
    }
}

public class MessengerSender
{
    public void SendToMessenger(string user, string message)
    {
        Console.WriteLine("[Messenger] To: " + user + " | " + message);
    }
}

public class NotificationService
{
    private SmsSender _smsSender = new SmsSender();
    private EmailSender _emailSender = new EmailSender();
    private MessengerSender _messengerSender = new MessengerSender();

    public void NotifyBySms(string number, string message)
    {
        _smsSender.SendBySms(number, message);
    }

    public void NotifyByEmail(string email, string message)
    {
        _emailSender.SendEmail(email, message);
    }

    public void NotifyByMessenger(string user, string message)
    {
        _messengerSender.SendToMessenger(user, message);
    }
}
```

## 🧠 Zadanie 

1. Zrefaktoryzuj kod

2. Dodaj obsługę nowego typu wysyłki: `TeamsSender`, ale:
- ❗ powinna działać z istniejącą klasą NotificationService bez żadnych zmian w jej kodzie.


---

## ⏱️ Czas realizacji
 ⏱ 30 minut
