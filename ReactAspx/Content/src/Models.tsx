// A '.tsx' file enables JSX support in the TypeScript compiler, 
// for more information see the following page on the TypeScript wiki:
// https://github.com/Microsoft/TypeScript/wiki/JSX

import * as React from "react";
import * as ReactDOM from "react-dom";

export interface ArtistModel {

    Id: number;
    Name: string;
    Description: string;
    Picture: string;
    Price: number;
    Quantity: number; 
}

export interface IAppState {
    items: ArtistModel[];
    myOrder: ArtistModel[];
    showPopup: boolean;
    userId: number;
    orderPlaced: boolean;
}
