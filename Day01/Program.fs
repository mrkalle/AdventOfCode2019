﻿open System

module Part1 =
    let getAllFuel input = 
        let getFuel mass =
            int(Math.Floor(double(mass/3))) - 2

        let getFuelForList = List.map getFuel

        let getFuelSum list = List.sum (getFuelForList list)

        getFuelSum input

module Part2 =
    let getAllFuelInclForFuel input = 
        let getFuel mass =
            int(Math.Floor(double(mass/3))) - 2

        let rec getFuelInclForFuel m =
            let x = getFuel m
            if x <= 0 then 0
            else x + getFuelInclForFuel x
  
        let getFuelForList = List.map getFuelInclForFuel

        let getFuelSum list = List.sum (getFuelForList list)

        getFuelSum input

[<EntryPoint>]
let main argv =    
    let input = [70904;
                    66770;
                    118678;
                    58460;
                    128566;
                    60820;
                    107153;
                    113196;
                    52413;
                    118335;
                    96711;
                    88120;
                    129744;
                    64049;
                    90586;
                    54466;
                    55693;
                    102407;
                    148273;
                    110281;
                    111814;
                    60951;
                    102879;
                    135253;
                    130081;
                    86645;
                    72934;
                    147097;
                    74578;
                    124073;
                    100003;
                    103314;
                    86468;
                    84557;
                    94232;
                    120012;
                    64372;
                    143081;
                    96664;
                    148076;
                    147357;
                    139897;
                    113139;
                    143022;
                    144298;
                    81293;
                    53679;
                    139311;
                    107156;
                    121730;
                    132519;
                    132666;
                    80464;
                    111118;
                    76734;
                    139023;
                    111287;
                    126811;
                    130539;
                    129173;
                    67549;
                    102058;
                    72673;
                    91194;
                    64753;
                    59488;
                    126300;
                    94407;
                    126813;
                    60028;
                    95129;
                    79270;
                    123465;
                    60966;
                    111920;
                    76549;
                    110195;
                    119975;
                    112557;
                    129676;
                    104941;
                    89583;
                    121895;
                    108901;
                    135247;
                    75129;
                    148646;
                    131128;
                    78931;
                    111637;
                    72752;
                    140761;
                    57387;
                    85684;
                    77596;
                    134159;
                    63031;
                    148361;
                    133856;
                    82022]

    printfn "Part 1 answer is: %i" (Part1.getAllFuel input)
    printfn "Part 2 answer is: %i" (Part2.getAllFuelInclForFuel input)

    0