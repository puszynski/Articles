using System;

var now = DateTime.Now; 
    //01.04.2023 07:26:59
var nowUTC = DateTime.UtcNow; 
    //01.04.2023 05:26:59

var nowOffset = new DateTimeOffset(now); 
    //01.04.2023 07:26:59 +02:00
var nowOffsetUTC = DateTimeOffset.UtcNow;
    //01.04.2023 05:26:59 +00:00


var timeZone = TimeZoneInfo.Local;
var convertedToLocal = TimeZoneInfo.ConvertTime(nowOffsetUTC, timeZone);
    //01.04.2023 07:37:21 +02:00
var convertedToLocal2 = TimeZoneInfo.ConvertTime(nowUTC, timeZone);
    //01.04.2023 07:26:59

Console.WriteLine(now);
Console.WriteLine(nowUTC);

Console.WriteLine(nowOffset);
Console.WriteLine(nowOffsetUTC);
Console.WriteLine(convertedToLocal);

var differenceDateTime = now - nowUTC;
    //01:59:59.9857964

var differenceDateTimeOffset = nowOffset - nowOffsetUTC;
    //-00:00:00.0142822

Console.WriteLine("difference DateTime: " + differenceDateTime);
Console.WriteLine("difference DateTimeOffset: " + differenceDateTimeOffset);

//todo DateTime.Kind - spr kulture
var kind = now.Kind; //"Local"
var kindUTC = nowUTC.Kind; //"UTC"

Console.WriteLine(kind); 
Console.WriteLine(kindUTC); 
//informuje czy czas loklalny czy UTC - ale brak danych o strefie czasowej

//todo DateTime parsowanie (json aby wysłać api, do db) => tracimy info o strefie.. (.Kind)