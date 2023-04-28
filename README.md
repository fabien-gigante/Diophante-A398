# Diophante A398
see http://www.diophante.fr/problemes-du-mois/5646-a398-en-allant-crescendo

## Problem statement
Find the smallest prime $p$ such that for each positive integer $n$, the quantity $n^p – n$ is divisible by an integer > 1012


## Exploration
For a given $p$, let's call $k$ the gcd of $n^p – n$ for all $n$.
This program computes the values of $k$ for all primes $p$, stopping when $k > 10^(12)$.

Program's output is shown below :

```
p=2 k=2
p=3 k=6
p=5 k=30
p=7 k=42
p=11 k=66
p=13 k=2730
p=17 k=510
p=19 k=798
p=23 k=138
p=29 k=870
p=31 k=14322
p=37 k=1919190
p=41 k=13530
p=43 k=1806
p=47 k=282
p=53 k=1590
p=59 k=354
p=61 k=56786730
p=67 k=64722
p=71 k=4686
p=73 k=140100870
p=79 k=3318
p=83 k=498
p=89 k=61410
p=97 k=4501770
p=101 k=33330
p=103 k=4326
p=107 k=642
p=109 k=209191710
p=113 k=1671270
p=127 k=4357878
p=131 k=8646
p=137 k=4110
p=139 k=274386
p=149 k=4470
p=151 k=2162622
p=157 k=1794590070
p=163 k=130074
p=167 k=1002
p=173 k=5190
p=179 k=1074
p=181 k=7225713885390
25ms elapsed
```
