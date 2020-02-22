import React from 'react'
import {Grid, List} from 'semantic-ui-react'
import IUsuario from '../../../app/modules/IUsuario'

interface IProps{
    usuarios:IUsuario[]
}


export const UsuarioDashbord:React.FC<IProps> = (props:IProps) => {
    return (
<Grid>
<Grid.Column width={10}>
    <List>
        {
            props.usuarios.map((usuario:IUsuario) =>(
                <List.Item key={usuario.id}>
                    {usuario.nombre}
                </List.Item>
            ))
        }
    </List>
</Grid.Column>
</Grid>

        
    )
}

export default UsuarioDashbord;