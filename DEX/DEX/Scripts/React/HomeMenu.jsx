class Menu extends React.Component {
   render() {
        return (
            <div className="city-div">
                <button className='city-button btn btn-primary btn-block' type="button">Wellington, New Zealand</button>
             </div>
        );
    }
}

class App extends React.Component {
    render() {
        return (
            <div>
                <Menu/>
            </div>
        );
    }
}


ReactDOM.render(
    <App />,
    document.getElementById("root")
);