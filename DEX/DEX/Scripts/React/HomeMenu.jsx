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