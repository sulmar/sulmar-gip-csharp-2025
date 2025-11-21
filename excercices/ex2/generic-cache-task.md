# ✅ Zadanie: Refaktoryzacja cache w C# z użyciem generyków

## 🧩 Cel:
Celem zadania jest analiza powielonego kodu, a następnie jego refaktoryzacja i dodanie obsługi nowego typu (DateTime) **bez tworzenia kolejnej klasy**.

---

## ✅ Wymagania funkcjonalne

W projekcie znajdują się trzy podobne klasy:


```cs
public class IntCacheItem
{
    public int Value { get; }
    public DateTime Expiration { get; }

    public IntCacheItem(int value, TimeSpan ttl)
    {
        Value = value;
        Expiration = DateTime.Now.Add(ttl);
    }

    public bool IsExpired => DateTime.Now > Expiration;
}
```

```cs
public class StringCacheItem
{
    public string Value { get; }
    public DateTime Expiration { get; }

    public StringCacheItem(string value, TimeSpan ttl)
    {
        Value = value;
        Expiration = DateTime.Now.Add(ttl);
    }

    public bool IsExpired => DateTime.Now > Expiration;
}
```

```cs

public class Customer
{
    public string Name { get; set; }
}

public class CustomerCacheItem
{
    public Customer Value { get; }
    public DateTime Expiration { get; }

    public CustomerCacheItem(Order value, TimeSpan ttl)
    {
        Value = value;
        Expiration = DateTime.Now.Add(ttl);
    }

    public bool IsExpired => DateTime.Now > Expiration;
}
```

## 🧠 Zadanie 

1. Zidentyfikuj powtarzający się kod

2. Dodaj obsługę nowego typu: `DateTime`, ale:
- ❗ nie wolno tworzyć nowej klasy „DateTimeCacheItem”
- ❗ kod nie może zostać powielony


---

## ⏱️ Czas realizacji
 ⏱ 15 minut
