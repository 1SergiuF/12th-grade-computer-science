import React, { ReactElement, useState } from "react";
import { MyButtonProps } from "../interfaces/ComponentPropsInterfaces";

const TSButton: React.FunctionComponent<MyButtonProps> = (props) => {
  const { myTitle, disable, ...MyButtonProps } = props;

  return (
    <button disabled={disable} {...MyButtonProps}>
      {myTitle}
    </button>
  );
};

export default TSButton;
