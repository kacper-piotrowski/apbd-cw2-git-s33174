"# apbd-cw2-git-s33174"

Zad 5
Merge nie był typu fast-forward ponieważ pojawiły się nowe commity zarówno na gałęzi feature-max, jak i main. Takie rozwiązanie wymaga bardziej zaawansowanego merga, by połączyć zmiany obu gałęzi.

Zad 6
Rebase nie odgałęzia naszych commitów, tylko dokłada je na samym szczycie gałęzi main tworząc liniową historie.

Pytania:
1.Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
-Git wykonuje fast forward kiedy od momentu rozgałęzienia nie było nowych commitów na gałęzi do której chcemy zmergować, natomiast merge commit występuje dla przypadków bardziej zaawansowanych gdzie na obu gałęziach wystąpiły zmiany i trzeba zastosować ich scalanie.

2.Czym w praktyce różni się merge od rebase
-Merge zachowuje historię commitów na commitowanej gałęzi, natomiast rebase przepisuje całą historię na szczyt gałęzi do której scalamy.

3.W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
-Konflikt w moim repozytorium został rozwiązany przez połączenie wszystkich dotychczasowych wiadomości początkowych.