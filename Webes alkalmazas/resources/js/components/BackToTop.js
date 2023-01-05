import {useEffect, useState} from "react";
import "/css/app.css"

const BackToTop = () =>{
    const [showButton, setShowButton] = useState(false);

    useEffect(()=>{
        window.addEventListener("scroll", ()=>{
            if(window.pageYOffset > 200){
                setShowButton(true)
            } else {
                setShowButton(false)
            }
        });
    },[]);

    const scrollToTop = () =>{
        window.scrollTo({
            top:0,
            behavior:"smooth"
        });
    };

    return(
        <>
        {showButton && (
            <button onClick={scrollToTop} className="back-to-top">
                &#8679;
            </button>
        )};
        </>
    );
}

export default BackToTop;
