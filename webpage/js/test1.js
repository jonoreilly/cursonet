//window.aletr();
//window.prompt();


var aTexto;



aTexto = prompt ("quiero DAAATOOOSS !!!!");

alert (aTexto);

document.write (aTexto);

document.addEventListener('keyup', (event) => {
if( event.key == "ArrowUp")
{
  alert ("done");
}
else{
alert('keydown event\n\n' + 'key: ' + event.key);}
});
