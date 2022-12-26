require('./bootstrap');
import React from "react";
import ReactDom from 'react-dom/client';
import App from './components/App';
import {BrowserRouter as Router} from "react-router-dom";

const app = document.getElementById("app")
if(app){
    const root = ReactDom.createRoot(app);
    root.render(
        <Router>
            < App />
        </Router>
    )
}

