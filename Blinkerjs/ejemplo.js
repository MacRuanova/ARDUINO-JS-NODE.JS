/*
var j5 = require("johnny-five");
var board = new j5.Board();
 
var LEDPIN = 8;
var OUTPUT = 1;
 
board.on("ready", function(){
  var val = 0;
 
  // El pin 13 como salida
  this.pinMode(LEDPIN, OUTPUT);
 
  // La conocida funcion loop
  this.loop( 100, function() {
    this.digitalWrite(LEDPIN, (val = val ? 0 : 1));
  });
});
*/

var j5 = require("johnny-five");
var board = new j5.Board();
var LEDPIN = 13;
 
board.on("ready", function(){
  var led = new j5.Led(LEDPIN);
  led.strobe();
});