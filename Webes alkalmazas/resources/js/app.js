require('./bootstrap');
import React from "react";
import ReactDom from 'react-dom/client';
import App from './components/App';
import {BrowserRouter as Router} from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.min.css';
import {ProductProvider} from "./components/Context";


const app = document.getElementById("app")
if(app){
    const root = ReactDom.createRoot(app);
    root.render(
        <ProductProvider>
        <Router>
            < App />
        </Router>
        </ProductProvider>
    )
}

