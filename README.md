# MojProjekt

Prosta aplikacja konsolowa w C#.

## Funkcje

- sumowanie dwóch liczb
- obliczanie średniej z tablicy liczb
- znajdywanie największej i najmniejszej liczby z tablicy liczb

## Update
Dodano metodę znajdującą największą liczbę w branchu feature-max.

## Merge bez fast-forward - PYTANIE 1
Z powodu rozdzielenia się gałęzi na 2 różne struktury (w mainie i max-forward pojawiły się różne commity), Git utworzył dodatkowy commit merge, aby je połączyć i z powrotem mieć jedną połączoną strukturę. Fast-forward wykona się, jeśli commity znajdują się tylko na jednej gałęzi, a zwykły merge, gdy występują na obu.

## Update
Dodano metodę znajdującą najmniejszą liczbę w branchu feature-min.

## merge a rebase - PYTANIE 2
Merge tworzy dodatkowy commit range i zachowuje historię rozgałęzień, natomiast
rebase przenosi commity na górę gałęzi, na której się znajdujemy, co powoduje, że historia staje się liniowa. Po rebase można zrobić merge jako fast-forward.

## rozwiązanie konfliktu - PYTANIE 3
W moim repozytorium commit z gałęzi main pozostał, a zmiany w commicie z feature-conflict zostały usunięte.