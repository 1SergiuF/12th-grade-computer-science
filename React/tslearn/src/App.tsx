import React, { ReactNode, useState } from "react";
import "./App.css";
import TSButton from "./components/TSButton";

type Person = {
  data: [number, string];
};
function App() {
  const [click, setClick] = useState(0);
  const handleClick = (e: React.MouseEvent<HTMLElement>) => {
    setClick(click + 1);
  };

  const tupleArray: Person[] = [
    { data: [18, "Sergiu"] },
    { data: [18, "Paul"] },
  ];
  return (
    <div className="App">
      <TSButton
        style={{ backgroundColor: "blue", width: "200px", height: "200px" }}
        disable={false}
        myTitle={click}
        onClick={handleClick}
      ></TSButton>
      <li>
        {tupleArray.map((t: Person) => (
          <p>{t.data[1]}</p>
        ))}
      </li>
    </div>
  );
}

export default App;
