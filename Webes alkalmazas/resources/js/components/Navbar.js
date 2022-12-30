import React, {Component} from 'react';
import {Link} from "react-router-dom";
import styled from 'styled-components';
import {ButtonContainer} from "./Button";
import {BsFillCartCheckFill} from 'react-icons/bs';
import logo from '../../../public/project_23.png'

class Navbar extends Component {

    render() {
        return(
            <NavWrapper className="navbar navbar-expand-sm navbar-dark px-sm-5">
                <Link to="/">
                    <img src={logo} style={{width: '150px'}} alt="logo" className="navbar-brand"/>
                </Link>
                <ul className="navbar-nav align-items-center">
                    <li className="nav-item ml-5">
                        <Link to="/" className="nav-link">
                            Termékek
                        </Link>
                    </li>
                </ul>
                <Link to='/cart' className="ml-auto">
                    <ButtonContainer>
                        <BsFillCartCheckFill className="d-inline-block " /> kosár
                    </ButtonContainer>
                </Link>
            </NavWrapper>
            );
    }
}
export default Navbar;

const NavWrapper = styled.nav`
background: var(--mainBlue);;
justify-content:space-between;
.nav-link{
    color: var(--mainWhite)!important;
    font-size:1.3rem;
    text-transform: capitalize;
}
`;
