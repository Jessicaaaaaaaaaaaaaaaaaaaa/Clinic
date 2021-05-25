import React from 'react';

export const Greet  = (props) => {
    console.log(props);
    return (
        <h1>
            Funtional component - {props.name} - {props.age}
        </h1>
    );
}