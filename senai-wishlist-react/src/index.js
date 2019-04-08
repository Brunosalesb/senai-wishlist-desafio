import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './Pages/Login/App';
import Login from "./Pages/Login/App";
import Cadastro from "./Pages/Cadastro/Cadastro";
import CadastrarDesejo from "./Pages/CadastrarDesejo/CadastrarDesejo";
import Listardesejo from "./Pages/ListarDesejo/ListarDesejo";
import NaoEncontrada from "./Pages/NaoEncontrada/NaoEncontrada";
import * as serviceWorker from './serviceWorker';
import {Route, BrowserRouter as Router, Switch} from 'react-router-dom';

const rotas = (
    <Router>
        <div>
            <Switch>
                <Route exact path="/" component={App} />
                <Route path="/cadastro" component={Cadastro} />
                <Route path="/login" component={Login}/>
                <Route path="/cadastrardesejo" component={CadastrarDesejo} />
                <Route path="/listardesejo" component={Listardesejo} />
                <Route component={NaoEncontrada} />
            </Switch>
        </div>
    </Router>
);

ReactDOM.render(rotas, document.getElementById('root'));

serviceWorker.unregister();
