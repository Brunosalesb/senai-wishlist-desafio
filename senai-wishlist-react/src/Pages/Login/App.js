import React, { Component } from 'react';
import './App.css';
import logo from '../../Assets/img/wishlist_fundo_escuro.png';
import '../../Assets/css/app.css';
import Axios from 'axios'

export default class App extends Component {
 
  
  constructor(){
    super();
    this.state ={
      email : '',
      senha :''
    }
  }
  
                atualizaEstadoEmail(event){
                  this.setState({email : event.target.value});
              }
              atualizaEstadoSenha(event){
                  this.setState({senha : event.target.value});
              }
  
  efetuaLogin(event){
    event.preventDefault();
    Axios.post('http://localhost:5000/api/login',{
      email : this.state.email,
      senha : this.state.senha
    })
    .then(data => {
      localStorage.setItem("wishlist-token", data.data.token);
      this.props.history.push('/cadastrardesejo');
      console.log(data);
    })
    .catch(erro => {
      console.log(erro);
    })
  }

  render() {
    return (
      <section>
      <div className="topo">
          <img src={logo} alt="logo wishlist"></img>
          <h1>WishList</h1>
      </div>

      <form onSubmit={this.efetuaLogin.bind(this)}>
      <div className="emailInput">
            <input
              id="email"
              type="text"
              value={this.state.email}
              onChange={this.atualizaEstadoEmail.bind(this)}
              placeholder="Email"
              name="email"
            />
      </div>

      <div className="senhaInput">
            <input id="senha"
              type="password"
              value={this.state.senha}
              onChange={this.atualizaEstadoSenha.bind(this)}
              placeholder="Senha"
              name="senha"
            />
      </div>

      <div className="botao">
          <button type="submit">Entrar</button>
      </div>
      </form>
      </section>
    )
  } 
}