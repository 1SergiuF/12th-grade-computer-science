import React from "react";
import "./MyButton.css";
import destroyer from "../images/gif.gif";
import { useState } from "react";

const MyButton = (props) => {
  const [clicked, setClicked] = useState(true);

  const handleClick = () => {
    const pdiv = document.getElementById("bdiv");
    const yesBtn = document.getElementById("yesbutton");
    const noBtn = document.getElementById("nobutton");
    let p = document.createElement("p");
    p.id = "pr";
    p.innerHTML = `<img src=${destroyer}>`;

    if (clicked === true) {
      pdiv.insertBefore(p, pdiv.firstChild);
      yesBtn.style.top = `${65}%`;
      noBtn.style.top = `${65}%`;
      setClicked(false);
    } else {
      yesBtn.style.top = `${45}%`;
      noBtn.style.top = `${45}%`;
      document.getElementById("pr").remove();
      setClicked(true);
    }
  };

  return (
    <div>
      <button
        id={props.id}
        className={props.className}
        onClick={handleClick}
        style={{
          marginTop: props.top,
          marginRight: props.right,
          marginLeft: props.left,
        }}
        onMouseEnter={props.mouseEnter}
      >
        {props.title}
      </button>
    </div>
  );
};

export default MyButton;
