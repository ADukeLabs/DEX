const CompanyButton = (props) => {
    return (
        <div className="company-div col-xs-10 col-xs-offset-2 col-sm-6 col-sm-offset-4">
            <button type="button" className="company-button btn btn-primary">{props.company.Name}</button>
        </div>
    );
}


class CompanyButtonList extends React.Component {
    render() {

    }
}


const CityButton = (props) => {
    return (
        <div className="city-div">
            <button className='city-button btn btn-primary btn-block' type="button">{props.CityName}</button>
        </div> 
    );
}

const CityButtonList = (props) => {

}


class Menu extends React.Component {
    render() {
        return (
            <CityButtonList />
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
    <App />,
    document.getElementById("root")
);