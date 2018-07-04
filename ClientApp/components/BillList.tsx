import * as React from 'react';
import { RouteComponentProps } from 'react-router';

interface BillState {
    bills: Bill[],
    loading: boolean
}

export class BillList extends React.Component<RouteComponentProps<{}>, BillState>
{
    constructor() {
        super();

        this.state = { bills: [], loading: true };

        fetch("api/SampleData/GetBills")
            .then(response => response.json() as Promise<Bill[]>)
            .then(data => {
                this.setState({
                    bills: data,
                    loading: false
                });
            });
    }

    public render() {

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : BillList.renderBillsToList(this.state.bills);

        return <div className="rendered-bills">
            <h1>Bills to pay</h1>
            {contents}
        </div>
    }

    public static renderBillsToList(bills: Bill[]) {

        return <ul>
            {bills.map((bill, i) =>
                <li key={i}> {bill.name} </li>
            )}
        </ul>;
    }
}

interface Bill {
    name: string;
}