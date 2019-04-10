import React, { Component } from 'react';
import '../../Assets/css/pagina5.css';
import Logo from '../../Assets/img/wishlist_fundo_claro.png';
import axios from 'axios';

class ListarDesejo extends Component {

  constructor(){
    super();
    this.state = {
        lista : [],
        descricao : ""
    }
  }

  buscarDesejos(){
    axios.get('http:///192.168.5.46:5000/api/listardesejos')
      .then(res => {
        const desejos = res.data;
        this.setState({ lista : desejos });
      })
    }

    atualizaEstadoDescricao(event){
      this.setState({ descricao : event.target.value })
  }

  



  render() {


    return (
      <nav>
        <header class="top">

          <div class="logo">
            <img src={Logo}></img>
          </div>

          <div class="titulo">
            <h1>WishList</h1>
          </div>

          <div class="façadesejo">
            <h2>Faça seu Desejo</h2>
            <div class="quadrado"></div>
          </div>
        </header>

        <header class="meio">

          <div class="nome1">
            <h3>Data</h3>
          </div>

          <div class="nome2">
            <h4>Descrição</h4>
          </div>

          <div class="fundo1">
          <table>
            <thead>
              <tr>
                
              </tr>
            </thead>

            <tbody>
              {
                this.state.lista.map(function(desejo){
                  return(
                    <tr key={desejo.id}>
                      <td>{desejo.data}</td>
                      <td>{desejo.descricao}</td>
                    </tr>
                  );
                })
              }
            </tbody>
          </table>
          </div>

          <div class="fundo2"></div>

          <div class="fundo3"></div>

        </header>
      </nav>
    );
  }
}

export default ListarDesejo;