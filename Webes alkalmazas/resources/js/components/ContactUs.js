import React, {useRef} from 'react';
import emailjs from '@emailjs/browser';
import styled from "styled-components";
const  contactUs =  () => {
    const form = useRef();

    const sendEmail = (e) => {
        e.preventDefault();

        emailjs.sendForm('service_53kfkrd', 'template_b0xrwgw', form.current, 'd73Dn7BhPFD6N7edN')
            .then((result) => {
                console.log(result.text);
                e.target.reset();
            }, (error) => {
                console.log(error.text);
            });
    };
        return (
            <StyledContactForm>
                <form ref={form} onSubmit={sendEmail}>
                    <label>Teljes név</label>
                    <input type="text" name="customer_name" />
                    <label>Email</label>
                    <input type="email" name="customer_email" />
                    <label>Tárgy</label>
                    <input type="text" name="customer_subject" />
                    <label>Üzenet</label>
                    <textarea name="message" />
                    <input className="text-title" type="submit" value="Üzenet küldése" />
                </form>
            </StyledContactForm>
        );
};
export default contactUs;

const StyledContactForm = styled.div`
  width: 400px;
  margin-left: 55rem;
  margin-top: 10rem;
  form {
    display: flex;
    align-items: start;
    flex-direction: column;
    width: 100%;
    font-size: 20px;
    input {
      width: 100%;
      height: 35px;
      padding: 7px;
      outline: none;
      border-radius: 5px;
      border: 1px solid rgb(220, 220, 220);
      &:focus {
        border: 2px solid rgba(0, 206, 158, 1);
      }
    }
    textarea {
      max-width: 100%;
      min-width: 100%;
      width: 100%;
      max-height: 100px;
      min-height: 100px;
      padding: 7px;
      outline: none;
      border-radius: 5px;
      border: 1px solid rgb(220, 220, 220);
      &:focus {
        border: 2px solid rgba(0, 206, 158, 1);
      }
    }
    label {
      margin-top: 1rem;
    }
    input[type="submit"] {
        margin-top: 2rem;
        cursor: pointer;
        background: rgb(249, 105, 14);
        color: var(--mainDark);
        border: none;
        background: var(--mainYellow);
    }
  }
`;
