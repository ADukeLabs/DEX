//const CityButton = (props) => {
//    return (
//        <div className="city-div">
//            <button className='city-button btn btn-primary btn-block' type="button">{props.city.name}</button>
//        </div>
//    );
//}

const data = [{ "Name": "Datacom" }, { "Name": "Intergen" }, { "Name": "MBIE" }, { "Name": "Xero" }];

function ListCompanies(props) {
    const listItems = this.props.data.map((c) =>
        <div className="col-xs-10 col-xs-offset-2 col-sm-6 col-sm-offset-4">
            <button type="button" className="btn btn-primary">c.Name</button>
        </div>
    );
    render() {
        return (listItems);
    }
}


class CityButton extends React.Component {
    render() {
        return (
            <div className="city-div">
                <button className='city-button btn btn-primary btn-block' type="button" onClick={ListCompanies(data)}>Wellington, New Zealand</button>
            </div>
        );
    }
}                                   


class Menu extends React.Component {
    render() {
        return (
            <CityButton />
        );
    }
}


class App extends React.Component {
    render() {
        return (
            <div>
                <Menu />
            </div>    
        );
    }
}


ReactDOM.render(
    <App/>,
    document.getElementById("app")
);