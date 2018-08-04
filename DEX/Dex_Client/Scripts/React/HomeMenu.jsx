const CityButton = (props) => {
    return (
        <div className="city-div">
            <button className='city-button btn btn-primary btn-block' type="button">{props.city.name}</button>
        </div>
    );
}

//const CityButtonList = (props) => {

//}


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