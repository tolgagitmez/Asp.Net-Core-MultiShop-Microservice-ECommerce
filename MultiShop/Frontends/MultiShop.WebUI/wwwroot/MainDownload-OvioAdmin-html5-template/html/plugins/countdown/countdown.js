
/**
* Metis - Bootstrap-Admin-Template v2.2.2
* Author : Osman Nuri Okumus 
* Copyright 2014
* Licensed under MIT
*/
/* Start Countdown Settings */

var startDate = new Date("28/09/2016"); //THIS IS JUST FOR REFERENCE- DO NOT CHANGE THIS.

var endDate = new Date("10/10/2017"); //CHANGE THIS TO YOUR LAUNCHING DATE

var dif = endDate.getTime() - startDate.getTime();
var difToSecond = dif / 1000;
var defaultPercent = 0;


$(function() {
    $('#counter').countdown({
        until: endDate,
        layout: '<div></div>',
        onTick: updateBar
    });

    $('a[rel=tooltip]').tooltip();
    $('div[rel=tooltip]').tooltip();
});

function updateBar(periods) {

    fillSecondBar(periods[6]);
    fillMinuteBar(periods[5]);
    fillHourBar(periods[4]);
    fillDayBar(periods[3]);

    fillTotalbar(periods[6] + periods[5] * 60 + periods[4] * 60 * 60 + periods[3] * 60 * 60 * 24);
}

function fillSecondBar(percent) {
    $('#second-number').html(percent);
    $('#second-bar').css('width', percent * 100 / 60 + '%');
}

function fillMinuteBar(percent) {
    $('#minute-number').html(percent);
    $('#minute-bar').css('width', percent * 100 / 60 + '%');
}

function fillHourBar(percent) {
    $('#hour-number').html(percent);
    $('#hour-bar').css('width', percent * 100 / 24 + '%');
}

function fillDayBar(percent) {
    $('#day-number').html(percent);
    $('#day-bar').css('width', percent * 100 / 365 + '%');
}

function fillTotalbar(percent) {
    defaultPercent = 100 - 100 * percent / difToSecond;

    if (defaultPercent >= 10) {
        currentPercent = defaultPercent.toString().substr(0, 5);
    } else {
        currentPercent = defaultPercent.toString().substr(0, 4);
    }

    $('#total-bar').css('width', defaultPercent + '%').html(currentPercent + '%');
}




