import * as React from 'react';
import { BillList } from './BillList';
import * as ReactDOM from "react-dom";

export interface BillComponentProps {
    children?: React.ReactNode,
    bills?: BillList
}

export class BillComponent extends React.Component<BillComponentProps>{
    public render() {
        return <div className='container-fluid'>
            <div className='row'>
                <div className='col-sm-3'>
                    <BillList />
                </div>
                <div className='col-sm-9'>
                    {this.props.children}
                </div>
            </div>
        </div>;
    }
}