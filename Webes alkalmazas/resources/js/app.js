require('./bootstrap');
import ReactDom from 'react-dom/client';
import App from './components/App';
const app = document.getElementById("app")
if(app){
    const root = ReactDom.createRoot(app);
    root.render(
        < App />
    )
}

