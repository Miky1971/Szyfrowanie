# Szyfrowanie

- Aplikacja Windows Forms do szyfrowania i deszyfrowania dowolnych plików hasłem.
- .NET (Windows Forms): korzysta z klas `System.Security.Cryptography`.

## Co robi

- **Podaje się:**
- plik wejściowy i plik wynikowy (można je wybierać standartowym oknem wyboru plikow z Systemu Operacjnego po naciśnięciu klawisy [...]).
- i wpisujesz hasło (czytelne lub zagwiazdkowane w zależności od stanu klawisza [👁/🙈]).
- **Szyfrowanie** szyfruje plik, na podstawie hasła i zapisuje go jako nowy plik.
- **Deszyfrowanie** deszyfruje plik, na podstawie hasła i zapisuje go jako nowy plik.

## Jak to działa w środku

- Z hasła i losowej soli buduje się klucz (PBKDF2, 100 000 iteracji, SHA256, klucz 256-bitowy).
- Szyfrowanie **AES-GCM** dodaje tag uwierzytelniający, który pozwala wykryć, czy ktoś zmienił zaszyfrowane dane.
- Do pliku wynikowego trafia: sól (16 bajtów) + nonce (12 bajtów) + tag (16 bajtów) + zaszyfrowane dane.
- Przy deszyfrowaniu program wycina te cztery elementy z powrotem (bo ich długości są zawsze takie same), 
	z hasła i odzyskanej soli odtwarza ten sam klucz, i próbuje odszyfrować.

- Cała logika szyfrowania/deszyfrowania jest w osobnej klasie `Encryptor` — nie zależy od formularza, 
	więc da się jej użyć w innym projekcie bez zmian.

## Błędy/wyjątki

- **Wszystkie pola: plik wejściowy/wynikowy/hasło muszą być wypełnione** komunikat: "Wypełnij wszystkie pola".
- **Błędny plik wejściowy** `IOException`, pokazuje komunikat błedu.
- **Błędne hasło przy deszyfrowaniu** — `CryptographicException` (AES-GCM wykrywa, że tag się nie zgadza).
- **Wybranie pliku do odszyfrownia, który nie jest poprawnym zaszyfrowany** (np. za krótki) — `ArgumentOutOfRangeException`.
- Te dwa ostatnie łapane są razem, z komunikatem "Błąd dekryptarzu" — z punktu widzenia użytkownika oznaczają to samo: coś jest nie tak z hasłem albo z plikiem.
