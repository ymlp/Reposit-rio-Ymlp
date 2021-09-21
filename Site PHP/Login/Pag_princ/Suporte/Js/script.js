
function PagLocal(titulo)
{
    var pag = document.querySelector(titulo);
    pag.style.color ='#0084ff'; 
}


function px970(x) {
    if (x.matches) {
      //Cria a dropdown e define seus atributos
     var btn = document.createElement('input');
          btn.setAttribute('type','button');
          btn.setAttribute('class','DropDownBtn');
          btn.setAttribute('data-toggle','dropdown');
          btn.value = 'Menu';
          var itens = document.querySelector('.itens');
          itens.appendChild(btn);
  
          //div que amazenara os itens do dropdown
          var div = document.createElement('div');
          div.setAttribute('class','dropdown-menu');
          div.setAttribute('id','menu');
          var menu = document.querySelector('#menu');
         
          // Cria um item do menu
          var link1 = document.createElement('a');
          link1.setAttribute('class','dropdown-item');
          link1.value = 'Home';
          menu.appendChild(link1);
  
  
    }
    else {
      var btn = document.querySelector('.DropDownBtn');
      btn.remove();
    }
  }