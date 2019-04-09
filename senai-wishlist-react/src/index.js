import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './Pages/Login/App';
import Cadastro from "./Pages/Cadastro/Cadastro";
import CadastrarDesejo from "./Pages/CadastrarDesejo/CadastrarDesejo";
import Listardesejo from "./Pages/ListarDesejo/ListarDesejo";
import NaoEncontrada from "./Pages/NaoEncontrada/NaoEncontrada";
import * as serviceWorker from './serviceWorker';
import {Route, BrowserRouter as Router, Switch, Redirect} from 'react-router-dom';
import {usuarioAutenticado} from './services/auth';

const Permissao = ({component : Component}) => (
    <Route
    render = {props => usuarioAutenticado() ?
        (<Component {...props} />) :
        (<Redirect to={{pathname :  '/',state : {from : props.location}}}/>)
    }
    />
);

const rotas = (
    <Router>
        <div>
            <Switch>
                <Route exact path="/" component={App} />
                <Route path="/cadastro" component={Cadastro} />
                <Permissao path="/cadastrardesejo" component={CadastrarDesejo} />
                <Permissao path="/listardesejo" component={Listardesejo} />
                <Route component={NaoEncontrada} />
            </Switch>
        </div>
    </Router>
);

ReactDOM.render(rotas, document.getElementById('root'));

serviceWorker.unregister();
