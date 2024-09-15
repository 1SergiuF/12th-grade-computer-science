import "./App.css";
import "./Box.css";
import MyButton from "./components/MyButton.jsx";
import React from "react";
import { useState } from "react";
import sakura from "./images/sakura_flowers.gif";

function App() {
  function rand(min, max) {
    return Math.random() * (max - min) + min;
  }

  const handleMouseEnter = () => {
    const randButton = document.getElementById("nobutton");
    const divRect = document.getElementById("bdiv").getBoundingClientRect();

    randButton.style.left =
      rand(divRect.left, divRect.right - randButton.offsetWidth) + "px";
    randButton.style.top =
      rand(divRect.top, divRect.bottom - randButton.offsetHeight) + "px";
  };

  return (
    <div id="parentdiv" className="App">
      <img className="sakuraleft" src={sakura}></img>
      <img className="sakuraright" src={sakura}></img>
      {/* <div className="box">
        <span></span>
        <span></span>
        <span></span>
        <span></span>
        <div className="content">
          <h2>Test</h2>
        </div>
      </div> */}
      <div id="bdiv" className="btndiv">
        <div id="dialdiv" className="dial">
          <MyButton id="yesbutton" className="button" title="Yes" />
          <MyButton
            id="nobutton"
            className="buttonRandom"
            title="No"
            mouseEnter={handleMouseEnter}
          />
        </div>
      </div>
    </div>
  );
}

export default App;
