import React,{Fragment} from 'react';
import axios from 'axios';
import IUsuario from '../modules/IUsuario'
import NavBar from '../../features/nav/NavBar'
import { Container } from 'semantic-ui-react';
import UsuarioDashbord from '../../features/Usuarios/dashbord/UsuarioDashbord';

interface IState{
    usuarios: IUsuario[]
}

class App2 extends React.Component{
    readonly state : IState={
        usuarios:[]
        //,
        //clientes: []
    }

    //ya se cargo el elemento
    componentDidMount(){
        axios.get<IUsuario[]>('http://localhost:5000/api/usuarios').then((response)=>{
            this.setState({
                usuarios:response.data
            })
        });
    }

    render(){
        return(
            <Fragment>
                <NavBar></NavBar>

                <Container style={{marginTop:'7em'}}>

                    
             <UsuarioDashbord usuarios={this.state.usuarios}></UsuarioDashbord>
                </Container>
           

            </Fragment>
          
        )
    }
}

export default App2;