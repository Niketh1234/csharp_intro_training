"use client"
import React from "react";
type Props = {
    title:string;
    handler: any
};

const Button = (props: Props) => {
  return <button onClick={props.handler}>{props.title}</button>;
};

export default Button;
