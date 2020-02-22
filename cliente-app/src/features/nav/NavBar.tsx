import React from 'react'
import {Menu,Button, Container} from 'semantic-ui-react'


export const NavBar:React.FC = () => {
    return (
        <Menu inverted fixed='top'>
            <Container>
            <Menu.Item header>
          <img src='/assets/logo.png' alt='logo'/>
            Administracion de usuarios
        </Menu.Item>

        <Menu.Item
          name='Usuarios'
            
        />
        <Menu.Item>
            <Button primary>Nuevo Usuario</Button>
            </Menu.Item>

            </Container>
        
      </Menu>
    )
}

export default NavBar