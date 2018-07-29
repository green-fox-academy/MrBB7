if (typeof kotlin === 'undefined') {
  throw new Error("Error loading module 'WordCountJs'. Its dependency 'kotlin' was not found. Please, check whether 'kotlin' is loaded prior to 'WordCountJs'.");
}
var WordCountJs = function (_, Kotlin) {
  'use strict';
  var println = Kotlin.kotlin.io.println_s8jyv4$;
  var ensureNotNull = Kotlin.ensureNotNull;
  var throwCCE = Kotlin.throwCCE;
  var Unit = Kotlin.kotlin.Unit;
  function main$lambda(it) {
    var tmp$;
    var theText = (Kotlin.isType(tmp$ = ensureNotNull(document.getElementById('wordText')), HTMLInputElement) ? tmp$ : throwCCE()).value;
    println(theText);
    return Unit;
  }
  function main(args) {
    println('Hello world');
    var button = ensureNotNull(document.getElementById('button'));
    button.addEventListener('click', main$lambda);
  }
  _.main_kand9s$ = main;
  main([]);
  Kotlin.defineModule('WordCountJs', _);
  return _;
}(typeof WordCountJs === 'undefined' ? {} : WordCountJs, kotlin);
