# EldenTos - RPG



## Příklad využití dědění a polymorfismu


## Pravidla hry

Na začátku výběr ze dvou postav

## Strojař
    - HP - 0-100
    - Name string
    - Power - 0 - 10
    - DefenderMachine - 0 - 3 - když je hodnota 3, může ho použít a tím vykryje celý útok, hodnoty se zvyšují o 1 při každém kole souboje, při použití se nastaví opět na 0

    - metody
        - Utok() - stopování "animace" v určité pozici a podle toho se vypočítá síla útoku
        - VypisInfoPostavy()




## Ajtak

    - HP - 0-100
    - Jmeno string
    - Power - 0 - 10
    - Keyboard - pole znaků, skládá se slovíčko HACK, po složení do konce souboje bude zpomalen čas útoku

    - metody
        - Utok() - stopování "animace" v určité pozici a podle toho se vypočítá síla útoku
        - VypisInfoPostavy()

Tři typy nepřátel, kteří budou na hráče postupně útočit:


## Skolnik
    - HP - 0-100
    - Name string
    - Power - 0 - 10
    - Defense - 10

    - Utok() - kámen nůžky papír, když vyhraje, dává plnou damage a má plnou obranu,
     - když je remíza, dává poloviční damage a brání se půlkou defense
     - když prohraje, nedává žádnou damage a obrana je úplně vypnuta

## UcitelDejepisu
    - HP - 0-100
    - Name string
    - Power - 0 - 10
    - Defense - 50

    - Utok()- náhodně generována hodnota útoku a ta se odečte od hráčova zdraví




## MasterOfTos
    - HP - 0-100
    - Name string
    - Power - 0 - 10
    - Defense - 100

    - utok() - spustí se sekvence animací útoků, hráč se musí všem vyhnout, postupně se zrychluje




